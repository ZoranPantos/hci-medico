using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.ViewModels.CounterWorkerRole;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Integration.Data.Repositories;
using Microsoft.AspNetCore.Components.Forms;
using HciMedico.Domain.Models.Enums;
using HciMedico.Domain.Models.Entities;

namespace HciMedico.App.ViewModels.DoctorRole;

public class CreateReportViewModel : Conductor<object>
{
    private readonly IRepository<MedicalCondition> _medicalConditionsRepository;
    private readonly IRepository<MedicalReport> _medicalReportsRepository;
    private List<MedicalCondition>? _medicalConditions = [];
    private int _appointmentId;
    private int _healthRecordId;

    private DateTime _creationTime = DateTime.Now;
    public DateTime CreationTime
    {
        get => _creationTime;
        set
        {
            _creationTime = value;
            NotifyOfPropertyChange(() => CreationTime);
        }
    }

    private string _analysis = string.Empty;
    public string Analysis
    {
        get => _analysis;
        set
        {
            _analysis = value;
            NotifyOfPropertyChange(() => Analysis);
        }
    }

    private string _previousFindings = string.Empty;
    public string PreviousFindings
    {
        get => _previousFindings;
        set
        {
            _previousFindings = value;
            NotifyOfPropertyChange(() => PreviousFindings);
        }
    }

    private string _therapy = string.Empty;
    public string Therapy
    {
        get => _therapy;
        set
        {
            _therapy = value;
            NotifyOfPropertyChange(() => Therapy);
        }
    }

    private string _additionalNotes = string.Empty;
    public string AdditionalNotes
    {
        get => _additionalNotes;
        set
        {
            _additionalNotes = value;
            NotifyOfPropertyChange(() => AdditionalNotes);
        }
    }

    public BindableCollection<MedicalCondition> MedicalConditions { get; set; } = [];

    private MedicalCondition? _selectedMedicalCondition;
    public MedicalCondition? SelectedMedicalCondition
    {
        get => _selectedMedicalCondition;
        set
        {
            _selectedMedicalCondition = value;
            NotifyOfPropertyChange(() => SelectedMedicalCondition);
        }
    }

    public Queue<MedicalConditionDisplayModel> _addedMedicalConditionDisplayModels = [];

    private string _addedMedicalConditionDisplayModelsString = "None";
    public string AddedMedicalConditionDisplayModelsString
    {
        get => _addedMedicalConditionDisplayModelsString;
        set
        {
            _addedMedicalConditionDisplayModelsString = value;
            NotifyOfPropertyChange(() => AddedMedicalConditionDisplayModelsString);
        }
    }

    private string _validationMessage = string.Empty;
    public string ValidationMessage
    {
        get => _validationMessage;
        set
        {
            _validationMessage = value;
            NotifyOfPropertyChange(() => ValidationMessage);
        }
    }

