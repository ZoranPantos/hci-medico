using Caliburn.Micro;
using HciMedico.App.ViewModels.CounterWorkerRole;
using HciMedico.Domain.Models.Entities;
using HciMedico.Integration.Data.Repositories;
using Moq;
using System.Linq.Expressions;

namespace HciMedico.UnitTests.ViewModels.CounterWorkerRole;

public class AppointmentDetailsViewModelTests
{
    private AppointmentDetailsViewModel _viewModel;
    private Mock<AppointmentsCounterWorkerViewModel> _parentViewModelMock = new();
    private Mock<IRepository<Appointment>> _appointmentsRepositoryMock = new();
    private Mock<IWindowManager> _windowManagerMock = new();
    private int _appointmentId = 1;
    private Appointment _resolvedAppointment;
    private Appointment _cancelledAppointment;
    private Appointment _scheduledAppointment;

    public AppointmentDetailsViewModelTests()
    {
        _viewModel = new(_appointmentId, _parentViewModelMock.Object, _appointmentsRepositoryMock.Object, _windowManagerMock.Object);

        _resolvedAppointment = new()
        {
            Status = Domain.Models.Enums.AppointmentStatus.Resolved,
            AssignedTo = new() { FirstName = "TestFirstName", LastName = "TestLastName" },
            CreatedBy = new() { FirstName = "TestFirstName", LastName = "TestLastName" }
        };

        _cancelledAppointment = new()
        {
            Status = Domain.Models.Enums.AppointmentStatus.Cancelled,
            AssignedTo = new() { FirstName = "TestFirstName", LastName = "TestLastName" },
            CreatedBy = new() { FirstName = "TestFirstName", LastName = "TestLastName" }
        };

        _scheduledAppointment = new()
        {
            Status = Domain.Models.Enums.AppointmentStatus.Scheduled,
            AssignedTo = new() { FirstName = "TestFirstName", LastName = "TestLastName" },
            CreatedBy = new() { FirstName = "TestFirstName", LastName = "TestLastName" }
        };
    }

    [Fact]
    public async Task Appointment_ShouldNotBeReschedulable_ForResolvedStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_resolvedAppointment));

        await _viewModel.RefreshViewModel();

        Assert.False(_viewModel.CanRescheduleAppointment);
    }

    [Fact]
    public async Task AppointmentDoctor_ShouldNotBeSwitchable_ForResolvedStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_resolvedAppointment));

        await _viewModel.RefreshViewModel();

        Assert.False(_viewModel.CanSwitchDoctor);
    }

    [Fact]
    public async Task AppointmentStatus_ShouldNotBeUpdatable_ForResolvedStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_resolvedAppointment));

        await _viewModel.RefreshViewModel();

        Assert.False(_viewModel.CanUpdateStatus);
    }

    [Fact]
    public async Task Appointment_ShouldBeReschedulable_ForResolvedScheduledStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_scheduledAppointment));

        await _viewModel.RefreshViewModel();

        Assert.True(_viewModel.CanRescheduleAppointment);
    }

    [Fact]
    public async Task AppointmentDoctor_ShouldBeSwitchable_ForScheduledStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_scheduledAppointment));

        await _viewModel.RefreshViewModel();

        Assert.True(_viewModel.CanSwitchDoctor);
    }

    [Fact]
    public async Task AppointmentStatus_ShouldBeUpdatable_ForScheduledStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_scheduledAppointment));

        await _viewModel.RefreshViewModel();

        Assert.True(_viewModel.CanUpdateStatus);
    }

    [Fact]
    public async Task Appointment_ShouldNotBeReschedulable_ForCancelledStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_cancelledAppointment));

        await _viewModel.RefreshViewModel();

        Assert.False(_viewModel.CanRescheduleAppointment);
    }

    [Fact]
    public async Task AppointmentDoctor_ShouldNotBeSwitchable_ForCancelledStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_cancelledAppointment));

        await _viewModel.RefreshViewModel();

        Assert.False(_viewModel.CanSwitchDoctor);
    }

    [Fact]
    public async Task AppointmentStatus_ShouldBeUpdatable_ForCancelledStatus()
    {
        _appointmentsRepositoryMock
            .Setup(x => x.FindAsync(It.IsAny<Expression<Func<Appointment, bool>>>(), It.IsAny<bool>(), It.IsAny<string>()))
            .Returns(Task.FromResult<Appointment?>(_cancelledAppointment));

        await _viewModel.RefreshViewModel();

        Assert.True(_viewModel.CanUpdateStatus);
    }
}