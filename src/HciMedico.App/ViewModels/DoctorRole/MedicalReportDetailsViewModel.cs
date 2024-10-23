using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Interfaces;
using HciMedico.Domain.Models.DTOs;
using HciMedico.Domain.Models.Entities;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.DoctorRole;

public class MedicalReportDetailsViewModel : Conductor<object>
{
    private int _id;
    private readonly IRepository<MedicalReport> _medicalReportsRepository;
    private readonly IToastNotificationService _toastNotificationService;
    private readonly IPdfExporter _pdfExporter;
    private readonly IMapper _mapper;
    private MedicalReport? _medicalReport;

    public MedicalReport? MedicalReport => _medicalReport;

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

    public MedicalReportDetailsViewModel(int id,
        IRepository<MedicalReport> medicalReportsRepository,
        IPdfExporter pdfExporter,
        IMapper mapper,
        IToastNotificationService toastNotificationService)
    {
        _id = id;
        _medicalReportsRepository = medicalReportsRepository ?? throw new ArgumentNullException(nameof(medicalReportsRepository));
        _pdfExporter = pdfExporter ?? throw new ArgumentNullException(nameof(pdfExporter));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _toastNotificationService = toastNotificationService ?? throw new ArgumentNullException(nameof(toastNotificationService));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            _medicalReport = await _medicalReportsRepository.FindAsync(record => record.Id == _id, true, "MedicalConditions,HealthRecord.Patient,Appointment.AssignedTo");

            if (_medicalReport is null) return;

            Analysis = _medicalReport.Analysis;
            PreviousFindings = _medicalReport.PreviousFindings;

            string allConditions = "";
            _medicalReport.MedicalConditions.ToList().ForEach(condition => { allConditions += $"{condition.Name}, "; });

            Diagnosis = allConditions[..^2];
            Therapy = _medicalReport.Therapy;
            AdditionalNotes = _medicalReport.AdditionalNotes;
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(MedicalReportDetailsViewModel)}.{nameof(OnActivateAsync)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Close() => await TryCloseAsync();

    public void Export()
    {
        try
        {
            var exportDto = _mapper.Map<MedicalReportExportDto>(this);
            _pdfExporter.Export(exportDto);

            _toastNotificationService.ShowSuccess("Report exported");
        }
        catch (Exception ex)
        {
            _toastNotificationService.ShowError("Export failed");

            string message = $"Exception caught and rethrown in {nameof(MedicalReportDetailsViewModel)}.{nameof(Export)}";
            throw new MedicoException(message, ex);
        }
    }
}
