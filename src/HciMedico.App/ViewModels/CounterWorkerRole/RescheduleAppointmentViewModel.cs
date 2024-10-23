using Caliburn.Micro;
using HciMedico.App.Exceptions;
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
        IToastNotificationService toastNotificationService)
    {
        _appointment = appointment ?? throw new ArgumentNullException(nameof(appointment));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _toastNotificationService = toastNotificationService ?? throw new ArgumentNullException(nameof(toastNotificationService));
    }

    protected override Task OnActivateAsync(CancellationToken cancellationToken)
    {
        AppointmentDate = _appointment!.DateAndTime.Date;

        // Mock
        // TODO: Implement processing real available times for appointments and fill the collection properly
        AvailableTimes.Add(new TimeOnly(10, 0));
        AvailableTimes.Add(new TimeOnly(10, 30));
        AvailableTimes.Add(new TimeOnly(11, 0));
        AvailableTimes.Add(new TimeOnly(17, 0));
        AvailableTimes.Add(new TimeOnly(17, 30));
        AvailableTimes.Add(new TimeOnly(18, 0));

        return base.OnActivateAsync(cancellationToken);
    }

    public bool CanReschedule(TimeOnly? appointmentTime) => appointmentTime is not null;

    public async Task Reschedule(TimeOnly? appointmentTime)
    {
        try
        {
            var newDateTime = new DateTime(
                AppointmentDate.Year,
                AppointmentDate.Month,
                AppointmentDate.Day,
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
