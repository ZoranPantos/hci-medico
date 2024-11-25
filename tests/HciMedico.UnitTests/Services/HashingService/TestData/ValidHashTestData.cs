﻿using System.Collections;

namespace HciMedico.UnitTests.Services.HashingService.TestData;

public class ValidHashTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "house", "1uIShmIahYb35Ucgq1o5yTrML0uPunoW7Bwk1poIxhM=" };
        yield return new object[] { "apple pineapple", "ILv9nTRy3X4TURIzH0/SzcpcxQ2Zb/2576FdANuYTpo=" };
        yield return new object[] { "cricket", "ETTk9KE7Bq6qhHH5NFiaPhgL8/5DLjLh+UVOdqkAd+c=" };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
