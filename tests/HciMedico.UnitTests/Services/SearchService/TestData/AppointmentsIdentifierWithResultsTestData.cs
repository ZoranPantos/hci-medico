using HciMedico.Domain.Models;
using System.Collections;

namespace HciMedico.UnitTests.Services.SearchService.TestData;

public class AppointmentsIdentifierWithResultsTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            "Lana Pepić",
            new List<Appointment>()
            {
                new() { IdentifierName = "Lana Pepić", Patient = null },
                new() { IdentifierName = "Boris Borisavljević", Patient = null },
                new() { IdentifierName = "Jovana Jovanović", Patient = null },
                new() { Patient = new() { FirstName = "Nikola", LastName = "Nikolić" } },
                new() { Patient = new() { FirstName = "Milana", LastName = "Milanović" } },
                new() { Patient = new() { FirstName = "Stana", LastName = "Stanojević" } }
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
