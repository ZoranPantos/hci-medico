namespace HciMedico.Domain.Models.Entities;

public class Doctor : Employee
{
    public ICollection<MedicalSpecialization> Specializations { get; set; }
    public ICollection<Appointment> AssignedAppointments { get; set; }
}
