using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.Domain.Models.Entities;
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

    // Using explicit property binding instead of 'Can' method because with 'Can' method control flow will move into it
    // before view model is initialized fully, so objects required to perform a check will always be null
    private bool _canCreateReport;
    public bool CanCreateReport
    {
        get => _canCreateReport;
        set
        {
            _canCreateReport = value;
            NotifyOfPropertyChange(() => CanCreateReport);
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

            if (_appointment.Patient is not null)
            {
                Requester = $"{_appointment.Patient.FirstName} {_appointment.Patient.LastName}";
                CanCreateReport = true;
            }
            else
                Requester = _appointment.IdentifierName;

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

    public async Task CreateReport() =>
        await _windowManager.ShowDialogAsync(new CreateReportViewModel(_id, _appointment!.HealthRecordId ?? 0, IoC.Get<IRepository<MedicalCondition>>(), IoC.Get<IRepository<MedicalReport>>()));
}
