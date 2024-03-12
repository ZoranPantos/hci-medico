using HciMedico.Library.Models.Enums;
using HciMedico.Library.Models.Relationships;

namespace HciMedico.Library.Models;

public class HealthRecord
{
    public int Id { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public BloodGroup BloodGroup { get; set; }

    public ICollection<HealthRecordMedicalCondition> HealthRecordMedicalConditions { get; set; }
    public ICollection<Appointment> Appointments { get; set; }
}
