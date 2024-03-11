namespace HciMedico.Library.Models;

public class MedicalSpecialization
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Doctor> Doctors { get; set; }
}
