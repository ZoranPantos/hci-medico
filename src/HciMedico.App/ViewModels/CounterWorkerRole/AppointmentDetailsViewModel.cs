using Caliburn.Micro;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class AppointmentDetailsViewModel : Conductor<object>
{
    private readonly int _id;
    private readonly AppointmentsCounterWorkerViewModel _parentViewModel;
    private readonly IRepository<Appointment> _appointmentsRepository;
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

    private string _assignedTo = string.Empty;
    public string AssignedTo
    {
        get => _assignedTo;
        set
        {
            _assignedTo = value;
            NotifyOfPropertyChange(() => AssignedTo);
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

    public AppointmentDetailsViewModel(int id, AppointmentsCounterWorkerViewModel parentViewModel, IRepository<Appointment> appointmentsRepository)
    {
        _id = id;
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    private async Task InitializeViewModel()
    {
        _appointment = await _appointmentsRepository
            .FindAsync(appointment => appointment.Id == _id, false, "AssignedTo,CreatedBy,Patient");

        if (_appointment is null)
            return;

        ScheduledFor = _appointment.DateAndTime;
        AssignedTo = $"{_appointment.AssignedTo.FirstName} {_appointment.AssignedTo.LastName}";
        AppointmentType = _appointment.Type;
        AppointmentStatus = _appointment.Status;

        Requester = _appointment.Patient is not null ?
            $"{_appointment.Patient.FirstName} {_appointment.Patient.LastName}" : _appointment.IdentifierName;

        CreatedBy = $"{_appointment.CreatedBy.FirstName} {_appointment.CreatedBy.LastName}";
    }

    public async Task NavigateBack() => await _parentViewModel.SelfActivateAsync();
}
