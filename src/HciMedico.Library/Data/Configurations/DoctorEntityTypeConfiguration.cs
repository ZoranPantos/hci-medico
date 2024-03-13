using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HciMedico.Library.Models.Enums;

namespace HciMedico.Library.Data.Configurations;

public class DoctorEntityTypeConfiguration : IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        var random = new Random();
        long min = 1000000000000, max = 9999999999999;

        builder
            .HasMany(d => d.Specializations)
            .WithMany(ms => ms.Doctors)
            .UsingEntity(j =>
                {
                    j.ToTable("doctor_medicalspecialization");

                    j.HasData(
                        new { DoctorsId = 1, SpecializationsId = 1 },
                        new { DoctorsId = 1, SpecializationsId = 33 },
                        new { DoctorsId = 2, SpecializationsId = 1 },
                        new { DoctorsId = 3, SpecializationsId = 2 },
                        new { DoctorsId = 3, SpecializationsId = 29 },
                        new { DoctorsId = 4, SpecializationsId = 2 },
                        new { DoctorsId = 5, SpecializationsId = 3 },
                        new { DoctorsId = 6, SpecializationsId = 5 },
                        new { DoctorsId = 7, SpecializationsId = 6 },
                        new { DoctorsId = 8, SpecializationsId = 7 },
                        new { DoctorsId = 9, SpecializationsId = 8 },
                        new { DoctorsId = 10, SpecializationsId = 9 },
                        new { DoctorsId = 11, SpecializationsId = 10 },
                        new { DoctorsId = 12, SpecializationsId = 13 },
                        new { DoctorsId = 13, SpecializationsId = 13 },
                        new { DoctorsId = 13, SpecializationsId = 24 },
                        new { DoctorsId = 14, SpecializationsId = 15 },
                        new { DoctorsId = 15, SpecializationsId = 19 },
                        new { DoctorsId = 16, SpecializationsId = 19 },
                        new { DoctorsId = 17, SpecializationsId = 41 },
                        new { DoctorsId = 18, SpecializationsId = 44 },
                        new { DoctorsId = 19, SpecializationsId = 44 },
                        new { DoctorsId = 20, SpecializationsId = 44 },
                        new { DoctorsId = 21, SpecializationsId = 31 },
                        new { DoctorsId = 22, SpecializationsId = 32 },
                        new { DoctorsId = 23, SpecializationsId = 34 },
                        new { DoctorsId = 24, SpecializationsId = 35 },
                        new { DoctorsId = 25, SpecializationsId = 37 },
                        new { DoctorsId = 26, SpecializationsId = 38 },
                        new { DoctorsId = 26, SpecializationsId = 25 },
                        new { DoctorsId = 27, SpecializationsId = 39 },
                        new { DoctorsId = 28, SpecializationsId = 40 },
                        new { DoctorsId = 29, SpecializationsId = 42 },
                        new { DoctorsId = 30, SpecializationsId = 43 }
                    );
                }
            );

        builder.HasData(
            new Doctor
            {
                Id = 1,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Marko",
                LastName = "Petrović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1985, 10, 15)
            },
            new Doctor
            {
                Id = 2,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ana",
                LastName = "Jovanović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1980, 5, 25)
            },
            new Doctor
            {
                Id = 3,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Nikola",
                LastName = "Stojanović",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1975, 8, 20)
            },
            new Doctor
            {
                Id = 4,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Milan",
                LastName = "Popović",
                Education = "University of Banja Luka, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1972, 6, 12)
            },
            new Doctor
            {
                Id = 5,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Jovana",
                LastName = "Nikolić",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1990, 3, 8)
            },
            new Doctor
            {
                Id = 6,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Stefan",
                LastName = "Ilić",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1983, 12, 5)
            },
            new Doctor
            {
                Id = 7,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Marija",
                LastName = "Pavlović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1978, 9, 18)
            },
            new Doctor
            {
                Id = 8,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Aleksandar",
                LastName = "Đorđević",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1968, 7, 30)
            },
            new Doctor
            {
                Id = 9,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ana",
                LastName = "Janković",
                Education = "University of Banja Luka, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1986, 2, 22)
            },
            new Doctor
            {
                Id = 10,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Petar",
                LastName = "Stanković",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1970, 11, 9)
            },
            new Doctor
            {
                Id = 11,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Jelena",
                LastName = "Petrović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1982, 4, 3)
            },
            new Doctor
            {
                Id = 12,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Dragan",
                LastName = "Kovačević",
                Education = "University of Banja Luka, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1974, 8, 14)
            },
            new Doctor
            {
                Id = 13,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Milica",
                LastName = "Ivanović",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1993, 6, 27)
            },
            new Doctor
            {
                Id = 14,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Nemanja",
                LastName = "Jović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1965, 10, 8)
            },
            new Doctor
            {
                Id = 15,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Mina",
                LastName = "Pavlović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1988, 7, 19)
            },
            new Doctor
            {
                Id = 16,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Vladimir",
                LastName = "Stanišić",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1971, 12, 11)
            },
            new Doctor
            {
                Id = 17,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Jovanka",
                LastName = "Đorđević",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1984, 9, 30)
            },
            new Doctor
            {
                Id = 18,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Branimir",
                LastName = "Nikolić",
                Education = "University of Banja Luka, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1976, 3, 24)
            },
            new Doctor
            {
                Id = 19,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ana",
                LastName = "Janković",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1980, 8, 7)
            },
            new Doctor
            {
                Id = 20,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Nikola",
                LastName = "Stanković",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1963, 11, 3)
            },
            new Doctor
            {
                Id = 21,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Sanja",
                LastName = "Petrović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1981, 5, 15)
            },
            new Doctor
            {
                Id = 22,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Miloš",
                LastName = "Jovanović",
                Education = "University of Banja Luka, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1979, 6, 20)
            },
            new Doctor
            {
                Id = 23,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Tatjana",
                LastName = "Stojanović",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1962, 3, 8)
            },
            new Doctor
            {
                Id = 24,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Vladimir",
                LastName = "Stanković",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1995, 8, 18)
            },
            new Doctor
            {
                Id = 25,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ivana",
                LastName = "Janković",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1973, 7, 30)
            },
            new Doctor
            {
                Id = 26,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Nenad",
                LastName = "Petrović",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1984, 11, 9)
            },
            new Doctor
            {
                Id = 27,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Milica",
                LastName = "Ilić",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1967, 6, 27)
            },
            new Doctor
            {
                Id = 28,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Vladan",
                LastName = "Đorđević",
                Education = "University of Banja Luka, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1979, 10, 8)
            },
            new Doctor
            {
                Id = 29,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Sara",
                LastName = "Pavlović",
                Education = "University of Belgrade, Medical Faculty",
                Gender = Gender.Female,
                DateOfBirth = new(1982, 7, 19)
            },
            new Doctor
            {
                Id = 30,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Nemanja",
                LastName = "Stanišić",
                Education = "University of Novi Sad, Medical Faculty",
                Gender = Gender.Male,
                DateOfBirth = new(1986, 12, 11)
            }
        );
    }
}
