using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services;
using HciMedico.App.ViewModels.Shared;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.DoctorRole;

public class AppointmentsDoctorViewModel : Conductor<object>
{
    private readonly IRepository<Appointment> _appointmentsRepository;
    private readonly ShellViewModel _shellViewModel;
    private readonly IMapper _mapper;
    private readonly IWindowManager _windowManager;
    private readonly ISearchService _searchService;

    private BindableCollection<AppointmentDisplayModel> _appointments = [];
    public BindableCollection<AppointmentDisplayModel> Appointments
    {
        get => _appointments;
        set => _appointments = value;
    }

    private string _searchBar = string.Empty;
    public string SearchBar
    {
        get => _searchBar;
        set
        {
            _searchBar = value;
            NotifyOfPropertyChange(() => SearchBar);
        }
    }

    public AppointmentsDoctorViewModel(
        IRepository<Appointment> appointmentsRepository,
        IMapper mapper,
        ShellViewModel shellViewModel,
        IWindowManager windowManager,
        ISearchService searchService)
    {
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _shellViewModel = shellViewModel ?? throw new ArgumentNullException(nameof(shellViewModel));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
        _searchService = searchService ?? throw new ArgumentNullException(nameof(searchService));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    public async Task RefreshViewModel() => await InitializeViewModel();

    public async Task InitializeViewModel()
    {
        try
        {
            var appointments = await _appointmentsRepository
                .GetAllAsync(appointment => appointment.DateAndTime >= DateTime.Today &&
                             appointment.AssignedTo.Id == UserContext.CurrentUser!.Id,
                             true, "AssignedTo,Patient");

            var appointmentDtos = _mapper.Map<List<AppointmentDisplayModel>>(appointments)
                .OrderBy(dto => dto.Date)
                .ThenBy(dto => dto.Time)
                .ToList();

            Appointments.Clear();

            appointmentDtos.ForEach(Appointments.Add);
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(AppointmentsDoctorViewModel)}.{nameof(InitializeViewModel)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task SelfActivateAsync() =>
        await _shellViewModel.ActivateItemAsync(new AppointmentsDoctorViewModel(_appointmentsRepository, _mapper, _shellViewModel, _windowManager, _searchService));

    public async Task Search(string searchBar)
    {
        var appointments = await _appointmentsRepository
            .GetAllAsync(appointment => appointment.DateAndTime >= DateTime.Today &&
                         appointment.AssignedTo.Id == UserContext.CurrentUser!.Id,
                         true, "AssignedTo,Patient");

        var filteredAppointments = _searchService.SearchTrendingAppointments(appointments, searchBar);

        var appointmentDtos = _mapper.Map<List<AppointmentDisplayModel>>(filteredAppointments)
            .OrderBy(dto => dto.Date)
            .ThenBy(dto => dto.Time)
            .ToList();

        Appointments.Clear();

        appointmentDtos.ForEach(Appointments.Add);
    }
}
