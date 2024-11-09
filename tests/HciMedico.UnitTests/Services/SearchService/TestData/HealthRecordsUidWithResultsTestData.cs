using HciMedico.Domain.Models.Entities;
using System.Collections;

namespace HciMedico.UnitTests.Services.SearchService.TestData;

public class HealthRecordsUidWithResultsTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            "1111111111111",
            new List<HealthRecord>()
            {
                new() { Patient = new() { Uid = "1111111111111" } },
                new() { Patient = new() { Uid = "1111111111112" } },
                new() { Patient = new() { Uid = "1111111111113" } },
                new() { Patient = new() { Uid = "1111111111114" } },
                new() { Patient = new() { Uid = "1111111111115" } },
                new() { Patient = new() { Uid = "1111111111116" } }
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}