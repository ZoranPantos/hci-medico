using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.ViewModels.Shared;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class AppointmentsCounterWorkerViewModel : Conductor<object>
{
    private readonly IRepository<Appointment> _appointmentsRepository;
    private readonly ShellViewModel _shellViewModel;
    private readonly IMapper _mapper;
    private readonly IWindowManager _windowManager;

    private BindableCollection<AppointmentDisplayModel> _appointments = [];
    public BindableCollection<AppointmentDisplayModel> Appointments
    {
        get => _appointments;
        set => _appointments = value;
    }

    public AppointmentsCounterWorkerViewModel(
        IRepository<Appointment> appointmentsRepository,
        IMapper mapper,
        ShellViewModel shellViewModel,
        IWindowManager windowManager)
    {
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _shellViewModel = shellViewModel ?? throw new ArgumentNullException(nameof(shellViewModel));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    public async Task InitializeViewModel()
    {
        try
        {
            var appointments = await _appointmentsRepository
                .GetAllAsync(appointment => appointment.DateAndTime >= DateTime.Today, true, "AssignedTo,Patient");

            var appointmentDtos = _mapper.Map<List<AppointmentDisplayModel>>(appointments)
                .OrderBy(dto => dto.Date)
                .ThenBy(dto => dto.Time)
                .ToList();

            Appointments.Clear();

            appointmentDtos.ForEach(Appointments.Add);
        }
        catch (Exception)
        {

        }
    }
}
