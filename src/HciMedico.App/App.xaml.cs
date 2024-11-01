using Caliburn.Micro;
using HciMedico.App.ViewModels.Shared;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Events;
using System.Configuration;
using System.Windows;
using System.Windows.Threading;

namespace HciMedico.App;

public partial class App : Application
{
    private readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(builder =>
    {
        var loggerConfiguration = new LoggerConfiguration()
            .WriteTo
            .File
            (
                //File will be in bin/debug
                ConfigurationManager.AppSettings["LogOutputFileRelative"]!,
                LogEventLevel.Error,
                rollingInterval: RollingInterval.Day,
                outputTemplate: "{Timestamp:HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}"
            );

        builder.AddSerilog(loggerConfiguration.CreateLogger());
    });

    private ILogger<App>? _logger;

    private async void Application_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
    {
        var mainException = e.Exception;
        var originalException = e.Exception.InnerException;
        var originalInnerException = e.Exception.InnerException?.InnerException;

        string mainExceptionMessage = mainException.Message;
        string firstInnerMessage = originalException is not null ? $"Location: {originalException.Message}" : string.Empty;
        string secondInnerMessage = originalInnerException is not null ? $"Message: {originalInnerException.Message}" : string.Empty;

        string composedExceptionMessage = $"{mainExceptionMessage}{Environment.NewLine}{firstInnerMessage}{Environment.NewLine}{secondInnerMessage}";
        string logMessage = $"{Environment.NewLine}{composedExceptionMessage}{Environment.NewLine}";

        _logger = _loggerFactory.CreateLogger<App>();
        _logger?.LogError(logMessage);

        var windowManager = IoC.Get<IWindowManager>();

        await windowManager.ShowWindowAsync(new ErrorDisplayViewModel());
        Console.WriteLine(originalException?.Message);
        Console.WriteLine(originalInnerException?.InnerException?.Message);

        e.Handled = true;
    }
}
