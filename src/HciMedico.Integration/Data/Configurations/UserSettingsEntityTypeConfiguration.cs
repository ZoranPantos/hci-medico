using HciMedico.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HciMedico.Domain.Models.Enums;

namespace HciMedico.Integration.Data.Configurations;

public class UserSettingsEntityTypeConfiguration : IEntityTypeConfiguration<UserSettings>
{
    public void Configure(EntityTypeBuilder<UserSettings> builder)
    {
        builder.HasData(
            new UserSettings
            {
                Id = 1,
                UserAccountId = 1,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 2,
                UserAccountId = 2,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 3,
                UserAccountId = 3,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 4,
                UserAccountId = 4,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 5,
                UserAccountId = 5,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 6,
                UserAccountId = 6,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 7,
                UserAccountId = 7,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 8,
                UserAccountId = 8,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 9,
                UserAccountId = 9,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 10,
                UserAccountId = 10,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 11,
                UserAccountId = 11,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 12,
                UserAccountId = 12,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 13,
                UserAccountId = 13,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 14,
                UserAccountId = 14,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 15,
                UserAccountId = 15,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 16,
                UserAccountId = 16,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 17,
                UserAccountId = 17,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 18,
                UserAccountId = 18,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 19,
                UserAccountId = 19,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 20,
                UserAccountId = 20,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 21,
                UserAccountId = 21,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 22,
                UserAccountId = 22,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 23,
                UserAccountId = 23,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 24,
                UserAccountId = 24,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 25,
                UserAccountId = 25,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 26,
                UserAccountId = 26,
                LandingPage = LandingPage.Appointments
            }, new UserSettings
            {
                Id = 27,
                UserAccountId = 27,
                LandingPage = LandingPage.Appointments
            }, new UserSettings
            {
                Id = 28,
                UserAccountId = 28,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 29,
                UserAccountId = 29,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 30,
                UserAccountId = 30,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 31,
                UserAccountId = 31,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 32,
                UserAccountId = 32,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 33,
                UserAccountId = 33,
                LandingPage = LandingPage.Appointments
            },
            new UserSettings
            {
                Id = 34,
                UserAccountId = 34,
                LandingPage = LandingPage.Appointments
            }
        );
    }
}
