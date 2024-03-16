using HciMedico.Library.Models.Relationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HciMedico.Library.Models.Enums;

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

        builder.HasData(
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 1,
                MedicalConditionId = 4, ///////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 2,
                MedicalConditionId = 4,///////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 3,
                MedicalConditionId = 4,////////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 4,
                MedicalConditionId = 90,//////////////////////////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 5,
                MedicalConditionId = 90,//////////////////////////////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 6,
                MedicalConditionId = 90,/////////////////////////////////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 7,
                MedicalConditionId = 90,/////////////////////////////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 8,
                MedicalConditionId = 97,//////////////////////////////////////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 9,
                MedicalConditionId = 97,/////////////////////////////////////////////
                Status = MedicalConditionStatus.Past
            },
            new HealthRecordMedicalCondition
            {
                HealthRecordId = 10,
                MedicalConditionId = 97,////////////////////////////////////////////////
                Status = MedicalConditionStatus.Past
            }

            //TODO: add more but with the status current - they will be scheduled for more follow-ups in the future
        );
    }
}
