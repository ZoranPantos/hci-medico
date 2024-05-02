namespace HciMedico.Domain.Models.DisplayModels;

public sealed class PatientDisplayModel
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime LastVisit { get; set; } = DateTime.MinValue;
}
