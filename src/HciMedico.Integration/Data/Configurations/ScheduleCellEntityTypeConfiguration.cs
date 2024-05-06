using HciMedico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

public class ScheduleCellEntityTypeConfiguration : IEntityTypeConfiguration<ScheduleCell>
{
    public void Configure(EntityTypeBuilder<ScheduleCell> builder)
    {
        builder.HasData(
            new ScheduleCell
            {
                Id = 1,
                ScheduleId = 1,
                DateTime = DateTime.Now,
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 2,
                ScheduleId = 1,
                DateTime = DateTime.Now.AddDays(1),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 3,
                ScheduleId = 1,
                DateTime = DateTime.Now.AddDays(2),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            }
        );
    }
}
