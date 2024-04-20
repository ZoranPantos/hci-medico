using Caliburn.Micro;

namespace HciMedico.App.ViewModels.Shared;

public class SettingsViewModel : Conductor<object>
{
    private readonly IWindowManager _windowManager;

    public SettingsViewModel(IWindowManager windowManager) => _windowManager = windowManager;

    public async Task UpdatePassword() => await _windowManager.ShowWindowAsync(new UpdatePasswordViewModel());
}
