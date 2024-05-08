using HciMedico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

public class WorkScheduleEntityTypeConfiguration : IEntityTypeConfiguration<WorkSchedule>
{
    public void Configure(EntityTypeBuilder<WorkSchedule> builder)
    {
        builder.HasData(
            new WorkSchedule
            {
                Id = 1,
                EmployeeId = 31
            },
            new WorkSchedule
            {
                Id = 2,
                EmployeeId = 1
            }
        );
    }
}
