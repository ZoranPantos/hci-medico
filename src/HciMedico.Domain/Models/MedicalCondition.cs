using HciMedico.Domain.Models.Relationships;

namespace HciMedico.Domain.Models;

public class MedicalCondition
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<HealthRecordMedicalCondition> HealthRecordMedicalConditions { get; set; }
}
