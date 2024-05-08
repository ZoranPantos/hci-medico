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
                DateTime = DateTime.Now.Date,
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 2,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(2),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 3,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(4),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 4,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 5,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 6,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 7,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 8,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 9,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 10,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 11,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 12,
                ScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            }
        );

        builder.HasData(
            new ScheduleCell
            {
                Id = 13,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date,
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 14,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(2),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 15,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(4),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 16,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 17,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 18,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 19,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 20,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 21,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 22,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 23,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new ScheduleCell
            {
                Id = 24,
                ScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            }
        );
    }
}
