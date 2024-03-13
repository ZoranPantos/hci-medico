using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace HciMedico.Library.Data.Configurations;

public class PatientEntityTypeConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        var random = new Random();
        long min = 10000000000, max = 99999999999;

        builder
            .OwnsOne(p => p.Address)
            .HasData(
                new { PatientId = 1, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Kralja Milutina", Number = 1 },
                new { PatientId = 2, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Novska", Number = 2 },
                new { PatientId = 3, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Milana Jazbeca", Number = 3 },
                new { PatientId = 4, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Krfska", Number = 4 },
                new { PatientId = 5, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Miše Kovača", Number = 5 },
                new { PatientId = 6, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Davida Štrbca", Number = 6 },
                new { PatientId = 7, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Ranka Šipke", Number = 7 },
                new { PatientId = 8, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Karađorđeva", Number = 8 },
                new { PatientId = 9, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Leskovačka", Number = 9 },
                new { PatientId = 10, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Krajiška", Number = 10 }
            );

        builder
            .OwnsOne(p => p.ContactInfo)
            .HasData(
                new { PatientId = 1, Email = "boris.borisavljevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 2, Email = "saska.macetic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 3, Email = "milos.milosevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 4, Email = "ana.stanojevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 5, Email = "darko.darkovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 6, Email = "jovana.jovanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 7, Email = "nikola.nikolic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 8, Email = "david.davidovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 9, Email = "stana.stanojevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 10, Email = "goran.predojevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" }
            );

        builder.HasData(
            new Patient
            {
                Id = 1,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Boris",
                LastName = "Borisavljević"
            },
            new Patient
            {
                Id = 2,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Saška",
                LastName = "Mačetić"
            },
            new Patient
            {
                Id = 3,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Miloš",
                LastName = "Milosavljević"
            },
            new Patient
            {
                Id = 4,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ana",
                LastName = "Stanojević"
            },
            new Patient
            {
                Id = 5,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Darko",
                LastName = "Darković"
            },
            new Patient
            {
                Id = 6,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Jovana",
                LastName = "Jovanović"
            },
            new Patient
            {
                Id = 7,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Nikola",
                LastName = "Nikolić"
            },
            new Patient
            {
                Id = 8,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "David",
                LastName = "Davidović"
            },
            new Patient
            {
                Id = 9,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Stana",
                LastName = "Stanojević"
            },
            new Patient
            {
                Id = 10,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Goran",
                LastName = "Predojević"
            }
        );
    }
}
