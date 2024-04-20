using HciMedico.Domain.Models;
using HciMedico.Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

public class HealthRecordEntityTypeConfiguration : IEntityTypeConfiguration<HealthRecord>
{
    public void Configure(EntityTypeBuilder<HealthRecord> builder)
    {
        builder.HasData(
            new HealthRecord
            {
                Id = 1,
                PatientId = 1,
                DateOfBirth = new(1960, 1, 2),
                Gender = Gender.Male,
                BloodGroup = BloodGroup.AB_Positive
            },
            new HealthRecord
            {
                Id = 2,
                PatientId = 2,
                DateOfBirth = new(1961, 3, 4),
                Gender = Gender.Female,
                BloodGroup = BloodGroup.AB_Negative
            },
            new HealthRecord
            {
                Id = 3,
                PatientId = 3,
                DateOfBirth = new(1963, 5, 6),
                Gender = Gender.Male,
                BloodGroup = BloodGroup.A_Positive
            },
            new HealthRecord
            {
                Id = 4,
                PatientId = 4,
                DateOfBirth = new(1964, 7, 8),
                Gender = Gender.Female,
                BloodGroup = BloodGroup.A_Negative
            },
            new HealthRecord
            {
                Id = 5,
                PatientId = 5,
                DateOfBirth = new(1965, 9, 10),
                Gender = Gender.Male,
                BloodGroup = BloodGroup.B_Positive
            },
            new HealthRecord
            {
                Id = 6,
                PatientId = 6,
                DateOfBirth = new(1966, 11, 12),
                Gender = Gender.Female,
                BloodGroup = BloodGroup.B_Negative
            },
            new HealthRecord
            {
                Id = 7,
                PatientId = 7,
                DateOfBirth = new(1967, 12, 13),
                Gender = Gender.Male,
                BloodGroup = BloodGroup.O_positive
            },
            new HealthRecord
            {
                Id = 8,
                PatientId = 8,
                DateOfBirth = new(1968, 1, 14),
                Gender = Gender.Male,
                BloodGroup = BloodGroup.O_negative
            },
            new HealthRecord
            {
                Id = 9,
                PatientId = 9,
                DateOfBirth = new(1969, 2, 15),
                Gender = Gender.Female,
                BloodGroup = BloodGroup.AB_Positive
            },
            new HealthRecord
            {
                Id = 10,
                PatientId = 10,
                DateOfBirth = new(1970, 3, 16),
                Gender = Gender.Male,
                BloodGroup = BloodGroup.AB_Negative
            }
        );
    }
}
