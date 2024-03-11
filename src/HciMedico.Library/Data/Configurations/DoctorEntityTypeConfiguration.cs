using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Library.Data.Configurations;

public class DoctorEntityTypeConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder
            .HasMany(d => d.Specializations)
            .WithMany(ms => ms.Doctors)
            .UsingEntity(j => j.ToTable("doctor_medicalspecialization"));
    }
}
