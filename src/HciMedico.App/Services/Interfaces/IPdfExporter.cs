using HciMedico.Domain.Models.DTOs;

namespace HciMedico.App.Services.Interfaces;

public interface IPdfExporter
{
    void Export(MedicalReportExportDto dto);
}
