using HciMedico.Domain.Models.Entities;
using HciMedico.Integration.Data.Repositories;
using Moq;

namespace HciMedico.UnitTests.Services.TimeSlotDetectionService;

public class TimeSlotDetectionServiceFixture
{
    private readonly Mock<IRepository<Appointment>> _appointmentsRepositoryMock = new();

    public App.Services.Classes.TimeSlotDetectionService TimeSlotDetectionService { get; private set; }
    public Mock<IRepository<Appointment>> AppointmentsRepositoryMock => _appointmentsRepositoryMock;

    public TimeSlotDetectionServiceFixture() => TimeSlotDetectionService = new(_appointmentsRepositoryMock.Object);
}
