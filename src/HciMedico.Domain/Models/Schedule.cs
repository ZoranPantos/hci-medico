namespace HciMedico.Domain.Models;

public class Schedule
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public ICollection<ScheduleCell> ScheduleCells { get; set; }
}
