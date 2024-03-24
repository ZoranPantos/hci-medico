using Caliburn.Micro;

namespace HciMedico.App.ViewModels;

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

    public string _lastName = string.Empty;
    public string LastName
    {
        get => _lastName;
        set
        {
            _lastName = value;
            NotifyOfPropertyChange(() => LastName);
        }
    }

    protected override Task OnInitializeAsync(CancellationToken cancellationToken)
    {
        Username = UserContext.CurrentUser?.Username ?? "No data available";
        FirstName = UserContext.CurrentUser?.Employee?.FirstName ?? "No data available";
        LastName = UserContext.CurrentUser?.Employee?.LastName ?? "No data available";

        return base.OnInitializeAsync(cancellationToken);
    }
}
