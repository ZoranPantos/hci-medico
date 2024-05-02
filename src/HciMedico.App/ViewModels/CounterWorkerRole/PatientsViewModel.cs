using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.ViewModels.DoctorRole;
using HciMedico.App.ViewModels.Shared;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class PatientsViewModel : Conductor<object>
{
    private readonly IRepository<Patient> _patientRepository;
    private readonly ShellViewModel _shellViewModel;
    private readonly IMapper _mapper;

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

    public PatientsViewModel(IRepository<Patient> patientRepository, IMapper mapper, ShellViewModel shellViewModel)
    {
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _shellViewModel = shellViewModel ?? throw new ArgumentNullException(nameof(shellViewModel));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            var patients = await _patientRepository.GetAllAsync(null, true, "Appointments,HealthRecord");

            var patientDtos = _mapper.Map<List<PatientDisplayModel>>(patients)
                .OrderBy(dto => dto.FullName)
                .ToList();

            patientDtos.ForEach(Patients.Add);
        }
        catch (Exception)
        {

        }
    }

    public async Task OpenPatientDetails(TreatedPatientDisplayModel patient)
    {
        //await _shellViewModel.ActivateItemAsync(new TreatedPatientDetailsViewModel(patient.Id, _mapper, _patientRepository, this));
        // need new view and view model for this
    }

    public async Task Search(string searchBar)
    {

    }
}
