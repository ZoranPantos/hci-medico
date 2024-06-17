using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class ValidStreetNumberTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "1" };
        yield return new object[] { "99" };
        yield return new object[] { "A9" };
        yield return new object[] { "5B" };
        yield return new object[] { "6c" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
