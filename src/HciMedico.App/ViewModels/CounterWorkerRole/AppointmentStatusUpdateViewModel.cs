using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class AppointmentStatusUpdateViewModel : Conductor<object>
{
    private Appointment? _appointment;
    private readonly IRepository<Appointment> _appointmentsRepository;
    private AppointmentDetailsViewModel? _parentViewModel;

    private AppointmentStatus _selectedStatus = AppointmentStatus.Resolved;
    public AppointmentStatus SelectedStatus
    {
        get => _selectedStatus;
        set
        {
            _selectedStatus = value;
            NotifyOfPropertyChange(() => SelectedStatus);
        }
    }

    public AppointmentStatusUpdateViewModel(
        Appointment appointment,
        IRepository<Appointment> appointmentsRepository,
        AppointmentDetailsViewModel? parentViewModel)
    {
        _appointment = appointment ?? throw new ArgumentNullException(nameof(appointment));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));

        InitializeViewModel();
    }

    private void InitializeViewModel() => SelectedStatus = _appointment!.Status;

    public async Task Update()
    {
        try
        {
            if (_appointment is null)
                return;

            _appointment.Status = SelectedStatus;

            await _appointmentsRepository.Update(_appointment);

            await TryCloseAsync();

            await _parentViewModel!.RefreshViewModel();
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(AppointmentStatusUpdateViewModel)}.{nameof(Update)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}
