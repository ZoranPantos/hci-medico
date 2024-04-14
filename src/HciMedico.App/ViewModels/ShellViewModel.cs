using Caliburn.Micro;
using HciMedico.App.Views;
using HciMedico.Library.Data.Repositories;
using HciMedico.Library.Models;
using System.ComponentModel;
using System.Windows;

namespace HciMedico.App.ViewModels;

public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
{ 
    private bool _logoutTriggered;

    private IScreen? _currentViewModel;
    public IScreen? CurrentViewModel
    {
        get => _currentViewModel;
        set
        {
            _currentViewModel = value;

            if (_currentViewModel is not null)
                ActivateItemAsync(_currentViewModel);
            else
                throw new ArgumentNullException("ViewModel was null");
        }
    }

    // Called when the View is ready
    protected override Task OnActivateAsync(CancellationToken cancellationToken)
    {
        ((ShellView)GetView()).Closing += ShellView_OnClosing;

        return base.OnActivateAsync(cancellationToken);
    }

    private void ShellView_OnClosing(object? sender, CancelEventArgs e)
    {
        if (sender is ShellView && !_logoutTriggered)
            Application.Current.Shutdown();
    }

    public void NavigateToMyAccount() => CurrentViewModel = IoC.Get<AccountViewModel>();

    public void NavigateToSettings() => CurrentViewModel = IoC.Get<SettingsViewModel>();

    public async Task Logout()
    {
        _logoutTriggered = true;
        UserContext.Clean();

        // Close current window
        await TryCloseAsync();

        // Open Login window again
        var windowManager = IoC.Get<IWindowManager>();
        var repository = IoC.Get<IRepository<UserAccount>>();

        await windowManager.ShowWindowAsync(new LoginViewModel(windowManager, repository));
    }
}
