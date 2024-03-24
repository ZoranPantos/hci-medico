using Caliburn.Micro;
using HciMedico.App.Views;
using System.ComponentModel;
using System.Windows;

namespace HciMedico.App.ViewModels;

public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
{
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

    // This method gets automatically called when the View is ready
    protected override Task OnActivateAsync(CancellationToken cancellationToken)
    {
        ((ShellView)GetView()).Closing += ShellView_OnClosing;

        return base.OnActivateAsync(cancellationToken);
    }

    // Subscribe this method to the Closing event of the ShellView so that we can
    // properly shut down the application
    private void ShellView_OnClosing(object? sender, CancelEventArgs e)
    {
        //if (Application.Current.Windows.Count == 1)

        if (sender is ShellView)
            Application.Current.Shutdown();
    }

    public void NavigateToMyAccount() => CurrentViewModel = IoC.Get<AccountViewModel>();

    public void NavigateToSettings() => CurrentViewModel = IoC.Get<SettingsViewModel>();
}
