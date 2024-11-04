using HciMedico.Domain.Models.Enums;
using HciMedico.Domain.Models.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

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

        builder.HasData(
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 1,
                MedicalConditionId = 4,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 2,
                MedicalConditionId = 4,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 3,
                MedicalConditionId = 4,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 4,
                MedicalConditionId = 90,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 5,
                MedicalConditionId = 90,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 6,
                MedicalConditionId = 90,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 7,
                MedicalConditionId = 90,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 8,
                MedicalConditionId = 97,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 9,
                MedicalConditionId = 97,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 10,
                MedicalConditionId = 97,
                Status = MedicalConditionStatus.Past
            }
        );

        builder.HasData(
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 1,
                MedicalConditionId = 24,
                Status = MedicalConditionStatus.Present
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 2,
                MedicalConditionId = 24,
                Status = MedicalConditionStatus.Present
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 3,
                MedicalConditionId = 24,
                Status = MedicalConditionStatus.Present
            }
        );

        builder.HasData(
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 11,
                MedicalConditionId = 11,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 12,
                MedicalConditionId = 12,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 13,
                MedicalConditionId = 13,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 14,
                MedicalConditionId = 14,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 15,
                MedicalConditionId = 15,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 16,
                MedicalConditionId = 16,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 17,
                MedicalConditionId = 17,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 18,
                MedicalConditionId = 18,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 19,
                MedicalConditionId = 19,
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 20,
                MedicalConditionId = 20,
                Status = MedicalConditionStatus.Past
            }
        );
    }
}
