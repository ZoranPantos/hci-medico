﻿using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HciMedico.Library.Models.Enums;

namespace HciMedico.Library.Data.Configurations;

public class AppointmentEntityTypeConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        // Initial and follow-up appointments for each patient once
        builder.HasData(
            new Appointment
            {
                Id = 1,
                DateAndTime = new(2024, 1, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic"
            },
            new Appointment
            {
                Id = 2,
                DateAndTime = new(2024, 1, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic"
            },
            new Appointment
            {
                Id = 3,
                DateAndTime = new(2024, 1, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 2,
                DoctorId = 16,
                CounterWorkerId = 31,
                PatientId = 2,
                IdentifierName = "saska macetic"
            },
            new Appointment
            {
                Id = 4,
                DateAndTime = new(2024, 1, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 2,
                DoctorId = 16,
                CounterWorkerId = 32,
                PatientId = 2,
                IdentifierName = "saska macetic"
            },
            new Appointment
            {
                Id = 5,
                DateAndTime = new(2024, 1, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 3,
                DoctorId = 15,
                CounterWorkerId = 32,
                PatientId = 3,
                IdentifierName = "milos milosavljevic"
            },
            new Appointment
            {
                Id = 6,
                DateAndTime = new(2024, 1, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 3,
                DoctorId = 15,
                CounterWorkerId = 32,
                PatientId = 3,
                IdentifierName = "milos milosavljevic"
            },
            new Appointment
            {
                Id = 7,
                DateAndTime = new(2024, 1, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic"
            },
            new Appointment
            {
                Id = 8,
                DateAndTime = new(2024, 1, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic"
            },
            new Appointment
            {
                Id = 9,
                DateAndTime = new(2024, 1, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 5,
                DoctorId = 4,
                CounterWorkerId = 33,
                PatientId = 5,
                IdentifierName = "darko darkovic"
            },
            new Appointment
            {
                Id = 10,
                DateAndTime = new(2024, 1, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 5,
                DoctorId = 4,
                CounterWorkerId = 34,
                PatientId = 5,
                IdentifierName = "darko darkovic"
            },
            new Appointment
            {
                Id = 11,
                DateAndTime = new(2024, 1, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 6,
                DoctorId = 3,
                CounterWorkerId = 34,
                PatientId = 6,
                IdentifierName = "jovana jovanovic"
            },
            new Appointment
            {
                Id = 12,
                DateAndTime = new(2024, 1, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 6,
                DoctorId = 3,
                CounterWorkerId = 34,
                PatientId = 6,
                IdentifierName = "jovana jovanovic"
            },
            new Appointment
            {
                Id = 13,
                DateAndTime = new(2024, 1, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 7,
                DoctorId = 4,
                CounterWorkerId = 31,
                PatientId = 7,
                IdentifierName = "nikola nikolic"
            },
            new Appointment
            {
                Id = 14,
                DateAndTime = new(2024, 1, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 7,
                DoctorId = 4,
                CounterWorkerId = 31,
                PatientId = 7,
                IdentifierName = "nikola nikolic"
            },
            new Appointment
            {
                Id = 15,
                DateAndTime = new(2024, 2, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 8,
                DoctorId = 1,
                CounterWorkerId = 32,
                PatientId = 8,
                IdentifierName = "david davidovic"
            },
            new Appointment
            {
                Id = 16,
                DateAndTime = new(2024, 2, 25),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 8,
                DoctorId = 1,
                CounterWorkerId = 32,
                PatientId = 8,
                IdentifierName = "david davidovic"
            },
            new Appointment
            {
                Id = 17,
                DateAndTime = new(2024, 2, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 9,
                DoctorId = 1,
                CounterWorkerId = 33,
                PatientId = 9,
                IdentifierName = "stana stanojevic"
            },
            new Appointment
            {
                Id = 18,
                DateAndTime = new(2024, 2, 25),
                Status = AppointmentStatus.Cancelled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 9,
                DoctorId = 1,
                CounterWorkerId = 33,
                PatientId = 9,
                IdentifierName = "stana stanojevic"
            },
            new Appointment
            {
                Id = 19,
                DateAndTime = new(2024, 2, 5),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 10,
                DoctorId = 1,
                CounterWorkerId = 34,
                PatientId = 10,
                IdentifierName = "goran predojevic"
            },
            new Appointment
            {
                Id = 20,
                DateAndTime = new(2024, 2, 25),
                Status = AppointmentStatus.Cancelled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 10,
                DoctorId = 1,
                CounterWorkerId = 34,
                PatientId = 10,
                IdentifierName = "goran predojevic"
            }
        );

        // More initials and follow-ups for some patients
        builder.HasData(
            new Appointment
            {
                Id = 21,
                DateAndTime = new(2024, 2, 6),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic"
            },
            new Appointment
            {
                Id = 22,
                DateAndTime = new(2024, 2, 20),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic"
            },
            new Appointment
            {
                Id = 23,
                DateAndTime = new(2024, 2, 7),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic"
            },
            new Appointment
            {
                Id = 24,
                DateAndTime = new(2024, 2, 22),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic"
            }
        );

        // More initials and follow-ups with current condition for some patients
        builder.HasData(
            new Appointment
            {
                Id = 25,
                DateAndTime = new(2024, 3, 20),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 1,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic"
            },
            new Appointment
            {
                Id = 26,
                DateAndTime = new(2025, 1, 19),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic"
            },
            new Appointment
            {
                Id = 27,
                DateAndTime = new(2024, 3, 19),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 2,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 2,
                IdentifierName = "saska macetic"
            },
            new Appointment
            {
                Id = 28,
                DateAndTime = new(2025, 1, 19),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 2,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 2,
                IdentifierName = "saska macetic"
            },
            new Appointment
            {
                Id = 29,
                DateAndTime = new(2024, 3, 22),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 3,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 3,
                IdentifierName = "milos milosavljevic"
            },
            new Appointment
            {
                Id = 30,
                DateAndTime = new(2025, 1, 19),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 3,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 3,
                IdentifierName = "milos milosavljevic"
            }
        );

        // Initials for new unregistered patients
        builder.HasData(
            new Appointment
            {
                Id = 31,
                DateAndTime = new(2025, 3, 20),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 11,
                CounterWorkerId = 32,
                IdentifierName = "lana pepic"
            },
            new Appointment
            {
                Id = 32,
                DateAndTime = new(2025, 3, 20),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 12,
                CounterWorkerId = 32,
                IdentifierName = "nikola jokic"
            },
            new Appointment
            {
                Id = 33,
                DateAndTime = new(2025, 3, 20),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 14,
                CounterWorkerId = 32,
                IdentifierName = "marija novakovic"
            },
            new Appointment
            {
                Id = 34,
                DateAndTime = new(2025, 3, 20),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 19,
                CounterWorkerId = 32,
                IdentifierName = "branko brankovic"
            }
        );
    }
}
