namespace HciMedico.Library.Models;

public class Patient
{
    public int Id { get; set; }

    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Uid { get; set; } = string.Empty;
    
    public Address Address { get; set; } = new();
    public ContactInfo Contact { get; set; } = new();

    public HealthRecord HealthRecord { get; set; } = new();
    public ICollection<Appointment> Appointments { get; set; }
}
