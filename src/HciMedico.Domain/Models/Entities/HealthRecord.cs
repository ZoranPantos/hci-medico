using HciMedico.Domain.Models.Enums;
using HciMedico.Domain.Models.Relationships;

namespace HciMedico.Domain.Models.Entities;

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
    public ICollection<MedicalReport> MedicalReports { get; set; }
}
