namespace HciMedico.Domain.Models;

public class CounterWorker : Employee
{
    public ICollection<Appointment> CreatedAppointments { get; set; }
}
