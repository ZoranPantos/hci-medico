using Caliburn.Micro;
using HciMedico.App.ViewModels.Exceptions;
using System.Windows;
using System.Windows.Threading;

namespace HciMedico.App;

public partial class App : Application
{
    private async void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        string exceptionMessage = e.Exception.Message;

        string innerExceptionMessage =
            e.Exception.InnerException is not null ? e.Exception.InnerException.Message : "Inner exception was null";

        string displayMessage = $"{exceptionMessage}{Environment.NewLine}{innerExceptionMessage}";

        var windowManager = IoC.Get<IWindowManager>();

        var viewModel = new GlobalExceptionViewModel { Message = displayMessage };

        await windowManager.ShowWindowAsync(viewModel);

        e.Handled = true;
    }
}
