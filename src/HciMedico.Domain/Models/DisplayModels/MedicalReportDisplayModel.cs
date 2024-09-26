namespace HciMedico.Domain.Models.DisplayModels;

public class MedicalReportDisplayModel
{
    public int Id { get; set; }
    public string DoctorFullName { get; set; } = string.Empty;
    public DateTime DateAndTime { get; set; }
}
