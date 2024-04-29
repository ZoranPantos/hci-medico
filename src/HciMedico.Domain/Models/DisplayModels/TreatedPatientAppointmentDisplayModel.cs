namespace HciMedico.Domain.Models.DisplayModels;

public sealed class TreatedPatientAppointmentDisplayModel
{
    public DateTime DateAndTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
}
