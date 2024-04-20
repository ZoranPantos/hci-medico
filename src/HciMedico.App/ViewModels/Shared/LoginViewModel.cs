using Caliburn.Micro;
using HciMedico.App.Services;
using HciMedico.App.Views;
using HciMedico.App.Views.Shared;
using HciMedico.Library.Data.Repositories;
using HciMedico.Library.Models;
using System.ComponentModel;
using System.Windows;

namespace HciMedico.App.ViewModels.Shared;

public class LoginViewModel : Conductor<object>
{
    // If the user quits the login window in which scenario the app should shut down directly
    private bool _loginViewQuit = true;
    private readonly IWindowManager _windowManager;
    private readonly IRepository<UserAccount> _userAccountRepository;

    public LoginViewModel(IWindowManager windowManager, IRepository<UserAccount> userAccountRepository)
    {
        _windowManager = windowManager;
        _userAccountRepository = userAccountRepository;
    }

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

    private string _password = string.Empty;
    public string Password
    {
        get => _password;
        set
        {
            _password = value;
            NotifyOfPropertyChange(() => Password);
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

    public bool CanLogin(string username, string password) => username.Length > 0 && password.Length > 0;

    public async Task Login(string username, string password)
    {
        //TODO: Remove this after testing
        username = "marko.petrovic1";
        //username = "ana.jovanovic34";
        password = "marko.petrovic1";

        string passwordHash = HashingService.GetHashString(password);

        var existingUser = await _userAccountRepository
            .FindAsync(user => user.Username.Equals(username), true, "Employee.Specializations,Employee.AssignedAppointments");

        if (existingUser is null || !passwordHash.Equals(existingUser.Password))
        {
            ValidationMessage = "User with specified credentials could not be found";
            return;
        }

        UserContext.Initialize(existingUser);

        _loginViewQuit = false;

        await TryCloseAsync();

        await _windowManager.ShowWindowAsync(new ShellViewModel());
    }

    protected override Task OnActivateAsync(CancellationToken cancellationToken)
    {
        ((LoginView)GetView()).Closing += LoginView_OnClosing;

        return base.OnActivateAsync(cancellationToken);
    }

    private void LoginView_OnClosing(object? sender, CancelEventArgs e)
    {
        if (sender is LoginView && _loginViewQuit)
            Application.Current.Shutdown();
    }
}
