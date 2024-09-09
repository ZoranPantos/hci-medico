namespace HciMedico.Domain.Models.DisplayModels;

public class HealthRecordDisplayModel
{
    public int Id { get; set; }
    public string PatientFullName { get; set; } = string.Empty;
    public string PatientUid { get; set; } = string.Empty;
}
