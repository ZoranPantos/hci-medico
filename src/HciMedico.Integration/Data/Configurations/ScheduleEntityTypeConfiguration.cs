using HciMedico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

public class ScheduleEntityTypeConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.HasData(
            new Schedule
            {
                Id = 1,
                EmployeeId = 31
            },
            new Schedule
            {
                Id = 2,
                EmployeeId = 1
            }
        );
    }
}
