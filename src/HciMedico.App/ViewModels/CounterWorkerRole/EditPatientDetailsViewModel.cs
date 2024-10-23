using Caliburn.Micro;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Interfaces;
using HciMedico.App.Validation;
using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class EditPatientDetailsViewModel : Conductor<object>
{
    private Patient? _patient;
    private readonly IRepository<Patient> _patientRepository;
    private readonly IInputValidator _inputValidator;
    private PatientDetailsViewModel? _parentViewModel;
    private readonly IToastNotificationService _toastNotificationService;

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

    public EditPatientDetailsViewModel(
        Patient? patient,
        IRepository<Patient> patientRepository,
        PatientDetailsViewModel parentViewModel,
        IInputValidator inputValidator,
        IToastNotificationService toastNotificationService)
    {
        _patient = patient ?? throw new ArgumentNullException(nameof(patient));
        _patientRepository = patientRepository ?? throw new ArgumentNullException(nameof(patientRepository));
        _parentViewModel = parentViewModel ?? throw new ArgumentNullException(nameof(parentViewModel));
        _inputValidator = inputValidator ?? throw new ArgumentNullException(nameof(inputValidator));
        _toastNotificationService = toastNotificationService ?? throw new ArgumentNullException(nameof(toastNotificationService));

        InitializeViewModel();
    }

    private void InitializeViewModel()
    {
        FirstName = _patient!.FirstName;
        LastName = _patient.LastName;
        Uid = _patient.Uid;
        SelectedGender = _patient.HealthRecord.Gender;
        DateOfBirth = _patient.HealthRecord.DateOfBirth;
        Country = _patient.Address.Country;
        City = _patient.Address.City;
        Street = _patient.Address.Street;

        //TODO: Number needs to be changed to string in the model
        Number = _patient.Address.Number.ToString();
        Email = _patient.ContactInfo.Email;
        TelephoneNumber = _patient.ContactInfo.TelephoneNumber;
    }

    public bool CanUpdate(
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
        string telephoneNumber)
    {
        return !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(uid) &&
            Enum.IsDefined(selectedGender) && dateOfBirth != DateTime.MinValue &&
            !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(number) &&
            !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telephoneNumber);
    }

    public async Task Update(
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
        string telephoneNumber)
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

            _patient!.FirstName = firstName;
            _patient.LastName = lastName;
            _patient.Uid = uid;
            _patient.HealthRecord.Gender = selectedGender;
            _patient.HealthRecord.DateOfBirth = dateOfBirth;
            _patient.Address.Country = country;
            _patient.Address.City = city;
            _patient.Address.Street = street;

            //TODO: Number needs to be string, otherwise risking exceptions
            _patient.Address.Number = int.Parse(number);

            _patient.ContactInfo.Email = email;
            _patient.ContactInfo.TelephoneNumber = telephoneNumber;

            await _patientRepository.Update(_patient);

            await TryCloseAsync();

            await _parentViewModel!.RefreshViewModel();

            _toastNotificationService.ShowSuccess("Patient updated");
        }
        catch (Exception ex)
        {
            ValidationMessage = "Failed to update patient details";
            _toastNotificationService.ShowError("Update failed");

            string message = $"Exception caught and rethrown in {nameof(EditPatientDetailsViewModel)}.{nameof(Update)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Cancel() => await TryCloseAsync();
}
