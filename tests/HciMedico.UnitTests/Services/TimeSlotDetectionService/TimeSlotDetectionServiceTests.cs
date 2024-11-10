using HciMedico.Domain.Models.Entities;
using HciMedico.Domain.Models.Enums;
using Moq;
using System.Linq.Expressions;

namespace HciMedico.UnitTests.Services.TimeSlotDetectionService;

public class TimeSlotDetectionServiceTests : IClassFixture<TimeSlotDetectionServiceFixture>
{
    private readonly TimeSlotDetectionServiceFixture _fixture;
    private readonly Doctor _doctor = new() { Id = 1 };
    private readonly DateTime _appointmentDateTime = new(2024, 1, 1);

    public TimeSlotDetectionServiceTests(TimeSlotDetectionServiceFixture fixture) => _fixture = fixture;

    [Fact]
    public async Task TimeSlotDetectionService_ReturnsOneTimeSlot()
    {
        var expectedAppointments = new List<Appointment>();

        var time = _fixture.TimeSlotDetectionService.StartShift.AddMinutes(
            _fixture.TimeSlotDetectionService.DefaultAppointmentDuration.TotalMinutes +
            _fixture.TimeSlotDetectionService.InBetweenAppointmentsBreak.TotalMinutes);

        int idCounter = 1;

        while (time < _fixture.TimeSlotDetectionService.EndShift)
        {
            var appointment = new Appointment
            {
                Id = idCounter++,
                DoctorId = _doctor.Id,
                Status = AppointmentStatus.Scheduled,
                DateAndTime = _appointmentDateTime.Add(time.ToTimeSpan())
            };

            expectedAppointments.Add(appointment);

            time = time.AddMinutes(
                _fixture.TimeSlotDetectionService.DefaultAppointmentDuration.TotalMinutes +
                _fixture.TimeSlotDetectionService.InBetweenAppointmentsBreak.TotalMinutes);

        }

        _fixture.AppointmentsRepositoryMock
            .Setup(x => x.GetAllAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<List<Appointment>>(expectedAppointments));

        var actual = await _fixture.TimeSlotDetectionService.GetTimeSlotsByDate(_appointmentDateTime, _doctor);

        Assert.Single(actual);
    }

    [Fact]
    public async Task TimeSlotDetectionService_DoesNotReturnTimeSlots()
    {
        var expectedAppointments = new List<Appointment>();
        var time = _fixture.TimeSlotDetectionService.StartShift;
        int idCounter = 1;

        while (time < _fixture.TimeSlotDetectionService.EndShift)
        {
            var appointment = new Appointment
            {
                Id = idCounter++,
                DoctorId = _doctor.Id,
                Status = AppointmentStatus.Scheduled,
                DateAndTime = _appointmentDateTime.Add(time.ToTimeSpan())
            };

            expectedAppointments.Add(appointment);

            time = time.AddMinutes(
                _fixture.TimeSlotDetectionService.DefaultAppointmentDuration.TotalMinutes +
                _fixture.TimeSlotDetectionService.InBetweenAppointmentsBreak.TotalMinutes);

        }

        _fixture.AppointmentsRepositoryMock
            .Setup(x => x.GetAllAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<List<Appointment>>(expectedAppointments));

        var actual = await _fixture.TimeSlotDetectionService.GetTimeSlotsByDate(_appointmentDateTime, _doctor);

        Assert.Empty(actual);
    }
}
