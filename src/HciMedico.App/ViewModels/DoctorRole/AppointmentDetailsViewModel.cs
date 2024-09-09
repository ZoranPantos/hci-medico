﻿using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.ViewModels.CounterWorkerRole;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.DoctorRole;

public class AppointmentDetailsViewModel : Conductor<object>
{
    private readonly int _id;
    private readonly AppointmentsDoctorViewModel _parentViewModel;
    private readonly IRepository<Appointment> _appointmentsRepository;
    private readonly IWindowManager _windowManager;
    private Appointment? _appointment;

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

    private AppointmentType _appointmentType;
    public AppointmentType AppointmentType
    {
        get => _appointmentType;
        set
        {
            _appointmentType = value;
            NotifyOfPropertyChange(() => AppointmentType);
        }
    }

    private AppointmentStatus _appointmentStatus;
    public AppointmentStatus AppointmentStatus
    {
        get => _appointmentStatus;
        set
        {
            _appointmentStatus = value;
            NotifyOfPropertyChange(() => AppointmentStatus);
        }
    }

    private string _requester = string.Empty;
    public string Requester
    {
        get => _requester;
        set
        {
            _requester = value;
            NotifyOfPropertyChange(() => Requester);
        }
    }

    private string _createdBy = string.Empty;
    public string CreatedBy
    {
        get => _createdBy;
        set
        {
            _createdBy = value;
            NotifyOfPropertyChange(() => CreatedBy);
        }
    }

    public DateTime _creationTime;
    public DateTime CreationTime
    {
        get => _creationTime;
        set
        {
            _creationTime = value;
            NotifyOfPropertyChange(() => CreationTime);
        }
    }

    public AppointmentDetailsViewModel(
        int id,
        AppointmentsDoctorViewModel parentViewModel,
        IRepository<Appointment> appointmentsRepository,
        IWindowManager windowManager)
    {
        _id = id;
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    private async Task InitializeViewModel()
    {
        try
        {
            _appointment = await _appointmentsRepository
                .FindAsync(appointment => appointment.Id == _id, false, "CreatedBy,Patient");

            if (_appointment is null)
                return;

            ScheduledFor = _appointment.DateAndTime;
            AppointmentType = _appointment.Type;
            AppointmentStatus = _appointment.Status;

            Requester = _appointment.Patient is not null ?
                $"{_appointment.Patient.FirstName} {_appointment.Patient.LastName}" : _appointment.IdentifierName;

            CreatedBy = $"{_appointment.CreatedBy.FirstName} {_appointment.CreatedBy.LastName}";
            CreationTime = _appointment.CreationTime;
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(AppointmentDetailsViewModel)}.{nameof(InitializeViewModel)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task RefreshViewModel() => await InitializeViewModel();

    public async Task NavigateBack() => await _parentViewModel.SelfActivateAsync();
}