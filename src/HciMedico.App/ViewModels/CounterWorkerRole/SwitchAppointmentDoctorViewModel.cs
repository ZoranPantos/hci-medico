﻿using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Interfaces;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class SwitchAppointmentDoctorViewModel : Conductor<object>
{
    private Appointment? _appointment;
    private readonly IRepository<Appointment> _appointmentsRepository;
    private readonly IRepository<Doctor> _doctorsRepository;
    private AppointmentDetailsViewModel? _parentViewModel;
    private readonly IToastNotificationService _toastNotificationService;

    private DateTime _scheduledFor = DateTime.MinValue;
    public DateTime ScheduledFor
    {
        get => _scheduledFor;
        set
        {
            _scheduledFor = value;
            NotifyOfPropertyChange(() => ScheduledFor);
        }
    }

    private string _specializations = string.Empty;
    public string Specializations
    {
        get => _specializations;
        set
        {
            _specializations = value;
            NotifyOfPropertyChange(() => Specializations);
        }
    }

    private List<Doctor> _allSpecializedDoctors = [];

    public BindableCollection<Doctor> AvailableDoctors { get; set; } = [];

    private Doctor? _selectedDoctor = null;
    public Doctor? SelectedDoctor
    {
        get => _selectedDoctor;
        set
        {
            _selectedDoctor = value;
            NotifyOfPropertyChange(() => SelectedDoctor);
        }
    }

    public SwitchAppointmentDoctorViewModel(
        Appointment? appointment,
        IRepository<Appointment> appointmentsRepository,
        IRepository<Doctor> doctorsRepository,
        AppointmentDetailsViewModel? parentViewModel,
        IToastNotificationService toastNotificationService)
    {
        _appointment = appointment ?? throw new ArgumentNullException(nameof(appointment));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _doctorsRepository = doctorsRepository ?? throw new ArgumentNullException(nameof(doctorsRepository));
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _toastNotificationService = toastNotificationService ?? throw new ArgumentNullException(nameof(toastNotificationService));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            var currentlyAssignedDoctor = _appointment!.AssignedTo;
            var assignedDoctorSpecializations = currentlyAssignedDoctor.Specializations.ToList();

            _allSpecializedDoctors = await _doctorsRepository
                .GetAllAsync(doctor =>
                    doctor.Specializations.Any(specialization => assignedDoctorSpecializations.Contains(specialization)), asReadOnly: false, propertiesToInclude: "Specializations");

            _allSpecializedDoctors = _allSpecializedDoctors.OrderBy(doctor => doctor.FullName).ToList();

            // All busy doctors should be removed from the selection
            var appointments = await _appointmentsRepository.GetAllAsync(appointment =>
                appointment.DateAndTime.Date == _appointment.DateAndTime.Date &&
                (appointment.DateAndTime.TimeOfDay == _appointment.DateAndTime.TimeOfDay ||
                appointment.DateAndTime.TimeOfDay == _appointment.DateAndTime.AddMinutes(-5).TimeOfDay ||
                appointment.DateAndTime.TimeOfDay == _appointment.DateAndTime.AddMinutes(-10).TimeOfDay ||
                appointment.DateAndTime.TimeOfDay == _appointment.DateAndTime.AddMinutes(-15).TimeOfDay)
            );

            var busyDoctors = appointments.Select(appointment => appointment.AssignedTo);

            foreach (var doctor in _allSpecializedDoctors)
            {
                if (!busyDoctors.Contains(doctor) || (busyDoctors.Contains(doctor) && doctor.Id == _appointment.AssignedTo.Id))
                    AvailableDoctors.Add(doctor);
            }

            SelectedDoctor = currentlyAssignedDoctor;

            ScheduledFor = _appointment!.DateAndTime;

            string specializations = "";

            foreach (var specialization in assignedDoctorSpecializations)
                specializations += $"{specialization.Name}, ";

            Specializations = specializations[..^2];
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(SwitchAppointmentDoctorViewModel)}.{nameof(OnActivateAsync)}";
            throw new MedicoException(message, ex);
        }
    }

    public bool CanSave(Doctor selectedDoctor) => selectedDoctor is not null && AvailableDoctors.Count > 1;

    public async Task Save(Doctor selectedDoctor)
    {
        try
        {
            if (_appointment is null) return;

            _appointment.AssignedTo = SelectedDoctor!;

            await _appointmentsRepository.Update(_appointment);

            await TryCloseAsync();

            await _parentViewModel!.RefreshViewModel();

            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Doctor assigned" :
                "Doktor zamijenjen";

            _toastNotificationService.ShowSuccess(toastMessage);
        }
        catch (Exception ex)
        {
            string toastMessage = UserContext.CurrentUser?.UserSettings.ApplicationLanguage == ApplicationLanguage.English ?
                "Assign failed" :
                "Zamjena neuspješna";

            _toastNotificationService.ShowError(toastMessage);

            string message = $"Exception caught and rethrown in {nameof(SwitchAppointmentDoctorViewModel)}.{nameof(Save)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}
