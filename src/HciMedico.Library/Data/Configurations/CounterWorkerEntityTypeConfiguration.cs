using HciMedico.Library.Models;
using HciMedico.Library.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HciMedico.Library.Data.Configurations;

public class CounterWorkerEntityTypeConfiguration : IEntityTypeConfiguration<CounterWorker>
{
    public void Configure(EntityTypeBuilder<CounterWorker> builder)
    {
        var random = new Random();
        long min = 1000000000000, max = 9999999999999;

        builder.HasData(
            new CounterWorker
            {
                Id = 31,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ksenija",
                LastName = "Marković",
                Education = "Medical High School, Banja Luka",
                Gender = Gender.Female,
                DateOfBirth = new(1998, 3, 21),
                EmployedSince = new(2022, 1, 1),
                CurrentSalary = 1500.00
            }
            ,
            new CounterWorker
            {
                Id = 32,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Milica",
                LastName = "Simeunović",
                Education = "Medical High School, Banja Luka",
                Gender = Gender.Female,
                DateOfBirth = new(1995, 7, 14),
                EmployedSince = new(2022, 1, 1),
                CurrentSalary = 1500.00
            },
            new CounterWorker
            {
                Id = 33,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Petar",
                LastName = "Tomić",
                Education = "Medical High School, Banja Luka",
                Gender = Gender.Male,
                DateOfBirth = new(1992, 8, 8),
                EmployedSince = new(2022, 1, 1),
                CurrentSalary = 1500.00
            },
            new CounterWorker
            {
                Id = 34,
                Uid = random.NextInt64(min, max).ToString(),
                FirstName = "Ana",
                LastName = "Jovanović",
                Education = "Medical High School, Banja Luka",
                Gender = Gender.Female,
                DateOfBirth = new(1991, 4, 16),
                EmployedSince = new(2022, 1, 1),
                CurrentSalary = 1500.00
            }
        );
    }
}
