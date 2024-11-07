namespace HciMedico.Domain.Models.Entities;

public class MedicalReport
{
    public int Id { get; set; }

    public DateTime DateTime { get; set; }

    public string Analysis { get; set; } = string.Empty;
    public string PreviousFindings { get; set; } = string.Empty;

    public string Therapy { get; set; } = string.Empty;
    public string AdditionalNotes { get; set; } = string.Empty;

    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    public int HealthRecordId { get; set; }
    public HealthRecord HealthRecord { get; set; }

    public ICollection<MedicalCondition> MedicalConditions { get; set; }
}
