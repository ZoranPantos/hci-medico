namespace HciMedico.Domain.Models.DisplayModels;

public sealed class TreatedPatientDisplayModel
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
    public int NumberOfVisits { get; set; }
}
