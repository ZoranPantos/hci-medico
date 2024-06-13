﻿using Caliburn.Micro;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class ScheduleAppointmentViewModel : Conductor<object>
{
    private readonly IRepository<Patient> _patientRepository;
    private readonly IRepository<Doctor> _doctorsRepository;
    private readonly IRepository<Appointment> _appointmentsRepository;
    private readonly IRepository<MedicalSpecialization> _medicalSpecializationsRepository;
    private AppointmentsCounterWorkerViewModel? _parentViewModel;
    private List<Doctor> _allDoctors = [];

    public BindableCollection<Doctor> AvailableDoctors { get; set; } = [];

    private Doctor? _selectedDoctor;
    public Doctor? SelectedDoctor
    {
        get => _selectedDoctor;
        set
        {
            _selectedDoctor = value;
            NotifyOfPropertyChange(() => SelectedDoctor);
        }
    }

    public BindableCollection<MedicalSpecialization> AvailableSpecializations { get; set; } = [];

    private MedicalSpecialization? _selectedMedicalSpecialization;
    public MedicalSpecialization? SelectedMedicalSpecialization
    {
        get => _selectedMedicalSpecialization;
        set
        {
            _selectedMedicalSpecialization = value;
            NotifyOfPropertyChange(() => SelectedMedicalSpecialization);
            UpdateDoctorsSource();
        }
    }

    public BindableCollection<Patient> RegisteredPatients { get; set; } = [];

    private Patient? _selectedPatient;
    public Patient? SelectedPatient
    {
        get => _selectedPatient;
        set
        {
            _selectedPatient = value;
            NotifyOfPropertyChange(() => SelectedPatient);
        }
    }

    public AppointmentType[] AppointmentTypeOptions { get; } = Enum.GetValues<AppointmentType>();

    private AppointmentType _selectedAppointmentType;
    public AppointmentType SelectedAppointmentType
    {
        get => _selectedAppointmentType;
        set
        {
            _selectedAppointmentType = value;
            NotifyOfPropertyChange(() => SelectedAppointmentType);
        }
    }

    private string _requesterIdentifier = string.Empty;
    public string RequesterIdentifier
    {
        get => _requesterIdentifier;
        set
        {
            _requesterIdentifier = value;
            NotifyOfPropertyChange(() => RequesterIdentifier);
        }
    }

    private DateTime _appointmentDate = DateTime.Today;
    public DateTime AppointmentDate
    {
        get => _appointmentDate;
        set
        {
            _appointmentDate = value;
            NotifyOfPropertyChange(() => AppointmentDate);
        }
    }

    public DateTime MinAllowedDate { get; set; } = DateTime.Today;

    private TimeOnly? _appointmentTime;
    public TimeOnly? AppointmentTime
    {
        get => _appointmentTime;
        set
        {
            _appointmentTime = value;
            NotifyOfPropertyChange(() => AppointmentTime);
        }
    }

    public BindableCollection<TimeOnly> AvailableTimes { get; set; } = [];

    public ScheduleAppointmentViewModel(
        AppointmentsCounterWorkerViewModel? parentViewModel,
        IRepository<Patient> patientRepository,
        IRepository<Doctor> doctorsRepository,
        IRepository<MedicalSpecialization> medicalSpecializationsRepository,
        IRepository<Appointment> appointmentsRepository)
    {
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _doctorsRepository = doctorsRepository ?? throw new ArgumentNullException(nameof(doctorsRepository));
        _medicalSpecializationsRepository = medicalSpecializationsRepository ?? throw new ArgumentNullException(nameof(medicalSpecializationsRepository));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            _allDoctors = await _doctorsRepository.GetAllAsync(asReadOnly: false, propertiesToInclude: "Specializations");

            _allDoctors = _allDoctors.OrderBy(doctor => doctor.FullName).ToList();

            _allDoctors?.ForEach(AvailableDoctors.Add);

            var patients = await _patientRepository.GetAllAsync(asReadOnly: false, propertiesToInclude: "HealthRecord");

            patients = patients.OrderBy(patient => patient.FullName).ToList();

            patients?.ForEach(RegisteredPatients.Add);

            var medicalSpecializations = await _medicalSpecializationsRepository.GetAllAsync(propertiesToInclude: "Doctors");

            // For filtering purposes
            medicalSpecializations.Add(new MedicalSpecialization
            {
                Id = 0,
                Name = "ALL"
            });

            medicalSpecializations = medicalSpecializations.OrderBy(specialization => specialization.Name).ToList();

            medicalSpecializations.ForEach(AvailableSpecializations.Add);

            SelectedMedicalSpecialization = AvailableSpecializations.FirstOrDefault(spec => spec.Id == 0 && spec.Name.Equals("ALL"));

            // Mock
            // TODO: Implement processing real available times for appointments and fill the collection properly
            AvailableTimes.Add(new TimeOnly(10, 0));
            AvailableTimes.Add(new TimeOnly(10, 30));
            AvailableTimes.Add(new TimeOnly(11, 0));
            AvailableTimes.Add(new TimeOnly(17, 0));
            AvailableTimes.Add(new TimeOnly(17, 30));
            AvailableTimes.Add(new TimeOnly(18, 0));

        }
        catch (Exception)
        {

        }
    }

    private void UpdateDoctorsSource()
    {
        AvailableDoctors.Clear();

        if (_selectedMedicalSpecialization?.Id == 0 && _selectedMedicalSpecialization.Name.Equals("ALL"))
            AvailableDoctors.AddRange(_allDoctors);
        else
            AvailableDoctors.AddRange(_selectedMedicalSpecialization?.Doctors?.ToList());
    }

    public bool CanSchedule(Doctor? selectedDoctor, TimeOnly? appointmentTime, string requesterIdentifier, Patient? selectedPatient)
    {
        return selectedDoctor is not null &&
            appointmentTime is not null &&
            ((!string.IsNullOrEmpty(requesterIdentifier.Trim()) && selectedPatient is null) ||
            (string.IsNullOrEmpty(requesterIdentifier.Trim()) && selectedPatient is not null));
    }

    public async Task Schedule(Doctor? selectedDoctor, TimeOnly? appointmentTime, string requesterIdentifier, Patient? selectedPatient)
    {
        try
        {
            var appointment = new Appointment
            {
                DateAndTime = (AppointmentDate.Date).Add(new TimeSpan(AppointmentTime!.Value.Hour, AppointmentTime.Value.Minute, AppointmentTime.Value.Second)),
                Status = AppointmentStatus.Scheduled,
                Type = SelectedAppointmentType,
                AssignedTo = SelectedDoctor!,
                CounterWorkerId = UserContext.CurrentUser!.Id

                //Issue with saving in db
                //CreatedBy = (CounterWorker)UserContext.CurrentUser!.Employee
            };

            if (SelectedPatient is not null)
            {
                appointment.Patient = SelectedPatient;
                appointment.HealthRecord = SelectedPatient.HealthRecord;
            }
            else
                appointment.IdentifierName = RequesterIdentifier.Trim();

            await _appointmentsRepository.Add(appointment);

            await TryCloseAsync();

            await _parentViewModel!.RefreshViewModel();
        }
        catch (Exception)
        {
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}