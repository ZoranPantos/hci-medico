using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Interfaces;
using HciMedico.App.ViewModels.Shared;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class HealthRecordsCounterWorkerViewModel : Conductor<object>
{
    private readonly IRepository<HealthRecord> _healthRecordsRepository;
    private readonly ShellViewModel _shellViewModel;
    private readonly IMapper _mapper;
    private readonly IWindowManager _windowManager;
    private readonly ISearchService _searchService;

    private BindableCollection<HealthRecordDisplayModel> _healthRecords = [];
    public BindableCollection<HealthRecordDisplayModel> HealthRecords
    {
        get => _healthRecords;
        set => _healthRecords = value;
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

    public HealthRecordsCounterWorkerViewModel(
        IRepository<HealthRecord> healthRecordsRepository,
        IMapper mapper,
        ShellViewModel shellViewModel,
        IWindowManager windowManager,
        ISearchService searchService)
    {
        _healthRecordsRepository = healthRecordsRepository ?? throw new ArgumentNullException(nameof(healthRecordsRepository));
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
            var healthRecords = await _healthRecordsRepository.GetAllAsync(asReadOnly: true, propertiesToInclude: "Patient");

            var healthRecordDtos = _mapper.Map<List<HealthRecordDisplayModel>>(healthRecords)
                .OrderBy(dto => dto.PatientFullName)
                .ToList();

            HealthRecords.Clear();

            healthRecordDtos.ForEach(HealthRecords.Add);
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(HealthRecordsCounterWorkerViewModel)}.{nameof(InitializeViewModel)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task OpenHealthRecordDetails(HealthRecordDisplayModel healthRecord) =>
        await _shellViewModel.ActivateItemAsync(new HealthRecordDetailsViewModel(healthRecord.Id, this, _healthRecordsRepository, _windowManager));

    public async Task SelfActivateAsync() =>
        await _shellViewModel.ActivateItemAsync(new HealthRecordsCounterWorkerViewModel(_healthRecordsRepository, _mapper, _shellViewModel, _windowManager, _searchService));

    public async Task Search(string searchBar)
    {
        var healthRecords = await _healthRecordsRepository
            .GetAllAsync(asReadOnly: true, propertiesToInclude: "Patient");

        var filteredHealthRecords = _searchService.SearchHealthRecords(healthRecords, searchBar);

        var healthRecordDtos = _mapper.Map<List<HealthRecordDisplayModel>>(filteredHealthRecords)
            .OrderBy(dto => dto.PatientFullName)
            .ToList();

        HealthRecords.Clear();

        healthRecordDtos.ForEach(HealthRecords.Add);
    }
}
