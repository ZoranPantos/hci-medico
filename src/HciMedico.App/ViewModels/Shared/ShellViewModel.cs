using Caliburn.Micro;
using HciMedico.App.Views.Shared;
using System.ComponentModel;
using System.Windows;
using HciMedico.App.ViewModels.DoctorRole;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;
using HciMedico.Domain.Models;
using AutoMapper;

namespace HciMedico.App.ViewModels.Shared;

public class ShellViewModel : //Conductor<IScreen>.Collection.OneActive
    Conductor<object>
{
    private bool _logoutTriggered;

    private IScreen? _currentViewModelInShell;
    public IScreen? CurrentViewModelInShell
    {
        get => _currentViewModelInShell;
        set
        {
            _currentViewModelInShell = value;

            if (_currentViewModelInShell is not null)
                ActivateItemAsync(_currentViewModelInShell);
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

    public void NavigateToMyAccount() => CurrentViewModelInShell = IoC.Get<AccountViewModel>();

    public void NavigateToSettings() => CurrentViewModelInShell = IoC.Get<SettingsViewModel>();

    public void NavigateToPatients()
    {
        if (UserContext.CurrentUser is null)
            throw new Exception("Current user is null");

        switch (UserContext.CurrentUser.UserRole)
        {
            case UserRole.Doctor:
                //CurrentViewModelInShell = IoC.Get<TreatedPatientsViewModel>();
                //For enabling deeper levels of navigation, I need to send this (parent view model) to "sub-model" and navigate from there
                //via the parent model
                CurrentViewModelInShell = new TreatedPatientsViewModel(IoC.Get<IRepository<Patient>>(), IoC.Get<IMapper>(), this);
                break;
            case UserRole.CounterWorker:
                break;

            // Add more user roles
            default:
                throw new Exception("User role is not recognized");
        }
    }

    public async Task NavigateToMySchedule() => await ActivateItemAsync(new ScheduleViewModel());

    public async Task Logout()
    {
        _logoutTriggered = true;
        UserContext.Clean();

        await TryCloseAsync();

        var windowManager = IoC.Get<IWindowManager>();
        var userAccountRepository = IoC.Get<IRepository<UserAccount>>();

        await windowManager.ShowWindowAsync(new LoginViewModel(windowManager, userAccountRepository));
    }
}
