namespace HciMedico.Library.Models.DTOs;

public sealed class TreatedPatientDisplayModel
{
    public string FullName { get; set; } = string.Empty;
    public DateTime DateOfBirth { get; set; } = DateTime.MinValue;
    public int NumberOfVisits { get; set; }
}
