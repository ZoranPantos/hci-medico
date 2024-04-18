using AutoMapper;
using Caliburn.Micro;
using HciMedico.Library.Data.Repositories;
using HciMedico.Library.Models;
using HciMedico.Library.Models.DTOs;
using System.Linq.Expressions;

namespace HciMedico.App.ViewModels.DoctorRole;

public class TreatedPatientsViewModel : Conductor<object>
{
    private readonly IRepository<Patient> _patientRepository;
    private readonly IMapper _mapper;

    private BindableCollection<TreatedPatientDisplayModel> _treatedPatients { get; set; } = [];
    public BindableCollection<TreatedPatientDisplayModel> TreatedPatients
    {
        get => _treatedPatients;
        set => _treatedPatients = value;
    }

    public TreatedPatientsViewModel(IRepository<Patient> patientRepository, IMapper mapper)
    {
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    // this one gets called each time a view-model is activated compared to OnInitialize which gets called only once the first time this view-model is activated
    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            var currentDoctor = (Doctor?)(UserContext.CurrentUser?.Employee)
                ?? throw new Exception("Cannot load doctor entity");

            Expression<Func<Patient, bool>>? filter =
                patient => patient.Appointments.Select(appointment => appointment.DoctorId).Contains(currentDoctor.Id);

            var treatedPatients = await _patientRepository.GetAllAsync(filter, true, "Appointments,HealthRecord");

            var treatedPatientsDtos = _mapper.Map<List<TreatedPatientDisplayModel>>(treatedPatients);

            treatedPatientsDtos.ForEach(patient => TreatedPatients.Add(patient));
        }
        catch (Exception)
        {

        }
    }
}
