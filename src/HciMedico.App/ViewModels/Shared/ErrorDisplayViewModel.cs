using Caliburn.Micro;

namespace HciMedico.App.ViewModels.Shared;

public class ErrorDisplayViewModel : Conductor<object>
{
    public string HeadingMessage { get; set; } = "Oops! Something went wrong!";
    public string ContentMessage { get; set; } = "Action could not be performed. More details are available in developer logs.";

    public async Task CloseWindow() => await TryCloseAsync();
}
