using HciMedico.Library.Models.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Library.Data.Configurations;

public class HealthRecordMedicalConditionEntityTypeConfiguration : IEntityTypeConfiguration<HealthRecordMedicalCondition>
{
    public void Configure(EntityTypeBuilder<HealthRecordMedicalCondition> builder)
    {
        builder.ToTable("healthrecord_medicalcondition");

        builder.HasKey(hm => new { hm.HealthRecordId, hm.MedicalConditionId });

        builder
            .HasOne(hm => hm.HealthRecord)
            .WithMany(hr => hr.HealthRecordMedicalConditions)
            .HasForeignKey(hm => hm.HealthRecordId);

        builder
            .HasOne(hm => hm.MedicalCondition)
            .WithMany(mc => mc.HealthRecordMedicalConditions)
            .HasForeignKey(hm => hm.MedicalConditionId);
    }
}
