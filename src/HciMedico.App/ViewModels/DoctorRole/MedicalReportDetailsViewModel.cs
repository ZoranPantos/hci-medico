using Caliburn.Micro;
using HciMedico.Domain.Models;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.DoctorRole;

public class MedicalReportDetailsViewModel : Conductor<object>
{
    private int _id;
    private readonly IRepository<MedicalReport> _medicalReportsRepository;
    private MedicalReport? _medicalReport;

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

    private string _diagnosis = string.Empty;
    public string Diagnosis
    {
        get => _diagnosis;
        set
        {
            _diagnosis = value;
            NotifyOfPropertyChange(() => Diagnosis);
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

    public MedicalReportDetailsViewModel(int id, IRepository<MedicalReport> medicalReportsRepository)
    {
        _id = id;
        _medicalReportsRepository = medicalReportsRepository ?? throw new ArgumentNullException(nameof(medicalReportsRepository));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        _medicalReport = await _medicalReportsRepository.FindAsync(record => record.Id == _id, true, "MedicalConditions");

        if (_medicalReport is null) return;

        Analysis = _medicalReport.Analysis;
        PreviousFindings = _medicalReport.PreviousFindings;

        string allConditions = "";
        _medicalReport.MedicalConditions.ToList().ForEach(condition => { allConditions += $"{condition.Name}, "; });

        Diagnosis = allConditions[..^2];
        Therapy = _medicalReport.Therapy;
        AdditionalNotes = _medicalReport.AdditionalNotes;
    }

    public async Task Close() => await TryCloseAsync();

    public void Export()
    {

    }
}
