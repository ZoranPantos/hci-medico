using HciMedico.Domain.Models.Entities;

namespace HciMedico.App.Services.Classes;

public interface ITimeSlotDetectionService
{
    Task<ICollection<TimeOnly>> GetTimeSlotsByDate(DateTime appointmentDateTime, Doctor? assignedTo);
    TimeSpan GetDefaultAppointmentDuration();
    TimeSpan GetInBetweenAppointmentsBreak();
    TimeOnly GetStartShift();
    TimeOnly GetEndShift();
}