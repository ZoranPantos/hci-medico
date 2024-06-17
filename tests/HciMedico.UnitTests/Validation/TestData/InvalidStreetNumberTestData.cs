using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class InvalidStreetNumberTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { " 1" };
        yield return new object[] { "99 " };
        yield return new object[] { "9 9" };
        yield return new object[] { "AA9" };
        yield return new object[] { "5BB" };
        yield return new object[] { "6c c" };
        yield return new object[] { "$12" };
        yield return new object[] { "1#" };
        yield return new object[] { "c" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
