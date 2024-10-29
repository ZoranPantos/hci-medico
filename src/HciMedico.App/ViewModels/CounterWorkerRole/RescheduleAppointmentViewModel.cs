using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Classes;
using HciMedico.App.Services.Interfaces;
using HciMedico.Domain.Models.Entities;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class RescheduleAppointmentViewModel : Conductor<object>
{
    private Appointment? _appointment;
    private readonly IRepository<Appointment> _appointmentsRepository;
    private AppointmentDetailsViewModel? _parentViewModel;
    private readonly IToastNotificationService _toastNotificationService;
    private readonly ITimeSlotDetectionService _timeSlotDetectionService;

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

    private DateTime _appointmentDate;
    private string _assignedDate = string.Empty;
    public string AssignedDate
    {
        get => _assignedDate;
        set
        {
            _assignedDate = value;
            NotifyOfPropertyChange(() => AssignedDate);
        }
    }

    private string _assignedTime = string.Empty;
    public string AssignedTime
    {
        get => _assignedTime;
        set
        {
            _assignedTime = value;
            NotifyOfPropertyChange(() => AssignedTime);
        }
    }

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

    public RescheduleAppointmentViewModel(
        Appointment? appointment,
        IRepository<Appointment> appointmentsRepository,
        AppointmentDetailsViewModel? parentViewModel,
        IToastNotificationService toastNotificationService,
        ITimeSlotDetectionService timeSlotDetectionService)
    {
        _appointment = appointment ?? throw new ArgumentNullException(nameof(appointment));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _toastNotificationService = toastNotificationService ?? throw new ArgumentNullException(nameof(toastNotificationService));
        _timeSlotDetectionService = timeSlotDetectionService ?? throw new ArgumentNullException(nameof(timeSlotDetectionService));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        AssignedTo = _appointment!.AssignedTo.FullName;
        _appointmentDate = _appointment.DateAndTime.Date;
        AssignedDate = _appointmentDate.ToString("dd/MM/yyyy");
        AssignedTime = _appointment.Time.ToString();

        await UpdateAvailableAppointmentTimes();
        AppointmentTime = AvailableTimes.FirstOrDefault();
    }

    private async Task UpdateAvailableAppointmentTimes()
    {
        if (_appointment?.AssignedTo is null) return;

        AvailableTimes.Clear();

        var availableTimes = (await _timeSlotDetectionService.GetTimeSlotsByDate(_appointmentDate, _appointment.AssignedTo)).ToList();
        availableTimes.ForEach(AvailableTimes.Add);
    }

    public bool CanReschedule(TimeOnly? appointmentTime) => appointmentTime is not null;

    public async Task Reschedule(TimeOnly? appointmentTime)
    {
        try
        {
            var newDateTime = new DateTime(
                _appointmentDate.Year,
                _appointmentDate.Month,
                _appointmentDate.Day,
                AppointmentTime!.Value.Hour,
                AppointmentTime!.Value.Minute,
                0);

            _appointment!.DateAndTime = newDateTime;

            await _appointmentsRepository.Update(_appointment);

            await TryCloseAsync();

            await _parentViewModel!.RefreshViewModel();

            _toastNotificationService.ShowSuccess("Appointment rescheduled");
        }
        catch (Exception ex)
        {
            _toastNotificationService.ShowError("Rescheduling failed");

            string message = $"Exception caught and rethrown in {nameof(RescheduleAppointmentViewModel)}.{nameof(Reschedule)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}
