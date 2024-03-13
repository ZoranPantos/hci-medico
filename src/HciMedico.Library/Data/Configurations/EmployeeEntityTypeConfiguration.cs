using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Library.Data.Configurations;

public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        var random = new Random();
        long min = 10000000000, max = 99999999999;

        builder
            .OwnsOne(e => e.Address)
            .HasData(
                new { EmployeeId = 1, Country = "Serbia", City = "Beograd", Street = "Kralja Milutina", Number = 10 },
                new { EmployeeId = 2, Country = "Serbia", City = "Novi Sad", Street = "Bulevar Oslobođenja", Number = 15 },
                new { EmployeeId = 3, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Kralja Petra I", Number = 8 },
                new { EmployeeId = 4, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Vuka Karadžića", Number = 22 },
                new { EmployeeId = 5, Country = "Serbia", City = "Beograd", Street = "Kneza Miloša", Number = 17 },
                new { EmployeeId = 6, Country = "Bosnia and Herzegovina", City = "Prijedor", Street = "Nikole Tesle", Number = 9 },
                new { EmployeeId = 7, Country = "Serbia", City = "Novi Sad", Street = "Jovana Cvijića", Number = 14 },
                new { EmployeeId = 8, Country = "Bosnia and Herzegovina", City = "Bijeljina", Street = "Vojvode Živojina Mišića", Number = 6 },
                new { EmployeeId = 9, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Branka Ćopića", Number = 11 },
                new { EmployeeId = 10, Country = "Serbia", City = "Beograd", Street = "Vojislava Ilića", Number = 20 },
                new { EmployeeId = 11, Country = "Serbia", City = "Novi Sad", Street = "Aleksandra Puškina", Number = 19 },
                new { EmployeeId = 12, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Đure Jakšića", Number = 7 },
                new { EmployeeId = 13, Country = "Serbia", City = "Novi Sad", Street = "Kraljice Natalije", Number = 16 },
                new { EmployeeId = 14, Country = "Bosnia and Herzegovina", City = "Prijedor", Street = "Stevana Mokranjca", Number = 5 },
                new { EmployeeId = 15, Country = "Serbia", City = "Beograd", Street = "Jug Bogdanova", Number = 18 },
                new { EmployeeId = 16, Country = "Bosnia and Herzegovina", City = "Bijeljina", Street = "Desanke Maksimović", Number = 4 },
                new { EmployeeId = 17, Country = "Serbia", City = "Beograd", Street = "Kneza Miloša", Number = 11 },
                new { EmployeeId = 18, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Svetozara Markovića", Number = 3 },
                new { EmployeeId = 19, Country = "Serbia", City = "Beograd", Street = "Njegoševa", Number = 7 },
                new { EmployeeId = 20, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Vojvode Stepe", Number = 2 },
                new { EmployeeId = 21, Country = "Serbia", City = "Novi Sad", Street = "Kralja Milutina", Number = 10 },
                new { EmployeeId = 22, Country = "Bosnia and Herzegovina", City = "Prijedor", Street = "Bulevar Oslobođenja", Number = 15 },
                new { EmployeeId = 23, Country = "Serbia", City = "Novi Sad", Street = "Kralja Petra I", Number = 8 },
                new { EmployeeId = 24, Country = "Bosnia and Herzegovina", City = "Bijeljina", Street = "Vuka Karadžića", Number = 22 },
                new { EmployeeId = 25, Country = "Serbia", City = "Beograd", Street = "Branka Ćopića", Number = 11 },
                new { EmployeeId = 26, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Đure Jakšića", Number = 7 },
                new { EmployeeId = 27, Country = "Serbia", City = "Novi Sad", Street = "Kraljice Natalije", Number = 16 },
                new { EmployeeId = 28, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Stevana Mokranjca", Number = 5 },
                new { EmployeeId = 29, Country = "Serbia", City = "Beograd", Street = "Jug Bogdanova", Number = 18 },
                new { EmployeeId = 30, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Desanke Maksimović", Number = 4 },
                new { EmployeeId = 31, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Svetog Save", Number = 10 },
                new { EmployeeId = 32, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Vojvode Putnika", Number = 7 },
                new { EmployeeId = 33, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Kralja Petra I", Number = 22 },
                new { EmployeeId = 34, Country = "Bosnia and Herzegovina", City = "Banja Luka", Street = "Desanke Maksimović", Number = 33 }
            );

        builder
            .OwnsOne(e => e.ContactInfo)
            .HasData(
                new { EmployeeId = 1, Email = "marko.petrovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 2, Email = "ana.jovanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 3, Email = "nikola.stojanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 4, Email = "milan.popovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 5, Email = "jovana.nikolic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 6, Email = "stefan.ilic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 7, Email = "marija.pavlovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 8, Email = "aleksandar.djordjevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 9, Email = "ana.jankovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 10, Email = "petar.stankovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 11, Email = "jelena.petrovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 12, Email = "dragan.kovacevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 13, Email = "milica.ivanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 14, Email = "nemanja.jovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 15, Email = "mina.pavlovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 16, Email = "vladimir.stanisic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 17, Email = "jovanka.djordjevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 18, Email = "branimir.nikolic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 19, Email = "ana.jankovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 20, Email = "nikola.stankovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 21, Email = "sanja.petrovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 22, Email = "milos.jovanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 23, Email = "tatjana.stojanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 24, Email = "vladimir.stankovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 25, Email = "ivana.jankovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 26, Email = "nenad.petrovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 27, Email = "milica.ilic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 28, Email = "vladan.djordjevic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 29, Email = "sara.pavlovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 30, Email = "nemanja.stanisic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 31, Email = "ksenija.markovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 32, Email = "milica.simeunovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 33, Email = "petar.tomic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" },
                new { EmployeeId = 34, Email = "ana.jovanovic@test.com", TelephoneNumber = $"+{random.NextInt64(min, max)}" }
            );

    }
}
