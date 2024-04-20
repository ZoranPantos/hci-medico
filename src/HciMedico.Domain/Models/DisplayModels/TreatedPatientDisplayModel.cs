namespace HciMedico.Domain.Models.DisplayModels;

public sealed class TreatedPatientDisplayModel
{
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
    public int NumberOfVisits { get; set; }
}
