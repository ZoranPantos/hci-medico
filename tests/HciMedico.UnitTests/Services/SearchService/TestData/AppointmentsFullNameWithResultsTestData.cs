using HciMedico.Domain.Models.Entities;
using System.Collections;

namespace HciMedico.UnitTests.Services.SearchService.TestData;

public class AppointmentsFullNameWithResultsTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            "Ana Stanojević",
            new List<Appointment>()
            {
                new() { Patient = new() { FirstName = "Ana", LastName = "Stanojević" } },
                new() { Patient = new() { FirstName = "Boris", LastName = "Borisavljević" } },
                new() { Patient = new() { FirstName = "Jovana", LastName = "Jovanović" } },
                new() { Patient = new() { FirstName = "Nikola", LastName = "Nikolić" } },
                new() { Patient = new() { FirstName = "Milana", LastName = "Milanović" } },
                new() { Patient = new() { FirstName = "Stana", LastName = "Stanojević" } }
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
