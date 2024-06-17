using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class InvalidRegionalNameTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "Bosnia   and  Herzegovina" };
        yield return new object[] { "6Serbia" };
        yield return new object[] { "%hrvatska" };
        yield return new object[] { " a" };
        yield return new object[] { "a " };
        yield return new object[] { "555" };
        yield return new object[] { "a-" };
        yield return new object[] { "a_" };
        yield return new object[] { "a+" };
        yield return new object[] { "-a" };
        yield return new object[] { "$k" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
