using HciMedico.Library.Models.Enums;

namespace HciMedico.Library.Models.Relationships;

public class HealthRecordMedicalCondition
{
    public MedicalConditionStatus Status { get; set; }

    public int MedicalConditionId { get; set; }
    public MedicalCondition MedicalCondition { get; set; }

    public int HealthRecordId { get; set; }
    public HealthRecord HealthRecord { get; set; }
}
