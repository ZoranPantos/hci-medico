namespace HciMedico.Library.Models;

public class Doctor : Employee
{
    public ICollection<MedicalSpecialization> Specializations { get; set; }
    public ICollection<Appointment> AssignedOrders { get; set; }
}
