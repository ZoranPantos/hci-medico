using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class InvalidEmailTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { " test@test.com" };
        yield return new object[] { "test@test.com " };
        yield return new object[] { " test@test.com " };
        yield return new object[] { "te st@test.com" };
        yield return new object[] { "test@test..com" };
        yield return new object[] { "test@test,com" };
        yield return new object[] { "testtest.com" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
