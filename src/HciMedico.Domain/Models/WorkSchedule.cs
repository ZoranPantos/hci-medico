﻿namespace HciMedico.Domain.Models;

public class WorkSchedule
{
    public int Id { get; set; }

    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }

    public ICollection<WorkShift> WorkShifts { get; set; }
}