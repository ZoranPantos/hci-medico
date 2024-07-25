namespace HciMedico.App.Services;

public interface IAppointmentAutoCancellerService
{
    Task Start(CancellationToken cancellationToken);
}
