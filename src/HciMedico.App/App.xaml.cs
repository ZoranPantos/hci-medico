using Caliburn.Micro;
using HciMedico.App.ViewModels.Shared;
using System.Windows;
using System.Windows.Threading;

namespace HciMedico.App;

public partial class App : Application
{
    //TODO: add logging
    private async void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        var originalException = e.Exception.InnerException;
        var originalInnerException = e.Exception.InnerException?.InnerException;

        string firstInnerMessage = originalException is not null ? $"Location: {originalException.Message}" : string.Empty;
        string secondInnerMessage = originalInnerException is not null ? $"Error: {originalInnerException.Message}" : string.Empty;

        string currentDateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        string composedExceptionMessage = $"{firstInnerMessage}{Environment.NewLine}{secondInnerMessage}";
        string logMessage = $"Log time: {currentDateTime}{Environment.NewLine}{composedExceptionMessage}";

        var windowManager = IoC.Get<IWindowManager>();

        await windowManager.ShowWindowAsync(new ErrorDisplayViewModel());

        e.Handled = true;
    }
}
