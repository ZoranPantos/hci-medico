namespace HciMedico.App.Services.Interfaces;

public interface IAppointmentAutoCancellerService
{
    Task Start(CancellationToken cancellationToken);
}
