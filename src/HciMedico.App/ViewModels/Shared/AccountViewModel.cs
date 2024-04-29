using Caliburn.Micro;
using HciMedico.App.Helpers;
using HciMedico.Domain.Models;

namespace HciMedico.App.ViewModels.Shared;

public class AccountViewModel : Conductor<object>
{
    private string _username = string.Empty;
    public string Username
    {
        get => _username;
        set
        {
            _username = value;
            NotifyOfPropertyChange(() => Username);
        }
    }

    private string _userRole = string.Empty;
    public string UserRole
    {
        get => _userRole;
        set
        {
            _userRole = value;
            NotifyOfPropertyChange(() => UserRole);
        }
    }

    private DateTime _passwordLastUpdated = DateTime.MinValue;
    public DateTime PasswordLastUpdated
    {
        get => _passwordLastUpdated;
        set
        {
            _passwordLastUpdated = value;
            NotifyOfPropertyChange(() => PasswordLastUpdated);
        }
    }

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

    private string _gender = string.Empty;
    public string Gender
    {
        get => _gender;
        set
        {
            _gender = value;
            NotifyOfPropertyChange(() => Gender);
        }
    }

    private DateOnly? _dateOfBirth = DateOnly.MinValue;
    public DateOnly? DateOfBirth
    {
        get => _dateOfBirth;
        set
        {
            _dateOfBirth = value;
            NotifyOfPropertyChange(() => DateOfBirth);
        }
    }

    private string _education = string.Empty;
    public string Education
    {
        get => _education;
        set
        {
            _education = value;
            NotifyOfPropertyChange(() => Education);
        }
    }

    private string _specializationsLabel = string.Empty;
    public string SpecializationsLabel
    {
        get => _specializationsLabel;
        set
        {
            _specializationsLabel = value;
            NotifyOfPropertyChange(() => SpecializationsLabel);
        }
    }

    private string _specializations = string.Empty;
    public string Specializations
    {
        get => _specializations;
        set
        {
            _specializations = value;
            NotifyOfPropertyChange(() => Specializations);
        }
    }

    //TODO: Find a way to collapse this column when it is not needed; Current solution does not work
    private int _specializationsRowHeight = 25;
    public int SpecializationsRowHeight
    {
        get => _specializationsRowHeight;
        set
        {
            _specializationsRowHeight = value;
            NotifyOfPropertyChange(() => SpecializationsRowHeight);
        }
    }

    public DateOnly? _employedSince = DateOnly.MinValue;
    public DateOnly? EmployedSince
    {
        get => _employedSince;
        set
        {
            _employedSince = value;
            NotifyOfPropertyChange(() => EmployedSince);
        }
    }

    public string _currentSalary = string.Empty;
    public string CurrentSalary
    {
        get => _currentSalary;
        set
        {
            _currentSalary = value;
            NotifyOfPropertyChange(() => CurrentSalary);
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

    protected override Task OnInitializeAsync(CancellationToken cancellationToken)
    {
        InitializeCommonFields();
        InitializeRoleFields();

        return base.OnInitializeAsync(cancellationToken);
    }

    private void InitializeCommonFields()
    {
        Username = UserContext.CurrentUser?.Username ?? DisplayMessages.NoData;
        UserRole = UserContext.CurrentUser?.UserRole.ToString() ?? DisplayMessages.NoData;
        PasswordLastUpdated = UserContext.CurrentUser?.PasswordLastUpdated ?? default;
        FirstName = UserContext.CurrentUser?.Employee?.FirstName ?? DisplayMessages.NoData;
        LastName = UserContext.CurrentUser?.Employee?.LastName ?? DisplayMessages.NoData;
        Gender = UserContext.CurrentUser?.Employee?.Gender.ToString() ?? DisplayMessages.NoData;
        DateOfBirth = DateOnly.FromDateTime(UserContext.CurrentUser?.Employee?.DateOfBirth ?? default);
        Education = UserContext.CurrentUser?.Employee?.Education ?? DisplayMessages.NoData;
        EmployedSince = DateOnly.FromDateTime(UserContext.CurrentUser?.Employee?.EmployedSince ?? default);
        CurrentSalary = UserContext.CurrentUser?.Employee?.CurrentSalary.ToString() ?? DisplayMessages.NoData;
        Country = UserContext.CurrentUser?.Employee?.Address.Country ?? DisplayMessages.NoData;
        City = UserContext.CurrentUser?.Employee?.Address.City ?? DisplayMessages.NoData;
        Street = UserContext.CurrentUser?.Employee?.Address.Street ?? DisplayMessages.NoData;
        Number = UserContext.CurrentUser?.Employee?.Address.Number.ToString() ?? DisplayMessages.NoData;
        Email = UserContext.CurrentUser?.Employee?.ContactInfo.Email ?? DisplayMessages.NoData;
        TelephoneNumber = UserContext.CurrentUser?.Employee?.ContactInfo.TelephoneNumber ?? DisplayMessages.NoData;
    }

    private void InitializeRoleFields()
    {
        if (UserContext.CurrentUser?.UserRole == Domain.Models.Enums.UserRole.Doctor)
        {
            var doctor = (Doctor?)UserContext.CurrentUser?.Employee ?? null;
            string specializationsStr = "";

            if (doctor is not null)
            {
                doctor.Specializations.ToList()
                    .ForEach(specialization => specializationsStr += $"{specialization.Name}, ");

                SpecializationsLabel = "Specializations:";
                Specializations = specializationsStr.Trim()[..^1];
            }
        }
        else
            SpecializationsRowHeight = 0;
    }
}