using HciMedico.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Integration.Data.Configurations;

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
                new { PatientId = 10, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Kralja Aleksandra", Number = 10 },
                new { PatientId = 11, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Vojvode Miše", Number = 11 },
                new { PatientId = 12, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Prijedorska", Number = 12 },
                new { PatientId = 13, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Kozaračka", Number = 13 },
                new { PatientId = 14, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Milana Karanovića", Number = 14 },
                new { PatientId = 15, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Mladena Borenovića", Number = 15 },
                new { PatientId = 16, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Kraljice Marije", Number = 16 },
                new { PatientId = 17, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Obrenovačka", Number = 17 },
                new { PatientId = 18, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Ozrenska", Number = 18 },
                new { PatientId = 19, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Srbijanska", Number = 19 },
                new { PatientId = 20, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Duška Radetića", Number = 20 }
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
                new { PatientId = 10, Email = "goran.predojevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 11, Email = "ljuboje.ljubojevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 12, Email = "ramiza.ramizovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 13, Email = "hrvoje.hrvojevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 14, Email = "alma.almovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 15, Email = "radovan.radovanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 16, Email = "iskra.iskric@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 17, Email = "semsa.semsic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 18, Email = "vladimir.vladimirovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 19, Email = "mila.milojevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { PatientId = 20, Email = "stojan.stojanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" }
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
            },
            new Patient
            {
                Id = 11,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ljuboje",
                LastName = "Ljubojević"
            },
            new Patient
            {
                Id = 12,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ramiza",
                LastName = "Ramizović"
            },
            new Patient
            {
                Id = 13,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Hrvoje",
                LastName = "Hrvojević"
            },
            new Patient
            {
                Id = 14,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Alma",
                LastName = "Almović"
            },
            new Patient
            {
                Id = 15,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Radovan",
                LastName = "Radovanović"
            },
            new Patient
            {
                Id = 16,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Iskra",
                LastName = "Iskrić"
            },
            new Patient
            {
                Id = 17,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Šemsa",
                LastName = "Šemsić"
            },
            new Patient
            {
                Id = 18,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Vladimir",
                LastName = "Vladimirović"
            },
            new Patient
            {
                Id = 19,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Mila",
                LastName = "Milojević"
            },
            new Patient
            {
                Id = 20,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Stojan",
                LastName = "Stojanović"
            }
        );
    }
}
