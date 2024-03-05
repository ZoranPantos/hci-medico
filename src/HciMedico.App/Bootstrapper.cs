using Caliburn.Micro;
using HciMedico.App.ViewModels;
using System.Windows;

namespace HciMedico.App;

public class Bootstrapper : BootstrapperBase
{
    public Bootstrapper() => Initialize();

    protected override async void OnStartup(object sender, StartupEventArgs e) =>
        await DisplayRootViewForAsync(typeof(ShellViewModel));
}
