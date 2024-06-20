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
using HciMedico.App.Services;

namespace HciMedico.App.ViewModels.Shared;

public class ShellViewModel : Conductor<object>
{
    private bool _logoutTriggered;
    private LandingPage _page;

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

    public ShellViewModel(LandingPage page) => _page = page;

    // Called when the View is ready (after constructor)
    protected override Task OnActivateAsync(CancellationToken cancellationToken)
    {
        ((ShellView)GetView()).Closing += ShellView_OnClosing;

        switch (_page)
        {
            case LandingPage.Appointments:
                NavigateToAppointments();
                break;
            case LandingPage.Patients:
                NavigateToPatients();
                break;
            case LandingPage.HealthRecords:
                NavigateToHealthRecords();
                break;
            case LandingPage.WorkSchedule:
                NavigateToWorkSchedule();
                break;
            case LandingPage.AccountInfo:
                NavigateToMyAccount();
                break;
        }

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
            UserRole.Doctor => new TreatedPatientsViewModel(IoC.Get<IRepository<Patient>>(), IoC.Get<IMapper>(), this, IoC.Get<ISearchService>()),

            //For enabling deeper levels of navigation, I need to send this (parent view model) to "sub-model" and navigate from there
            //via the parent model
            UserRole.CounterWorker => new PatientsViewModel(
                IoC.Get<IRepository<Patient>>(),
                IoC.Get<IMapper>(),
                this,
                IoC.Get<IWindowManager>(),
                IoC.Get<ISearchService>()),

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

            UserRole.CounterWorker => new AppointmentsCounterWorkerViewModel(
                IoC.Get<IRepository<Appointment>>(),
                IoC.Get<IMapper>(),
                this,
                IoC.Get<IWindowManager>(),
                IoC.Get<ISearchService>()),

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

    public void NavigateToWorkSchedule() => CurrentViewModelInShell = new WorkScheduleViewModel();

    public async Task Logout()
    {
        _logoutTriggered = true;
        UserContext.Clean();

        await TryCloseAsync();

        var windowManager = IoC.Get<IWindowManager>();
        var userAccountRepository = IoC.Get<IRepository<UserAccount>>();

        await windowManager.ShowWindowAsync(new LoginViewModel(windowManager, userAccountRepository, IoC.Get<IHashingService>()));
    }
}
