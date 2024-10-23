using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Helpers;
using HciMedico.App.Services.Interfaces;
using HciMedico.App.Validation;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class PatientDetailsViewModel : Conductor<object>
{
    private readonly int _id;
    private readonly IMapper _mapper;
    private readonly IRepository<Patient> _patientRepository;
    private readonly PatientsViewModel _parentViewModel;
    private readonly IWindowManager _windowManager;
    private Patient? _patient;

    private string _firstName = string.Empty;
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            NotifyOfPropertyChange(() => FirstName);
        }
    }

    private string _lastName = string.Empty;
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            NotifyOfPropertyChange(() => LastName);
        }
    }

    public string _uid = string.Empty;
    public string UID
    {
        get => _uid;
        set
        {
            _uid = value;
            NotifyOfPropertyChange(() => UID);
        }
    }

    public string _gender = string.Empty;
    public string Gender
    {
        get => _gender;
        set
        {
            _gender = value;
            NotifyOfPropertyChange(() => Gender);
        }
    }

    public DateTime? _dateOfBirth = DateTime.MinValue;
    public DateTime? DateOfBirth
    {
        get => _dateOfBirth;
        set
        {
            _dateOfBirth = value;
            NotifyOfPropertyChange(() => DateOfBirth);
        }
    }

    private string _country = string.Empty;
    public string Country
    {
        get => _country;
        set
        {
            _country = value;
            NotifyOfPropertyChange(() => Country);
        }
    }

    private string _city = string.Empty;
    public string City
    {
        get => _city;
        set
        {
            _city = value;
            NotifyOfPropertyChange(() => City);
        }
    }

    public string _street = string.Empty;
    public string Street
    {
        get => _street;
        set
        {
            _street = value;
            NotifyOfPropertyChange(() => Street);
        }
    }

    public string _number = string.Empty;
    public string Number
    {
        get => _number;
        set
        {
            _number = value;
            NotifyOfPropertyChange(() => Number);
        }
    }

    public string _email = string.Empty;
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            NotifyOfPropertyChange(() => Email);
        }
    }

    public string _telephoneNumber = string.Empty;
    public string TelephoneNumber
    {
        get => _telephoneNumber;
        set
        {
            _telephoneNumber = value;
            NotifyOfPropertyChange(() => TelephoneNumber);
        }
    }

    public int _numberOfVisits;
    public int NumberOfVisits
    {
        get => _numberOfVisits;
        set
        {
            _numberOfVisits = value;
            NotifyOfPropertyChange(() => NumberOfVisits);
        }
    }

    public string _lastVisitDetails = string.Empty;
    public string LastVisitDetails
    {
        get => _lastVisitDetails;
        set
        {
            _lastVisitDetails = value;
            NotifyOfPropertyChange(() => LastVisitDetails);
        }
    }

    public string _nextAppointmentDetails = string.Empty;
    public string NextAppointmentDetails
    {
        get => _nextAppointmentDetails;
        set
        {
            _nextAppointmentDetails = value;
            NotifyOfPropertyChange(() => NextAppointmentDetails);
        }
    }

    public PatientDetailsViewModel(
        int id,
        IMapper mapper,
        IRepository<Patient> patientRepository,
        PatientsViewModel parentViewModel,
        IWindowManager windowManager)
    {
        _id = id;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
    }

    public async Task NavigateBack() => await _parentViewModel.SelfActivateAsync();

    public async Task RefreshViewModel() => await InitializeViewModel();

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    private async Task InitializeViewModel()
    {
        try
        {
            _patient = await _patientRepository
                .FindAsync(patient => patient.Id == _id, false, "Appointments.AssignedTo.Specializations,HealthRecord");

            FirstName = _patient?.FirstName ?? DisplayMessages.NoData;
            LastName = _patient?.LastName ?? DisplayMessages.NoData;
            UID = _patient?.Uid ?? DisplayMessages.NoData;
            Gender = _patient?.HealthRecord?.Gender.ToString() ?? DisplayMessages.NoData;
            DateOfBirth = _patient?.HealthRecord?.DateOfBirth ?? DateTime.MinValue;
            Country = _patient?.Address?.Country ?? DisplayMessages.NoData;
            City = _patient?.Address?.City ?? DisplayMessages.NoData;
            Street = _patient?.Address?.Street ?? DisplayMessages.NoData;
            Number = _patient?.Address?.Number.ToString() ?? DisplayMessages.NoData;
            Email = _patient?.ContactInfo?.Email ?? DisplayMessages.NoData;
            TelephoneNumber = _patient?.ContactInfo?.TelephoneNumber ?? DisplayMessages.NoData;
            NumberOfVisits = _patient?.Appointments.Count(appointment => appointment.Status == AppointmentStatus.Resolved) ?? 0;
            LastVisitDetails = GetAppointmentInfo(_patient, AppointmentStatus.Resolved) ?? DisplayMessages.NoData;
            NextAppointmentDetails = GetAppointmentInfo(_patient, AppointmentStatus.Scheduled) ?? DisplayMessages.NoData;
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(PatientDetailsViewModel)}.{nameof(InitializeViewModel)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task EditDetails() =>
        await _windowManager.ShowDialogAsync(new EditPatientDetailsViewModel(
            _patient,
            _patientRepository,
            this,
            IoC.Get<IInputValidator>(),
            IoC.Get<IToastNotificationService>()));

    public async Task ScheduleAppointment()
    {
        await _windowManager.ShowDialogAsync(
            new ScheduleAppointmentViewModel(
                this,
                IoC.Get<IRepository<Patient>>(),
                IoC.Get<IRepository<Doctor>>(),
                IoC.Get<IRepository<MedicalSpecialization>>(),
                IoC.Get<IRepository<Appointment>>(),
                IoC.Get<IToastNotificationService>(),
                _patient)
        );
    }

    private string? GetAppointmentInfo(Patient? patient, AppointmentStatus appointmentStatus)
    {
        try
        {
            Appointment? appointment = null;

            var appointments = patient?.Appointments
                .Where(appointment => appointment.Status == appointmentStatus).ToList();

            if (appointments is null)
                return null;

            if (appointmentStatus == AppointmentStatus.Resolved)
                appointment = appointments.MaxBy(appointment => appointment.DateAndTime);

            if (appointmentStatus == AppointmentStatus.Scheduled)
                appointment = appointments.MinBy(appointment => appointment.DateAndTime);

            if (appointment is null)
                return null;

            string appointmentDateTimeString = appointment?.DateAndTime.ToString("dd/MM/yyyy HH:mm") ?? string.Empty;

            var assignedDoctor = appointment?.AssignedTo;

            string assignedDoctorFullName = $"{assignedDoctor?.FirstName} {assignedDoctor?.LastName}";

            string assignedDoctorSpecializations = "";

            if (assignedDoctor is not null)
            {
                foreach (var specialization in assignedDoctor.Specializations)
                {
                    assignedDoctorSpecializations += $"{specialization?.Name}, ";
                }
            }

            //TODO: if this if clause is removed, exception will be thrown which will not be handled globally for some reason. Inspect this
            //TODO: Refactor this check because of potential negative indexes or something else. Either way it's a crappy way to handle this
            if (!string.IsNullOrEmpty(assignedDoctorSpecializations))
                assignedDoctorSpecializations = assignedDoctorSpecializations.Trim()[..^1];

            if (string.IsNullOrEmpty(appointmentDateTimeString) || string.IsNullOrEmpty(assignedDoctorFullName) || string.IsNullOrEmpty(assignedDoctorSpecializations))
                return null;

            return $"{appointmentDateTimeString} with {assignedDoctorFullName} ({assignedDoctorSpecializations})";
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(PatientDetailsViewModel)}.{nameof(GetAppointmentInfo)}";
            throw new MedicoException(message, ex);
        }
    }
}
