using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Helpers;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class HealthRecordDetailsViewModel : Conductor<object>
{
    private readonly int _id;
    private readonly HealthRecordsCounterWorkerViewModel _parentViewModel;
    private readonly IRepository<HealthRecord> _healthRecordsRepository;
    private readonly IWindowManager _windowManager;
    private HealthRecord? _healthRecord;

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

    public string _lastAppointmentDate = string.Empty;
    public string LastAppointmentDate
    {
        get => _lastAppointmentDate;
        set
        {
            _lastAppointmentDate = value;
            NotifyOfPropertyChange(() => LastAppointmentDate);
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

    public HealthRecordDetailsViewModel(
        int id,
        HealthRecordsCounterWorkerViewModel parentViewModel,
        IRepository<HealthRecord> healthRecordsRepository,
        IWindowManager windowManager)
    {
        _id = id;
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _healthRecordsRepository = healthRecordsRepository ?? throw new ArgumentNullException(nameof(healthRecordsRepository));
        _windowManager = windowManager ?? throw new ArgumentNullException(nameof(windowManager));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken) => await InitializeViewModel();

    private async Task InitializeViewModel()
    {
        try
        {
            _healthRecord = await _healthRecordsRepository
                .FindAsync(record => record.Id == _id, false, "Patient,Appointments,HealthRecordMedicalConditions.MedicalCondition");

            if (_healthRecord is null) return;

            PatientFullName = _healthRecord.Patient.FullName;
            PatientUid = _healthRecord.Patient.Uid;
            DateOfBirth = _healthRecord.DateOfBirth;
            Gender = _healthRecord.Gender;
            BloodGroup = _healthRecord.BloodGroup;

            AttendedAppointmentsCount = _healthRecord.Appointments.Where(appointment => appointment.Status == AppointmentStatus.Resolved).Count();

            LastAppointmentDate = AttendedAppointmentsCount > 0 ?
                _healthRecord.Appointments
                    .Where(appointment => appointment.Status == AppointmentStatus.Resolved)
                    .Max(appointment => appointment.DateAndTime).Date.ToString("dd/MM/yyyy") :
                DisplayMessages.NoData;

            var conditions = _healthRecord.HealthRecordMedicalConditions.Select(hrmc => new
            {
                ConditionName = hrmc.MedicalCondition.Name,
                ConditionStatus = hrmc.Status.ToString()
            }).ToList();

            string diagnosis = "";
            conditions.ForEach(condition => diagnosis += $"{condition.ConditionName} ({condition.ConditionStatus}), ");

            var lang = UserContext.CurrentUser?.UserSettings.ApplicationLanguage;

            Diagnosis = !string.IsNullOrEmpty(diagnosis) ?
                diagnosis[..^2] :
                lang == ApplicationLanguage.English ? DisplayMessages.NoData : "Nema podataka";
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(HealthRecordDetailsViewModel)}.{nameof(InitializeViewModel)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task RefreshViewModel() => await InitializeViewModel();

    public async Task NavigateBack() => await _parentViewModel.SelfActivateAsync();
}
