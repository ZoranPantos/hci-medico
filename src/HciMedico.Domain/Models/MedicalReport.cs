namespace HciMedico.Domain.Models;

public class MedicalReport
{
    public int Id { get; set; }

    public DateTime DateTime { get; set; }

    public string Analysis { get; set; } = string.Empty;
    public string PreviousFindings { get; set; } = string.Empty;

    //TODO: Consider removing this and having it only in input/output models as it is empty in DB and FK towards medical condition is stored anyway
    public string Diagnosis { get; set; } = string.Empty;

    public string Therapy { get; set; } = string.Empty;
    public string AdditionalNotes { get; set; } = string.Empty;

    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    public int HealthRecordId { get; set; }
    public HealthRecord HealthRecord { get; set; }

    public ICollection<MedicalCondition> MedicalConditions { get; set; }
}
