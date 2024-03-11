namespace HciMedico.Library.Models;

public class CounterWorker : Employee
{
    public ICollection<Appointment> CreatedOrders { get; set; }
}