    public CreateReportViewModel(int appointmentId, int healthRecordId, IRepository<MedicalCondition> medicalConditionsRepository, IRepository<MedicalReport> medicalReportsRepository)
    {
        _appointmentId = appointmentId;
        _healthRecordId = healthRecordId;
        _medicalConditionsRepository = medicalConditionsRepository ?? throw new ArgumentNullException(nameof(medicalConditionsRepository));
        _medicalReportsRepository = medicalReportsRepository ?? throw new ArgumentNullException(nameof(medicalReportsRepository));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            _medicalConditions = await _medicalConditionsRepository.GetAllAsync();

            _medicalConditions = _medicalConditions?.OrderBy(condition => condition.Name).ToList();

            _medicalConditions?.ForEach(MedicalConditions.Add);
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(CreateReportViewModel)}.{nameof(OnActivateAsync)}";
            throw new MedicoException(message, ex);
        }
    }

    public void AddMedicalCondition()
    {
        try
        {
            if (SelectedMedicalCondition is null ||
            _addedMedicalConditionDisplayModels.Any(condition => condition.Name.Equals(SelectedMedicalCondition.Name)))
            {
                return;
            }

            var displayModel = new MedicalConditionDisplayModel
            {
                Name = SelectedMedicalCondition.Name,
                Status = MedicalConditionStatus.Present
            };

            _addedMedicalConditionDisplayModels.Enqueue(displayModel);

            AddedMedicalConditionDisplayModelsString = "";

            foreach (var model in _addedMedicalConditionDisplayModels)
                AddedMedicalConditionDisplayModelsString += $"{model.Name} ({model.Status}), ";

            AddedMedicalConditionDisplayModelsString = AddedMedicalConditionDisplayModelsString[..^2];
        }
        catch (Exception ex)
        {
            ValidationMessage = "An error was encountered while trying to add a medical condition";

            string message = $"Exception caught and rethrown in {nameof(CreateReportViewModel)}.{nameof(AddMedicalCondition)}";
            throw new MedicoException(message, ex);
        }
    }

    public void RemoveMedicalCondition()
    {
        try
        {
            if (!_addedMedicalConditionDisplayModels.Any()) return;

            if (SelectedMedicalCondition is null ||
                !_addedMedicalConditionDisplayModels.Any(condition => condition.Name.Equals(SelectedMedicalCondition.Name)))
            {
                _addedMedicalConditionDisplayModels.Dequeue();
            }
            else if (SelectedMedicalCondition is not null &&
                _addedMedicalConditionDisplayModels.Any(condition => condition.Name.Equals(SelectedMedicalCondition.Name)))
            {
                _addedMedicalConditionDisplayModels = new(_addedMedicalConditionDisplayModels
                    .Where(model => !model.Name.Equals(SelectedMedicalCondition?.Name)));
            }

            AddedMedicalConditionDisplayModelsString = "";

            foreach (var model in _addedMedicalConditionDisplayModels)
                AddedMedicalConditionDisplayModelsString += $"{model.Name} ({model.Status}), ";

            if (AddedMedicalConditionDisplayModelsString.Length >= 2)
                AddedMedicalConditionDisplayModelsString = AddedMedicalConditionDisplayModelsString[..^2];

            if (string.IsNullOrEmpty(AddedMedicalConditionDisplayModelsString))
                AddedMedicalConditionDisplayModelsString = "None";
        }
        catch (Exception ex)
        {
            ValidationMessage = "An error was encountered while trying to remove a medical condition";

            string message = $"Exception caught and rethrown in {nameof(CreateReportViewModel)}.{nameof(RemoveMedicalCondition)}";
            throw new MedicoException(message, ex);
        }
    }

    public bool CanSave(string analysis, string previousFindings, string therapy, string additionalNotes) =>
        !string.IsNullOrEmpty(analysis) && _addedMedicalConditionDisplayModels.Any() && !string.IsNullOrEmpty(therapy);

    public async Task Save(string analysis, string previousFindings, string therapy, string additionalNotes)
    {
        try
        {
            var medicalReport = new MedicalReport
            {
                DateTime = _creationTime,
                Analysis = analysis,
                PreviousFindings = previousFindings,
                Therapy = therapy,
                AdditionalNotes = additionalNotes,
                MedicalConditions = [],
                AppointmentId = _appointmentId,
                HealthRecordId = _healthRecordId
            };

            var conditions = _medicalConditions?.Where(condition => _addedMedicalConditionDisplayModels.Any(model => model.Name.Equals(condition.Name))).ToList();
            conditions?.ForEach(medicalReport.MedicalConditions.Add);

            await _medicalReportsRepository.Add(medicalReport);

            await TryCloseAsync();
        }
        catch (Exception ex)
        {
            ValidationMessage = "Failed to create medical report";

            string message = $"Exception caught and rethrown in {nameof(CreateReportViewModel)}.{nameof(Save)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}
