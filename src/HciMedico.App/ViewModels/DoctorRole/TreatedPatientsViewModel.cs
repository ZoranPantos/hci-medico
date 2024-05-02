﻿using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.ViewModels.Shared;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Integration.Data.Repositories;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace HciMedico.App.ViewModels.DoctorRole;

public class TreatedPatientsViewModel : Conductor<object>
{
    private readonly IRepository<Patient> _patientRepository;
    private readonly ShellViewModel _shellViewModel;
    private readonly IMapper _mapper;

    private BindableCollection<TreatedPatientDisplayModel> _treatedPatients = [];
    public BindableCollection<TreatedPatientDisplayModel> TreatedPatients
    {
        get => _treatedPatients;
        set => _treatedPatients = value;
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

    public TreatedPatientsViewModel(IRepository<Patient> patientRepository, IMapper mapper, ShellViewModel shellViewModel)
    {
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _shellViewModel = shellViewModel ?? throw new ArgumentNullException(nameof(shellViewModel));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    // this one gets called each time a view-model is activated compared to OnInitialize which gets called only once the first time this view-model is activated
    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            var treatedPatients = await FetchTreatedPatients();

            var treatedPatientsDtos = _mapper.Map<List<TreatedPatientDisplayModel>>(treatedPatients)
                .OrderBy(dto => dto.FullName)
                .ToList();

            treatedPatientsDtos.ForEach(TreatedPatients.Add);
        }
        catch (Exception)
        {

        }
    }

    public async Task OpenPatientDetails(TreatedPatientDisplayModel patient) =>
        await _shellViewModel.ActivateItemAsync(new TreatedPatientDetailsViewModel(patient.Id, _mapper, _patientRepository, this));

    //Purpose: so that child view-model can navigate backwards to parent
    public async Task SelfActivateAsync() =>
        await _shellViewModel.ActivateItemAsync(new TreatedPatientsViewModel(_patientRepository, _mapper, _shellViewModel));

    public async Task Search(string searchBar)
    {
        var treatedPatients = await FetchTreatedPatients();
        var filteredPatients = new List<Patient>();

        searchBar = searchBar.Trim();

        if (!string.IsNullOrEmpty(searchBar))
        {
            searchBar = Regex.Replace(searchBar, @"\s+", " ");

            string[] queryPartitions = searchBar.Split(" ");

            if (queryPartitions.Length == 2)
            {
                filteredPatients = treatedPatients
                    .Where(patient =>
                        (patient.FirstName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase) &&
                        patient.LastName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase)) ||
                        (patient.FirstName.Equals(queryPartitions[1], StringComparison.OrdinalIgnoreCase) &&
                        patient.LastName.Equals(queryPartitions[0], StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }

            if (!filteredPatients.Any())
            {
                filteredPatients = treatedPatients
                    .Where(patient => queryPartitions
                        .Any(partition =>
                            patient.FirstName.StartsWith(partition, StringComparison.OrdinalIgnoreCase) ||
                            patient.LastName.StartsWith(partition, StringComparison.OrdinalIgnoreCase)))
                    .ToList();
            }
        }
        else
            filteredPatients = treatedPatients;

        var treatedPatientsDtos = _mapper.Map<List<TreatedPatientDisplayModel>>(filteredPatients)
            .OrderBy(dto => dto.FullName)
            .ToList();

        TreatedPatients.Clear();

        treatedPatientsDtos.ForEach(TreatedPatients.Add);
    }

    private async Task<List<Patient>> FetchTreatedPatients()
    {
        var currentDoctor = (Doctor?)(UserContext.CurrentUser?.Employee)
                ?? throw new Exception("Cannot load doctor entity");

        Expression<Func<Patient, bool>>? filter =
            patient => patient.Appointments.Select(appointment => appointment.DoctorId).Contains(currentDoctor.Id);

        var treatedPatients = await _patientRepository.GetAllAsync(filter, true, "Appointments,HealthRecord");

        return treatedPatients;
    }
}