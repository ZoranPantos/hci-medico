namespace HciMedico.Domain.Models.Entities;

public class CounterWorker : Employee
{
    public ICollection<Appointment> CreatedAppointments { get; set; }
}
