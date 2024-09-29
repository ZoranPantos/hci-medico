namespace HciMedico.Domain.Models.Entities;

public class WorkShift
{
    public int Id { get; set; }

    public int WorkScheduleId { get; set; }
    public WorkSchedule WorkSchedule { get; set; }

    public DateTime DateTime { get; set; }

    public string ShiftStartTime { get; set; } = string.Empty;
    public string ShiftEndTime { get; set; } = string.Empty;
}
