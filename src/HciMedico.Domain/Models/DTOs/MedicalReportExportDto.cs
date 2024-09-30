namespace HciMedico.Domain.Models.DTOs;

public class MedicalReportExportDto
{
    public DateTime DateTime { get; set; }
    public string Analysis { get; set; } = string.Empty;
    public string PreviousFindings { get; set; } = string.Empty;
    public string Diagnosis { get; set; } = string.Empty;
    public string Therapy { get; set; } = string.Empty;
    public string AdditionalNotes { get; set; } = string.Empty;
    public string PatientFullName { get; set; } = string.Empty;
    public string PatientUid { get; set; } = string.Empty;
    public string DoctorFullName { get; set; } = string.Empty;
}
