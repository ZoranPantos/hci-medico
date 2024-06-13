namespace HciMedico.Domain.Models;

public class Patient
{
    public int Id { get; set; }

    public string Uid { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;

    public string FullName => $"{FirstName} {LastName}";
    
    public Address Address { get; set; }
    public ContactInfo ContactInfo { get; set; }

    public HealthRecord HealthRecord { get; set; }
    public ICollection<Appointment> Appointments { get; set; }
}
