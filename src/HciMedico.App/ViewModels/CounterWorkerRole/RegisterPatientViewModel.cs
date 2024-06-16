using Caliburn.Micro;
using HciMedico.Domain.Models;
using HciMedico.Domain.Models.DisplayModels;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;
using HciMedico.Domain.Models.Relationships;
using HciMedico.App.Exceptions;
using HciMedico.App.Validation;
using AutoMapper;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class RegisterPatientViewModel : Conductor<object>
{
    private readonly IRepository<MedicalCondition> _medicalConditionsRepository;
    private readonly IRepository<Patient> _patientRepository;
    private readonly IRepository<Appointment> _appointmentsRepository;
    private readonly IInputValidator _inputValidator;
    private readonly IMapper _mapper;

    private PatientsViewModel? _parentViewModel;
    private List<MedicalCondition>? _medicalConditions = [];
    private List<Appointment>? _appointments = [];

    private string _firstName = string.Empty;
    public string FirstName
    {
        get => _firstName;
        set
        {
            _firstName = value;
            NotifyOfPropertyChange(() => FirstName);
        }
    }

    private string _lastName = string.Empty;
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            NotifyOfPropertyChange(() => LastName);
        }
    }

    private string _uid = string.Empty;
    public string Uid
    {
        get => _uid;
        set
        {
            _uid = value;
            NotifyOfPropertyChange(() => Uid);
        }
    }

    public Gender[] GenderOptions { get; } = Enum.GetValues<Gender>();

    private Gender _selectedGender;
    public Gender SelectedGender
    {
        get => _selectedGender;
        set
        {
            _selectedGender = value;
            NotifyOfPropertyChange(() => SelectedGender);
        }
    }

    public BloodGroup[] BloodGroupOptions { get; } = Enum.GetValues<BloodGroup>();

    private BloodGroup _selectedBloodGroup;
    public BloodGroup SelectedBloodGroup
    {
        get => _selectedBloodGroup;
        set
        {
            _selectedBloodGroup = value;
            NotifyOfPropertyChange(() => SelectedBloodGroup);
        }
    }

    private DateTime _dateOfBirth;
    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set
        {
            _dateOfBirth = value;
            NotifyOfPropertyChange(() => DateOfBirth);
        }
    }

    private string _country = string.Empty;
    public string Country
    {
        get => _country;
        set
        {
            _country = value;
            NotifyOfPropertyChange(() => Country);
        }
    }

    private string _city = string.Empty;
    public string City
    {
        get => _city;
        set
        {
            _city = value;
            NotifyOfPropertyChange(() => City);
        }
    }

    public string _street = string.Empty;
    public string Street
    {
        get => _street;
        set
        {
            _street = value;
            NotifyOfPropertyChange(() => Street);
        }
    }

    public string _number = string.Empty;
    public string Number
    {
        get => _number;
        set
        {
            _number = value;
            NotifyOfPropertyChange(() => Number);
        }
    }

    public string _email = string.Empty;
    public string Email
    {
        get => _email;
        set
        {
            _email = value;
            NotifyOfPropertyChange(() => Email);
        }
    }

    public string _telephoneNumber = string.Empty;
    public string TelephoneNumber
    {
        get => _telephoneNumber;
        set
        {
            _telephoneNumber = value;
            NotifyOfPropertyChange(() => TelephoneNumber);
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

    public BindableCollection<RegistrationLinkedAppointment> Appointments { get; set; } = [];

    private RegistrationLinkedAppointment? _selectedAppointment;
    public RegistrationLinkedAppointment? SelectedAppointment
    {
        get => _selectedAppointment;
        set
        {
            _selectedAppointment = value;
            NotifyOfPropertyChange(() => SelectedAppointment);
        }
    }

    public MedicalConditionStatus[] MedicalConditionStatusOptions { get; } = Enum.GetValues<MedicalConditionStatus>();

    private MedicalConditionStatus _selectedMedicalConditionStatus;
    public MedicalConditionStatus SelectedMedicalConditionStatus
    {
        get => _selectedMedicalConditionStatus;
        set
        {
            _selectedMedicalConditionStatus = value;
            NotifyOfPropertyChange(() => SelectedMedicalConditionStatus);
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

    public RegisterPatientViewModel(
        IRepository<MedicalCondition> medicalConditionsRepository,
        IRepository<Patient> patientRepository,
        PatientsViewModel? parentViewModel,
        IInputValidator inputValidator,
        IRepository<Appointment> appointmentsRepository,
        IMapper mapper)
    {
        _medicalConditionsRepository = medicalConditionsRepository ?? throw new ArgumentNullException(nameof(medicalConditionsRepository));
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _inputValidator = inputValidator ?? throw new ArgumentNullException(nameof(inputValidator));
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
    }

    protected override async Task OnActivateAsync(CancellationToken cancellationToken)
    {
        try
        {
            _medicalConditions = await _medicalConditionsRepository.GetAllAsync(asReadOnly: true);

            _medicalConditions = _medicalConditions?.OrderBy(condition => condition.Name).ToList();

            _medicalConditions?.ForEach(MedicalConditions.Add);

            _appointments = await _appointmentsRepository
                .GetAllAsync(
                    appointment => !string.IsNullOrEmpty(appointment.IdentifierName) && appointment.DateAndTime.Date.Equals(DateTime.Today),
                    propertiesToInclude: "AssignedTo,HealthRecord,CreatedBy,Patient");

            _appointments = _appointments?.OrderBy(appointment => appointment.Time).ToList();

            var appointmentDtos = _mapper.Map<List<RegistrationLinkedAppointment>>(_appointments).ToList();

            Appointments.Clear();

            appointmentDtos?.ForEach(Appointments.Add);
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(RegisterPatientViewModel)}.{nameof(OnActivateAsync)}";
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
                Status = SelectedMedicalConditionStatus
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

            string message = $"Exception caught and rethrown in {nameof(RegisterPatientViewModel)}.{nameof(AddMedicalCondition)}";
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

            string message = $"Exception caught and rethrown in {nameof(RegisterPatientViewModel)}.{nameof(RemoveMedicalCondition)}";
            throw new MedicoException(message, ex);
        }
    }

    public bool CanSave(
        string firstName,
        string lastName,
        string uid,
        Gender selectedGender,
        DateTime dateOfBirth,
        string country,
        string city,
        string street,
        string number,
        string email,
        string telephoneNumber,
        RegistrationLinkedAppointment selectedAppointment)
    {
        return !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(uid) &&
            Enum.IsDefined(selectedGender) && dateOfBirth != DateTime.MinValue &&
            !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(number) &&
            !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telephoneNumber);
    }

    public async Task Save(
        string firstName,
        string lastName,
        string uid,
        Gender selectedGender,
        DateTime dateOfBirth,
        string country,
        string city,
        string street,
        string number,
        string email,
        string telephoneNumber,
        RegistrationLinkedAppointment selectedAppointment)
    {
        try
        {
            if (!_inputValidator.IsPersonNameValid(firstName) || !_inputValidator.IsPersonNameValid(lastName))
            {
                ValidationMessage = "Invalid first or last name value. Please check for non-letter values and leading/trailing whitespaces";
                return;
            }

            if (!_inputValidator.IsUidValid(uid))
            {
                ValidationMessage = "Invalid UID value. UID can only contain digits";
                return;
            }

            if (!_inputValidator.IsDateOfBirthValid(dateOfBirth))
            {
                ValidationMessage = "Invalid date of birth. Selected date is either too old or is in the future";
                return;
            }

            if (!_inputValidator.IsRegionalNameValid(country) || !_inputValidator.IsRegionalNameValid(city) || !_inputValidator.IsRegionalNameValid(street))
            {
                ValidationMessage = "Invalid county, city or a street name. Please check for non-letter values and leading/trailing whitespaces";
                return;
            }

            if (!_inputValidator.IsStreetNumberValid(number))
            {
                ValidationMessage = "Invalid street number value. Street number can be composed only of positive numbers and letters";
                return;
            }

            if (!_inputValidator.IsEmailValid(email))
            {
                ValidationMessage = "Invalid email format";
                return;
            }

            if (!_inputValidator.IsPhoneNumberValid(telephoneNumber))
            {
                ValidationMessage = "Invalid phone number. Try to input full number format";
                return;
            }

            //try to find patient with the same UID in db, if one exists show validation error
            var existingPatient = await _patientRepository.FindAsync(patient => patient.Uid.Equals(uid), true);

            if (existingPatient is not null)
            {
                ValidationMessage = "Patient with the same UID is already registered";
                return;
            }

            //Create new patient
            var patient = new Patient
            {
                Uid = uid,
                FirstName = firstName,
                LastName = lastName,
                Address = new Address
                {
                    Country = country,
                    City = city,
                    Street = street,
                    //TODO: Replace number int with number string
                    Number = int.Parse(number)
                },
                ContactInfo = new()
                {
                    Email = email,
                    TelephoneNumber = telephoneNumber
                },

                //Create semi-emtpy health record, appointment and conditions will be added after
                HealthRecord = new()
                {
                    DateOfBirth = dateOfBirth,
                    Gender = selectedGender,
                    BloodGroup = SelectedBloodGroup,
                    HealthRecordMedicalConditions = [],
                    Appointments = []
                },
                Appointments = []
            };

            //iterate through patient's medical conditions (if any) and add new healthrecord_medicalconditions in patient.healthrecord.healthrecordmedicalconditions

            foreach (var condition in _addedMedicalConditionDisplayModels)
            {
                int conditionId = _medicalConditions.FirstOrDefault(con => con.Name.Equals(condition.Name)).Id;

                //This ID will be 0 when debugging but upon saving changes, EF Core will figure out which is the next ID and save it correctly in the db
                int healthRecordId = patient.HealthRecord.Id;

                patient.HealthRecord.HealthRecordMedicalConditions.Add(new HealthRecordMedicalCondition
                {
                    HealthRecordId = healthRecordId,
                    MedicalConditionId = conditionId,
                    Status = condition.Status
                });
            }

            //TODO:
            //When a new patient is registered in the system, he needs to be linked with his appointment
            //If there is currently no appointment for the patient, he will still be added in the system nonetheless
            var appointment = _appointments?.FirstOrDefault(apt => apt.Id == selectedAppointment?.Id);

            if (appointment is not null)
                patient.HealthRecord.Appointments.Add(appointment);

            await _patientRepository.Add(patient);

            if (appointment is not null)
            {
                appointment.PatientId = patient.Id;
                await _appointmentsRepository.Update(appointment);
            }
                
            await TryCloseAsync();

            await _parentViewModel!.RefreshViewModel();
        }
        catch (Exception ex)
        {
            ValidationMessage = "Failed to update patient details";

            string message = $"Exception caught and rethrown in {nameof(RegisterPatientViewModel)}.{nameof(Save)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}
