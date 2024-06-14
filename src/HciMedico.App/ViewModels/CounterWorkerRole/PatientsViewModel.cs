using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.ViewModels.Shared;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Integration.Data.Repositories;
using System.Text.RegularExpressions;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class PatientsViewModel : Conductor<object>
{
    private readonly IRepository<Patient> _patientRepository;
    private readonly ShellViewModel _shellViewModel;
    private readonly IMapper _mapper;
    private readonly IWindowManager _windowManager;

    private BindableCollection<PatientDisplayModel> _patients = [];
    public BindableCollection<PatientDisplayModel> Patients
    {
        get => _patients;
        set => _patients = value;
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

    public PatientsViewModel(IRepository<Patient> patientRepository, IMapper mapper, ShellViewModel shellViewModel, IWindowManager windowManager)
    {
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _shellViewModel = shellViewModel ?? throw new ArgumentNullException(nameof(shellViewModel));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    public async Task RefreshViewModel() => await InitializeViewModel();

    public async Task InitializeViewModel()
    {
        try
        {
            var patients = await _patientRepository.GetAllAsync(null, true, "Appointments,HealthRecord");

            var patientDtos = _mapper.Map<List<PatientDisplayModel>>(patients)
                .OrderBy(dto => dto.FullName)
                .ToList();

            Patients.Clear();

            patientDtos.ForEach(Patients.Add);
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(PatientsViewModel)}.{nameof(InitializeViewModel)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task OpenPatientDetails(PatientDisplayModel patient) =>
        await _shellViewModel.ActivateItemAsync(new PatientDetailsViewModel(patient.Id, _mapper, _patientRepository, this, IoC.Get<IWindowManager>()));

    public async Task SelfActivateAsync() =>
        await _shellViewModel.ActivateItemAsync(new PatientsViewModel(_patientRepository, _mapper, _shellViewModel, _windowManager));

    public async Task Search(string searchBar)
    {
        var patients = await _patientRepository.GetAllAsync(null, true, "Appointments,HealthRecord");
        var filteredPatients = new List<Patient>();

        searchBar = searchBar.Trim();

        if (!string.IsNullOrEmpty(searchBar))
        {
            searchBar = Regex.Replace(searchBar, @"\s+", " ");

            string[] queryPartitions = searchBar.Split(" ");

            if (queryPartitions.Length == 2)
            {
                filteredPatients = patients
                    .Where(patient =>
                        (patient.FirstName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase) &&
                        patient.LastName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase)) ||
                        (patient.FirstName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase) &&
                        patient.LastName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }

            if (!filteredPatients.Any())
            {
                filteredPatients = patients
                    .Where(patient => queryPartitions
                        .Any(partition =>
                            patient.FirstName.StartsWith(partition, StringComparison.OrdinalIgnoreCase) ||
                            patient.LastName.StartsWith(partition, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }
        }
        else
            filteredPatients = patients;

        var patientDtos = _mapper.Map<List<PatientDisplayModel>>(filteredPatients)
            .OrderBy(dto => dto.FullName)
            .ToList();

        Patients.Clear();

        patientDtos.ForEach(Patients.Add);
    }

    public async Task RegisterNewPatient() =>
        await _windowManager.ShowWindowAsync(new RegisterPatientViewModel(IoC.Get<IRepository<MedicalCondition>>(), _patientRepository, this));
}
