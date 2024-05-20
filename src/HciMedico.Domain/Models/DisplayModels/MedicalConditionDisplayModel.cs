using HciMedico.Domain.Models.Enums;

namespace HciMedico.Domain.Models.DisplayModels;

public sealed class MedicalConditionDisplayModel
{
    public string Name { get; set; } = string.Empty;
    public MedicalConditionStatus Status { get; set; }
}
