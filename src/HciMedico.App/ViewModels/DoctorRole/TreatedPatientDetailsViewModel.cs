using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Helpers;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.DoctorRole;

public class TreatedPatientDetailsViewModel : Conductor<object>
{
    private readonly int _id;
    private readonly IMapper _mapper;
    private readonly IRepository<Patient> _patientRepository;

    private BindableCollection<TreatedPatientAppointmentDisplayModel> _appointments = [];
    public BindableCollection<TreatedPatientAppointmentDisplayModel> Appointments
    {
        get => _appointments;
        set
        {
            _appointments = value;
            NotifyOfPropertyChange(() => Appointments);
        }
    }

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

    private string _placeOfResidence = string.Empty;
    public string PlaceOfResidence
    {
        get => _placeOfResidence;
        set
        {
            _placeOfResidence = value;
            NotifyOfPropertyChange(() => PlaceOfResidence);
        }
    }

    private string _email = string.Empty;
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            NotifyOfPropertyChange(() => Email);
        }
    }

    private string _telephoneNumber = string.Empty;
    public string TelephoneNumber
    {
        get => _telephoneNumber;
        set
        {
            _telephoneNumber = value;
            NotifyOfPropertyChange(() => TelephoneNumber);
        }
    }

    public TreatedPatientDetailsViewModel(int id, IMapper mapper, IRepository<Patient> patientRepository)
    {
        _id = id;
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            var treatedPatient = await _patientRepository.FindAsync(patient => patient.Id == _id, true, "Appointments.AssignedTo,HealthRecord");

            FirstName = treatedPatient?.FirstName ?? DisplayMessages.NoData;
            LastName = treatedPatient?.LastName ?? DisplayMessages.NoData;

            PlaceOfResidence = treatedPatient is not null ?
                $"{treatedPatient.Address.City}, {treatedPatient.Address.Country}" : DisplayMessages.NoData;

            Email = treatedPatient?.ContactInfo.Email ?? DisplayMessages.NoData;
            TelephoneNumber = treatedPatient?.ContactInfo.TelephoneNumber ?? DisplayMessages.NoData;

            var validAppointments = treatedPatient?.Appointments
                .Where(appointment =>
                    appointment.AssignedTo.Id == UserContext.CurrentUser?.Id &&
                    !appointment.Status.Equals(AppointmentStatus.Cancelled))
                .OrderByDescending(appointment => appointment.DateAndTime)
                .ToList();

            var validAppointmentDtos = _mapper.Map<List<TreatedPatientAppointmentDisplayModel>>(validAppointments);

            Appointments.Clear();

            validAppointmentDtos.ForEach(Appointments.Add);
        }
        catch (Exception)
        {

        }
    }
}
