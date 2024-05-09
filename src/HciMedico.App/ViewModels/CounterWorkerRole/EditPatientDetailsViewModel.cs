using Caliburn.Micro;
using HciMedico.Domain.Models.Enums;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace HciMedico.App.ViewModels.CounterWorkerRole;

public class EditPatientDetailsViewModel : Conductor<object>
{
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
        string telephoneNumber)
    {
        return !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(uid) &&
            Enum.IsDefined(selectedGender) && dateOfBirth != DateTime.MinValue &&
            !string.IsNullOrEmpty(country) && !string.IsNullOrEmpty(city) && !string.IsNullOrEmpty(street) && !string.IsNullOrEmpty(number) &&
            !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(telephoneNumber);
    }

    public void Save(
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
        if (!ValidateFirstAndLastName(firstName, lastName))
        {
            ValidationMessage = "Invalid first or last name value. Please check for non-letter values and leading/trailing whitespaces";
            return;
        }

        if (!ValidateUID(uid))
        {
            ValidationMessage = "Invalid UID value. UID can only contain digits";
            return;
        }

        if (!ValidateDateOfBirth(dateOfBirth))
        {
            ValidationMessage = "Invalid date of birth. Selected date is either too old or is in the future";
            return;
        }

        if (!ValidateCountryCityAndStreetName(country, city, street))
        {
            ValidationMessage = "Invalid county, city or a street name. Please check for non-letter values and leading/trailing whitespaces";
            return;
        }

        if (!ValidateStreetNumber(number))
        {
            ValidationMessage = "Invalid street number value. Street number can be composed only of positive numbers and letters";
            return;
        }

        if (!ValidateEmail(email))
        {
            ValidationMessage = "Invalid email format";
            return;
        }
        
        if (!ValidatePhoneNumber(telephoneNumber))
        {
            ValidationMessage = "Invalid phone number. Try to input full number format";
            return;
        }

        ValidationMessage = "ALL IS GOOD";
    }

    public async Task Cancel() => await TryCloseAsync();

    private bool ValidateDateOfBirth(DateTime date) =>
        date.CompareTo(new DateTime(1920, 1, 1)) >= 0 && date.CompareTo(DateTime.Now.Date) <= 0;

    private bool ValidateEmail(string email)
    {
        try
        {
            var mailAddress = new MailAddress(email);

            return mailAddress.Address.Equals(email);
        }
        catch (Exception)
        {
            return false;
        }
    }

    private bool ValidatePhoneNumber(string telephoneNumber)
    {
        string pattern = @"\+(9[976]\d|8[987530]\d|6[987]\d|5[90]\d|42\d|3[875]\d|2[98654321]\d|9[8543210]|8
            [6421]|6[6543210]|5[87654321]|4[987654310]|3[9643210]|2[70]|7|1)\W*\d\W*\d\W*\d\W*\d\W*\d\W*\d\W*\d\W*(\d{1,2})$";
        
        var regex = new Regex(pattern);

        return regex.IsMatch(telephoneNumber);
    }

    private bool ValidateStreetNumber(string streetNumber)
    {
        string pattern = "^(?![a-zA-Z]+$)[a-zA-Z0-9]*$";

        var regex = new Regex(pattern);

        return regex.IsMatch(streetNumber);
    }

    private bool ValidateUID(string uid) => uid.All(Char.IsDigit);

    private bool ValidateFirstAndLastName(string firstName, string lastName)
    {
        string pattern = "^[a-zA-Z]+(?:\\s+[a-zA-Z]+)*$";

        var regex = new Regex(pattern);

        return regex.IsMatch(firstName) && regex.IsMatch(lastName);
    }

    private bool ValidateCountryCityAndStreetName(string country, string city, string street)
    {
        string pattern = "^[a-zA-Z]+(?:\\s+[a-zA-Z]+)*$";

        var regex = new Regex(pattern);

        return regex.IsMatch(country) && regex.IsMatch(city) && regex.IsMatch(street);
    }
}
