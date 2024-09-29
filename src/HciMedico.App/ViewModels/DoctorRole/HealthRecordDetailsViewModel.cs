using AutoMapper;
using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.DoctorRole;

public class HealthRecordDetailsViewModel : Conductor<object>
{
    private readonly int _id;
    private readonly HealthRecordsDoctorViewModel _parentViewModel;
    private readonly IRepository<HealthRecord> _healthRecordsRepository;
    private readonly IWindowManager _windowManager;
    private readonly IMapper _mapper;
    private HealthRecord? _healthRecord;

    private BindableCollection<MedicalReportDisplayModel> _medicalReports = [];
    public BindableCollection<MedicalReportDisplayModel> MedicalReports
    {
        get => _medicalReports;
        set => _medicalReports = value;
    }

    public string _patientFullName = string.Empty;
    public string PatientFullName
    {
        get => _patientFullName;
        set
        {
            _patientFullName = value;
            NotifyOfPropertyChange(() => PatientFullName);
        }
    }

    public string _patientUid = string.Empty;
    public string PatientUid
    {
        get => _patientUid;
        set
        {
            _patientUid = value;
            NotifyOfPropertyChange(() => PatientUid);
        }
    }

    public DateTime _dateOfBirth;
    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set
        {
            _dateOfBirth = value;
            NotifyOfPropertyChange(() => DateOfBirth);
        }
    }

    public Gender _gender;
    public Gender Gender
    {
        get => _gender;
        set
        {
            _gender = value;
            NotifyOfPropertyChange(() => Gender);
        }
    }

    public BloodGroup _bloodGroup;
    public BloodGroup BloodGroup
    {
        get => _bloodGroup;
        set
        {
            _bloodGroup = value;
            NotifyOfPropertyChange(() => BloodGroup);
        }
    }

    public int _attendedAppointmentsCount;
    public int AttendedAppointmentsCount
    {
        get => _attendedAppointmentsCount;
        set
        {
            _attendedAppointmentsCount = value;
            NotifyOfPropertyChange(() => AttendedAppointmentsCount);
        }
    }

    public DateTime _lastAppointmentDate;
    public DateTime LastAppointmentDate
    {
        get => _lastAppointmentDate;
        set
        {
            _lastAppointmentDate = value;
            NotifyOfPropertyChange(() => LastAppointmentDate);
        }
    }

    public HealthRecordDetailsViewModel(
        int id,
        HealthRecordsDoctorViewModel parentViewModel,
        IRepository<HealthRecord> healthRecordsRepository,
        IWindowManager windowManager,
        IMapper mapper)
    {
        _id = id;
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _healthRecordsRepository = healthRecordsRepository ?? throw new ArgumentNullException(nameof(healthRecordsRepository));
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    private async Task InitializeViewModel()
    {
        try
        {
            _healthRecord = await _healthRecordsRepository
                .FindAsync(record => record.Id == _id, false, "Patient,Appointments.AssignedTo,MedicalReports");

            if (_healthRecord is null)
                return;

            PatientFullName = _healthRecord.Patient.FullName;
            PatientUid = _healthRecord.Patient.Uid;
            DateOfBirth = _healthRecord.DateOfBirth;
            Gender = _healthRecord.Gender;
            BloodGroup = _healthRecord.BloodGroup;

            AttendedAppointmentsCount = _healthRecord.Appointments.Where(appointment => appointment.Status == AppointmentStatus.Resolved).Count();
            LastAppointmentDate = _healthRecord.Appointments.Max(appointment => appointment.DateAndTime);

            var medicalReportDtos = _mapper.Map<List<MedicalReportDisplayModel>>(_healthRecord.MedicalReports)
                .OrderByDescending(dto => dto.DateAndTime)
                .ToList();

            MedicalReports.Clear();

            medicalReportDtos.ForEach(MedicalReports.Add);
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(HealthRecordDetailsViewModel)}.{nameof(InitializeViewModel)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task RefreshViewModel() => await InitializeViewModel();

    public async Task NavigateBack() => await _parentViewModel.SelfActivateAsync();

    public async Task OpenMedicalReport(MedicalReportDisplayModel medicalReport) =>
        await _windowManager.ShowWindowAsync(new MedicalReportDetailsViewModel(medicalReport.Id, IoC.Get<IRepository<MedicalReport>>()));
}
