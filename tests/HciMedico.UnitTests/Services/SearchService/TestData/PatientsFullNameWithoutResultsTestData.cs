﻿using HciMedico.Domain.Models;
using System.Collections;

namespace HciMedico.UnitTests.Services.SearchService.TestData;

public class PatientsFullNameWithoutResultsTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            "Predrag Stojanović",
            new List<Patient>()
            {
                new() { FirstName = "Ana", LastName = "Stanojević" },
                new() { FirstName = "Boris", LastName = "Borisavljević" },
                new() { FirstName = "Jovana", LastName = "Jovanović" },
                new() { FirstName = "Nikola", LastName = "Nikolić" },
                new() { FirstName = "Milana", LastName = "Milanović" },
                new() { FirstName = "Stana", LastName = "Stanojević" }
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
