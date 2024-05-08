using HciMedico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

public class WorkShiftEntityTypeConfiguration : IEntityTypeConfiguration<WorkShift>
{
    public void Configure(EntityTypeBuilder<WorkShift> builder)
    {
        builder.HasData(
            new WorkShift
            {
                Id = 1,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date,
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 2,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(2),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 3,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(4),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 4,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 5,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 6,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 7,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 8,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 9,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 10,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 11,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 12,
                WorkScheduleId = 1,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            }
        );

        builder.HasData(
            new WorkShift
            {
                Id = 13,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date,
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 14,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(2),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 15,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(4),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 16,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 17,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 18,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 19,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 20,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 21,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 22,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(7),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 23,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(8),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            },
            new WorkShift
            {
                Id = 24,
                WorkScheduleId = 2,
                DateTime = DateTime.Now.Date.AddMonths(-1).AddDays(16),
                ShiftStartTime = "8 AM",
                ShiftEndTime = "4 PM"
            }
        );
    }
}
