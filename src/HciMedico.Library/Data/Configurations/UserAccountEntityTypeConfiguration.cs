using HciMedico.Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HciMedico.Library.Models.Enums;

namespace HciMedico.Library.Data.Configurations
{
    public class UserAccountEntityTypeConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.HasData(
                new UserAccount
                {
                    Id = 1,
                    Username = "marko.petrovic1",
                    Password = "eESUiBPJLQ/s4CMXRZ6QZgXE2k/VbM5+QC1XNdpR7TA=",
                    EmployeeId = 1,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 2,
                    Username = "ana.jovanovic2",
                    Password = "tmh4kL6Kj+aAlli2JuVvxEwfM+DCo7K+zV7Nb+NzXgk=",
                    EmployeeId = 2,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 3,
                    Username = "nikola.stojanovic3",
                    Password = "rb9ClnCFci1dATS1bF1fKPW+dK9VIQYENH3QobXmkFM=",
                    EmployeeId = 3,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 4,
                    Username = "milan.popovic4",
                    Password = "8vc5vplkQcG0tCR4dhcHgO/gibJLWFkJsZsfpwHum60=",
                    EmployeeId = 4,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 5,
                    Username = "jovana.nikolic5",
                    Password = "Z7TOhn2+TphnOSCh69fEszh7HYrJ1rsEVfIbfXjvGfs=",
                    EmployeeId = 5,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 6,
                    Username = "stefan.ilic6",
                    Password = "EHP0K4G7nZESTMC8QObiSUAsjUCpHQL3waqFYr/bs/0=",
                    EmployeeId = 6,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 7,
                    Username = "marija.pavlovic7",
                    Password = "Kj3uvEwBgBUH63vjqg/31Mif4W161bEyv+yAc4wCLqU=",
                    EmployeeId = 7,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 8,
                    Username = "aleksandar.djordjevic8",
                    Password = "lHxoiDJxD0YhPdDWPmEdiY6ZxgJBpbvbvECh749kSK8=",
                    EmployeeId = 8,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 9,
                    Username = "ana.jankovic9",
                    Password = "ABIgJbyqGzRdpXNDVu5VX29suSgUHmDhscYOcEp1pL4=",
                    EmployeeId = 9,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 10,
                    Username = "petar.stankovic10",
                    Password = "MiPz131hmHi1XpC0SaTuD2f4MpuDrlms7dnlrCuAHIM=",
                    EmployeeId = 10,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 11,
                    Username = "jelena.petrovic11",
                    Password = "sJaf1zIZn9LbgAYmXpDLmLEHxD4QI8/4dvQ4nrV7hg8=",
                    EmployeeId = 11,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 12,
                    Username = "dragan.kovacevic12",
                    Password = "/cKh+rVsE99W5bIs4PCMq8iy7pYuB1wVIDsVdqFjkrI=",
                    EmployeeId = 12,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 13,
                    Username = "milica.ivanovic13",
                    Password = "ePuTCLRUZoEFNlTlWHY5ZNunTltyviJECsqld+VeTQk=",
                    EmployeeId = 13,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 14,
                    Username = "nemanja.jovic14",
                    Password = "me8plQoA6wDHr6tOT5WDGd0CRol502zeZ01WD123vnw=",
                    EmployeeId = 14,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 15,
                    Username = "mina.pavlovic15",
                    Password = "oyp8I0a1DoQTCxH0iIuOb80DA7PGCsAJhsJLCtFVqqU=",
                    EmployeeId = 15,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 16,
                    Username = "vladimir.stanisic16",
                    Password = "KG0SiGyv73f4er6WDUKTcvNvwZLEgpcI4/PZVgH+DZk=",
                    EmployeeId = 16,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 17,
                    Username = "jovanka.djordjevic17",
                    Password = "Q9ULJHow9ABdRGP7u36vw2xrrapWSVjgixrVWyv8DQQ=",
                    EmployeeId = 17,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 18,
                    Username = "branimir.nikolic18",
                    Password = "+7il6G6rCI6QNidGnW/vQGFNFLPc3ihiCKrnqFOTOJ4=",
                    EmployeeId = 18,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 19,
                    Username = "ana.jankovic19",
                    Password = "KpW3sAeAwyaI0prN0DKRtsoWnb2Z7tbVniVAI6Izxi4=",
                    EmployeeId = 19,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 20,
                    Username = "nikola.stankovic20",
                    Password = "Uow46Y+l3Ay/hRyEmlNugioCnnhT2IuPjaaG75BcTsE=",
                    EmployeeId = 20,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 21,
                    Username = "sanja.petrovic21",
                    Password = "yJKlI7xdCsM3JYHtjhvop04ADVrYkqOJ/hKGYMmh0/g=",
                    EmployeeId = 21,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 22,
                    Username = "milos.jovanovic22",
                    Password = "/UssdFSw0+558PMPhS1POSU2tjbPYtYOJzSA7XUOMog=",
                    EmployeeId = 22,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 23,
                    Username = "tatjana.stojanovic23",
                    Password = "44IGSFhstzcDUmhTe6M4Z/KssToE8tSy2vG6ggn81vY=",
                    EmployeeId = 23,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 24,
                    Username = "vladimir.stankovic24",
                    Password = "TF9XFyEy/WxKm0G+5Fhjpio5Oot7zIW2T/P2mNR2O9w=",
                    EmployeeId = 24,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 25,
                    Username = "ivana.jankovic25",
                    Password = "qBhnbx8tXbGK0rLRy39RNJIjMYX7SS06I8KnyTBtk9Q=",
                    EmployeeId = 25,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 26,
                    Username = "nenad.petrovic26",
                    Password = "MFuDfJosLdAjWwopTmnyr4pa6R3sCIlB/i16crTlROo=",
                    EmployeeId = 26,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 27,
                    Username = "milica.ilic27",
                    Password = "COFH5IWyq4cYSnX1abXsHr4FZQqq7RrZUVLZHTSRLUo=",
                    EmployeeId = 27,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 28,
                    Username = "vladan.djordjevic28",
                    Password = "Py/RFAy3B6i2ANiwPdVkqaQJakpjkKCJjSV/1TSoU7s=",
                    EmployeeId = 28,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 29,
                    Username = "sara.pavlovic29",
                    Password = "Go3RakYLQ/g8ovKyoT5R1XJYRMkhqPz+zV/C8gVYu5E=",
                    EmployeeId = 29,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 30,
                    Username = "nemanja.stanisic30",
                    Password = "ROPw0GUTGxouB4+yWRVtk29BUILTT3IrnsnySVt0NDY=",
                    EmployeeId = 30,
                    UserRole = UserRole.Doctor
                },
                new UserAccount
                {
                    Id = 31,
                    Username = "ksenija.markovic31",
                    Password = "7nJpngTuuD72k1l646OxwdyvNyt/+/5ZxSgxsS8z/Jc=",
                    EmployeeId = 31,
                    UserRole = UserRole.CounterWorker
                },
                new UserAccount
                {
                    Id = 32,
                    Username = "milica.simeunovic32",
                    Password = "GtcieDv+kU/Lq8kwEiDOV/U7QM+yZLIEMhy0dRz0kIo=",
                    EmployeeId = 32,
                    UserRole = UserRole.CounterWorker
                },
                new UserAccount
                {
                    Id = 33,
                    Username = "petar.tomic33",
                    Password = "MuNTgCJTqvnDqtV14+v7IGgmIA6jNXfKTELBcxB4ECI=",
                    EmployeeId = 33,
                    UserRole = UserRole.CounterWorker
                },
                new UserAccount
                {
                    Id = 34,
                    Username = "ana.jovanovic34",
                    Password = "s6iZf5LkTbE3sAyW5eVBboT5bdMVwmdk1C9cELCfX/w=",
                    EmployeeId = 34,
                    UserRole = UserRole.CounterWorker
                }
            );
        }
    }
}
