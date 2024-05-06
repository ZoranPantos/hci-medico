namespace HciMedico.Domain.Models;

public class ScheduleCell
{
    public int Id { get; set; }

    public int ScheduleId { get; set; }
    public Schedule Schedule { get; set; }

    public DateTime DateTime { get; set; }

    public string ShiftStartTime { get; set; } = string.Empty;
    public string ShiftEndTime { get; set; } = string.Empty;
}
