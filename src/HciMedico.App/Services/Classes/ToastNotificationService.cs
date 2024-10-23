using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;
using ToastNotifications.Messages;
using ToastNotifications.Core;
using System.Windows;
using HciMedico.App.Services.Interfaces;

namespace HciMedico.App.Services.Classes;

public class ToastNotificationService : IToastNotificationService
{
    private readonly Notifier _notifier;
    private readonly MessageOptions _messageOptions;

    private const int NotificationLifetimeSeconds = 3;
    private const int MaxNotificationCount = 5;
    private const int OffsetX = 10;
    private const int OffsetY = 10;

    public ToastNotificationService()
    {
        _notifier = new(config =>
        {
            config.PositionProvider = new WindowPositionProvider(
                Application.Current.MainWindow,
                Corner.BottomRight,
                OffsetX,
                OffsetY);

            config.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                TimeSpan.FromSeconds(NotificationLifetimeSeconds),
                MaximumNotificationCount.FromCount(MaxNotificationCount));

            config.DisplayOptions.TopMost = true;
            config.DisplayOptions.Width = 200;

            config.Dispatcher = Application.Current.Dispatcher;
        });

        _messageOptions = new()
        {
            FontSize = 15,
            ShowCloseButton = true,
            FreezeOnMouseEnter = true,
        };
    }

    public void ShowSuccess(string message = "Action completed") => _notifier.ShowSuccess(message, _messageOptions);

    public void ShowError(string message = "Action failed") => _notifier.ShowError(message, _messageOptions);

    public void ShowInformation(string message) => _notifier.ShowInformation(message, _messageOptions);

    public void ShowWarning(string message) => _notifier.ShowWarning(message, _messageOptions);
}
