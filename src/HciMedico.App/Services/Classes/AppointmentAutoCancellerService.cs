using HciMedico.Domain.Models;
using HciMedico.Integration.Data.Repositories;
using Microsoft.Extensions.Hosting;
using HciMedico.Domain.Models.Enums;
using HciMedico.App.Exceptions;
using HciMedico.App.Services.Interfaces;

namespace HciMedico.App.Services.Classes;

public class AppointmentAutoCancellerService : BackgroundService, IAppointmentAutoCancellerService
{
    private readonly IRepository<Appointment> _appointmentsRepository;

    public AppointmentAutoCancellerService(IRepository<Appointment> appointmentsRepository) =>
        _appointmentsRepository = appointmentsRepository ?? throw new ArgumentNullException(nameof(appointmentsRepository));

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var appointmentsForCancellation = await _appointmentsRepository
                    .GetAllAsync(appointment => appointment.Status == AppointmentStatus.Scheduled && appointment.DateAndTime < DateTime.Now.AddHours(-1));

                if (appointmentsForCancellation?.Count > 0)
                {
                    appointmentsForCancellation.ForEach(appointment => appointment.Status = AppointmentStatus.Cancelled);
                    await _appointmentsRepository.UpdateRange(appointmentsForCancellation);
                }

                await Task.Delay(TimeSpan.FromMinutes(10), stoppingToken);
            }
        }
        catch (Exception ex)
        {
            string message = $"Exception caught and rethrown in {nameof(AppointmentAutoCancellerService)}.{nameof(ExecuteAsync)}";
            throw new MedicoException(message, ex);
        }
    }

    public async Task Start(CancellationToken cancellationToken) => await StartAsync(cancellationToken);
}
