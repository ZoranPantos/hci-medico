using HciMedico.Domain.Models.Enums;

namespace HciMedico.Domain.Models.DisplayModels;

public sealed class AppointmentDisplayModel
{
    public int Id { get; set; }
    public string PatientFullNameOrIdentifier { get; set; } = string.Empty;
    public string DoctorFullName { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public TimeOnly Time { get; set; }
    public string FormattedTime => Time.ToString("HH:mm");
    public bool IsPatientRegistered { get; set; }
}
