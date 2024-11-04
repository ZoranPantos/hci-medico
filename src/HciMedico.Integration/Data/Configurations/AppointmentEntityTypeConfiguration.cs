using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HciMedico.Domain.Models.Enums;
using HciMedico.Domain.Models.Entities;

namespace HciMedico.Integration.Data.Configurations;

public class AppointmentEntityTypeConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        // Initial and follow-up appointments for each patient once
        builder.HasData(
            new Appointment
            {
                Id = 1,
                DateAndTime = new(2024, 1, 5, 8, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 2,
                DateAndTime = new(2024, 1, 19, 8, 20, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 3,
                DateAndTime = new(2024, 1, 5, 8, 40, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 2,
                DoctorId = 16,
                CounterWorkerId = 31,
                PatientId = 2,
                IdentifierName = "saska macetic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 4,
                DateAndTime = new(2024, 1, 19, 9, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 2,
                DoctorId = 16,
                CounterWorkerId = 32,
                PatientId = 2,
                IdentifierName = "saska macetic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 5,
                DateAndTime = new(2024, 1, 5, 10, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 3,
                DoctorId = 15,
                CounterWorkerId = 32,
                PatientId = 3,
                IdentifierName = "milos milosavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 6,
                DateAndTime = new(2024, 1, 19, 10, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 3,
                DoctorId = 15,
                CounterWorkerId = 32,
                PatientId = 3,
                IdentifierName = "milos milosavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 7,
                DateAndTime = new(2024, 1, 5, 11, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 8,
                DateAndTime = new(2024, 1, 19, 11, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 9,
                DateAndTime = new(2024, 1, 5, 12, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 5,
                DoctorId = 4,
                CounterWorkerId = 33,
                PatientId = 5,
                IdentifierName = "darko darkovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 10,
                DateAndTime = new(2024, 1, 19, 12, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 5,
                DoctorId = 4,
                CounterWorkerId = 34,
                PatientId = 5,
                IdentifierName = "darko darkovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 11,
                DateAndTime = new(2024, 1, 5, 13, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 6,
                DoctorId = 3,
                CounterWorkerId = 34,
                PatientId = 6,
                IdentifierName = "jovana jovanovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 12,
                DateAndTime = new(2024, 1, 19, 13, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 6,
                DoctorId = 3,
                CounterWorkerId = 34,
                PatientId = 6,
                IdentifierName = "jovana jovanovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 13,
                DateAndTime = new(2024, 1, 5, 14, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 7,
                DoctorId = 4,
                CounterWorkerId = 31,
                PatientId = 7,
                IdentifierName = "nikola nikolic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 14,
                DateAndTime = new(2024, 1, 19, 14, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 7,
                DoctorId = 4,
                CounterWorkerId = 31,
                PatientId = 7,
                IdentifierName = "nikola nikolic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 15,
                DateAndTime = new(2024, 2, 5, 15, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 8,
                DoctorId = 1,
                CounterWorkerId = 32,
                PatientId = 8,
                IdentifierName = "david davidovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 16,
                DateAndTime = new(2024, 2, 25, 15, 20, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 8,
                DoctorId = 1,
                CounterWorkerId = 32,
                PatientId = 8,
                IdentifierName = "david davidovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 17,
                DateAndTime = new(2024, 2, 5, 15, 40, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 9,
                DoctorId = 1,
                CounterWorkerId = 33,
                PatientId = 9,
                IdentifierName = "stana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 18,
                DateAndTime = new(2024, 2, 25, 16, 0, 0),
                Status = AppointmentStatus.Cancelled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 9,
                DoctorId = 1,
                CounterWorkerId = 33,
                PatientId = 9,
                IdentifierName = "stana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 19,
                DateAndTime = new(2024, 2, 5, 16, 20, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 10,
                DoctorId = 1,
                CounterWorkerId = 34,
                PatientId = 10,
                IdentifierName = "goran predojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 20,
                DateAndTime = new(2024, 2, 25, 16, 40, 0),
                Status = AppointmentStatus.Cancelled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 10,
                DoctorId = 1,
                CounterWorkerId = 34,
                PatientId = 10,
                IdentifierName = "goran predojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            }
        );

        // More initials and follow-ups for some patients
        builder.HasData(
            new Appointment
            {
                Id = 21,
                DateAndTime = new(2024, 2, 6, 17, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 22,
                DateAndTime = new(2024, 2, 20, 17, 20, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 23,
                DateAndTime = new(2024, 2, 7, 17, 40, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 24,
                DateAndTime = new(2024, 2, 22, 18, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 4,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 4,
                IdentifierName = "ana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            }
        );

        // More initials and follow-ups with current condition for some patients
        builder.HasData(
            new Appointment
            {
                Id = 25,
                DateAndTime = new(2024, 3, 20, 18, 20, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 1,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 26,
                DateAndTime = new(2025, 1, 19, 18, 40, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 1,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 27,
                DateAndTime = new(2024, 3, 19, 19, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 2,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 2,
                IdentifierName = "saska macetic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 28,
                DateAndTime = new(2025, 1, 19, 19, 20, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 2,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 2,
                IdentifierName = "saska macetic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 29,
                DateAndTime = new(2024, 3, 22, 19, 40, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 3,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 3,
                IdentifierName = "milos milosavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 30,
                DateAndTime = new(2025, 1, 19, 9, 20, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 3,
                DoctorId = 9,
                CounterWorkerId = 31,
                PatientId = 3,
                IdentifierName = "milos milosavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            }
        );

        // Initials for new unregistered patients
        builder.HasData(
            new Appointment
            {
                Id = 31,
                DateAndTime = new(2025, 3, 20, 9, 40, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 11,
                CounterWorkerId = 32,
                IdentifierName = "lana pepic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 32,
                DateAndTime = new(2025, 3, 20, 10, 20, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 12,
                CounterWorkerId = 32,
                IdentifierName = "nikola jokic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 33,
                DateAndTime = new(2025, 3, 20, 10, 40, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 14,
                CounterWorkerId = 32,
                IdentifierName = "marija novakovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 34,
                DateAndTime = new(2025, 3, 20, 11, 20, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                DoctorId = 19,
                CounterWorkerId = 32,
                IdentifierName = "branko brankovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            }
        );

        builder.HasData(
            new Appointment
            {
                Id = 35,
                DateAndTime = new(2024, 1, 5, 8, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 11,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 11,
                IdentifierName = "ljuboje borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 36,
                DateAndTime = new(2024, 1, 19, 8, 20, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 12,
                DoctorId = 15,
                CounterWorkerId = 31,
                PatientId = 12,
                IdentifierName = "ramiza ramizovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 37,
                DateAndTime = new(2024, 1, 5, 8, 40, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 13,
                DoctorId = 16,
                CounterWorkerId = 31,
                PatientId = 13,
                IdentifierName = "hrvoje hrvojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 38,
                DateAndTime = new(2024, 1, 19, 9, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 14,
                DoctorId = 16,
                CounterWorkerId = 32,
                PatientId = 14,
                IdentifierName = "alma almovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 39,
                DateAndTime = new(2024, 1, 5, 10, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 15,
                DoctorId = 15,
                CounterWorkerId = 32,
                PatientId = 15,
                IdentifierName = "radovan radovanovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 40,
                DateAndTime = new(2024, 1, 19, 10, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 16,
                DoctorId = 15,
                CounterWorkerId = 32,
                PatientId = 16,
                IdentifierName = "iskra iskric",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 41,
                DateAndTime = new(2024, 1, 5, 11, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 17,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 17,
                IdentifierName = "semsa semsic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 42,
                DateAndTime = new(2024, 1, 19, 11, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 18,
                DoctorId = 3,
                CounterWorkerId = 33,
                PatientId = 18,
                IdentifierName = "vladimir vladimirovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 43,
                DateAndTime = new(2024, 1, 5, 12, 0, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 19,
                DoctorId = 4,
                CounterWorkerId = 33,
                PatientId = 19,
                IdentifierName = "mila milojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 44,
                DateAndTime = new(2024, 1, 19, 12, 30, 0),
                Status = AppointmentStatus.Resolved,
                Type = AppointmentType.Initial,
                HealthRecordId = 20,
                DoctorId = 4,
                CounterWorkerId = 34,
                PatientId = 20,
                IdentifierName = "stojan stojanovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            }
        );

        // More appointments
        builder.HasData(
            new Appointment
            {
                Id = 45,
                DateAndTime = new(2025, 1, 5, 8, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 1,
                DoctorId = 1,
                CounterWorkerId = 31,
                PatientId = 1,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 46,
                DateAndTime = new(2025, 1, 19, 8, 20, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 2,
                DoctorId = 2,
                CounterWorkerId = 31,
                PatientId = 2,
                IdentifierName = "boris borisavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 47,
                DateAndTime = new(2025, 1, 5, 8, 40, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 3,
                DoctorId = 3,
                CounterWorkerId = 31,
                PatientId = 3,
                IdentifierName = "saska macetic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 48,
                DateAndTime = new(2025, 1, 19, 9, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 4,
                DoctorId = 4,
                CounterWorkerId = 32,
                PatientId = 4,
                IdentifierName = "saska macetic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 49,
                DateAndTime = new(2025, 1, 5, 10, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 5,
                DoctorId = 5,
                CounterWorkerId = 32,
                PatientId = 5,
                IdentifierName = "milos milosavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 50,
                DateAndTime = new(2025, 1, 19, 10, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 6,
                DoctorId = 6,
                CounterWorkerId = 32,
                PatientId = 6,
                IdentifierName = "milos milosavljevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 51,
                DateAndTime = new(2025, 1, 5, 11, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 7,
                DoctorId = 7,
                CounterWorkerId = 33,
                PatientId = 7,
                IdentifierName = "ana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 52,
                DateAndTime = new(2025, 1, 19, 11, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 8,
                DoctorId = 8,
                CounterWorkerId = 33,
                PatientId = 8,
                IdentifierName = "ana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 53,
                DateAndTime = new(2025, 1, 5, 12, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 9,
                DoctorId = 9,
                CounterWorkerId = 33,
                PatientId = 9,
                IdentifierName = "darko darkovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 54,
                DateAndTime = new(2025, 1, 19, 12, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 10,
                DoctorId = 10,
                CounterWorkerId = 34,
                PatientId = 10,
                IdentifierName = "darko darkovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 55,
                DateAndTime = new(2025, 1, 5, 13, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 11,
                DoctorId = 11,
                CounterWorkerId = 34,
                PatientId = 11,
                IdentifierName = "jovana jovanovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 56,
                DateAndTime = new(2025, 1, 19, 13, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 12,
                DoctorId = 12,
                CounterWorkerId = 34,
                PatientId = 12,
                IdentifierName = "jovana jovanovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 57,
                DateAndTime = new(2025, 1, 5, 14, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 13,
                DoctorId = 13,
                CounterWorkerId = 31,
                PatientId = 13,
                IdentifierName = "nikola nikolic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 58,
                DateAndTime = new(2025, 1, 19, 14, 30, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 14,
                DoctorId = 14,
                CounterWorkerId = 31,
                PatientId = 14,
                IdentifierName = "nikola nikolic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 59,
                DateAndTime = new(2025, 2, 5, 15, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 15,
                DoctorId = 15,
                CounterWorkerId = 32,
                PatientId = 15,
                IdentifierName = "david davidovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 60,
                DateAndTime = new(2025, 2, 25, 15, 20, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.FollowUp,
                HealthRecordId = 16,
                DoctorId = 16,
                CounterWorkerId = 32,
                PatientId = 16,
                IdentifierName = "david davidovic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 61,
                DateAndTime = new(2025, 2, 5, 15, 40, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 17,
                DoctorId = 17,
                CounterWorkerId = 33,
                PatientId = 17,
                IdentifierName = "stana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 62,
                DateAndTime = new(2025, 2, 25, 16, 0, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 18,
                DoctorId = 18,
                CounterWorkerId = 33,
                PatientId = 18,
                IdentifierName = "stana stanojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 63,
                DateAndTime = new(2025, 2, 5, 16, 20, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 19,
                DoctorId = 19,
                CounterWorkerId = 34,
                PatientId = 19,
                IdentifierName = "goran predojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            },
            new Appointment
            {
                Id = 64,
                DateAndTime = new(2025, 2, 25, 16, 40, 0),
                Status = AppointmentStatus.Scheduled,
                Type = AppointmentType.Initial,
                HealthRecordId = 20,
                DoctorId = 20,
                CounterWorkerId = 34,
                PatientId = 20,
                IdentifierName = "goran predojevic",
                CreationTime = new(2022, 1, 1, 8, 0, 0)
            }
        );
    }
}
