using Caliburn.Micro;
using HciMedico.App.Views.Shared;
using System.ComponentModel;
using System.Windows;
using HciMedico.App.ViewModels.DoctorRole;
using HciMedico.Domain.Models.Enums;
using HciMedico.Integration.Data.Repositories;
using HciMedico.Domain.Models;
using AutoMapper;
using HciMedico.App.ViewModels.CounterWorkerRole;

namespace HciMedico.App.ViewModels.Shared;

public class ShellViewModel : Conductor<object>
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

        CurrentViewModelInShell = UserContext.CurrentUser.UserRole switch
        {
            UserRole.Doctor => new TreatedPatientsViewModel(IoC.Get<IRepository<Patient>>(), IoC.Get<IMapper>(), this),
            //CurrentViewModelInShell = IoC.Get<TreatedPatientsViewModel>();
            //For enabling deeper levels of navigation, I need to send this (parent view model) to "sub-model" and navigate from there
            //via the parent model
            UserRole.CounterWorker => new PatientsViewModel(IoC.Get<IRepository<Patient>>(), IoC.Get<IMapper>(), this),
            _ => throw new Exception("User role is not recognized"),
        };
    }

    public void NavigateToAppointments()
    {
        if (UserContext.CurrentUser is null)
            throw new Exception("Current user is null");

        CurrentViewModelInShell = UserContext.CurrentUser.UserRole switch
        {
            UserRole.Doctor => new AppointmentsDoctorViewModel(),
            UserRole.CounterWorker => new AppointmentsCounterWorkerViewModel(),
            _ => throw new Exception("User role is not recognized"),
        };
    }

    public void NavigateToHealthRecords()
    {
        if (UserContext.CurrentUser is null)
            throw new Exception("Current user is null");

        CurrentViewModelInShell = UserContext.CurrentUser.UserRole switch
        {
            UserRole.Doctor => new HealthRecordsDoctorViewModel(),
            UserRole.CounterWorker => new HealthRecordsCounterWorkerViewModel(),
            _ => throw new Exception("User role is not recognized"),
        };
    }

    public async Task NavigateToWorkSchedule() => await ActivateItemAsync(new WorkScheduleViewModel());

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
