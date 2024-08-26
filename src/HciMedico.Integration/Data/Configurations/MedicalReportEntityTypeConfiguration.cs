using HciMedico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

public class MedicalReportEntityTypeConfiguration : IEntityTypeConfiguration<MedicalReport>
{
    public void Configure(EntityTypeBuilder<MedicalReport> builder)
    {
        builder
            .HasMany(r => r.MedicalConditions)
            .WithMany(mc => mc.MedicalReports)
            .UsingEntity(j =>
                {
                    j.ToTable("report_medicalcondition");
                    j.HasData(
                        new { MedicalReportsId = 1, MedicalConditionsId = 1 }
                    );
                }
            );

        builder.HasData(
            new MedicalReport
            {
                Id = 1,
                DateTime = new(2024, 1, 5, 8, 0, 0),
                Analysis = "Patient presents with heel pain, particularly upon first steps in the morning. Pain is localized to the medial aspect of the heel.",
                PreviousFindings = "No significant previous findings. Patient reports occasional mild discomfort after long periods of standing.",
                Therapy = "Recommend rest, ice application, stretching exercises, and over-the-counter NSAIDs. Consider custom orthotics if pain persists.",
                AdditionalNotes = "Follow-up in 4 weeks to assess response to therapy. Patient advised to avoid high-impact activities and wear supportive shoes.",
                AppointmentId = 1,
                HealthRecordId = 1
            }
        );
    }
}
