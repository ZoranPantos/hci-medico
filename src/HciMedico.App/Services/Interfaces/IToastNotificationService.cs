namespace HciMedico.App.Services.Interfaces;

public interface IToastNotificationService
{
    void ShowError(string message = "Action failed");
    void ShowInformation(string message);
    void ShowSuccess(string message = "Action completed");
    void ShowWarning(string message);
    void ClearAll();
    void Dispose();
    void ReinitializeNotifier();
}