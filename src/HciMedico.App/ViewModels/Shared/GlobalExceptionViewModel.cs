using Caliburn.Micro;

namespace HciMedico.App.ViewModels.Shared;

public class GlobalExceptionViewModel : Conductor<object>
{
    public string Message { get; set; } = string.Empty;

    public async Task CloseWindow() => await TryCloseAsync();
}
