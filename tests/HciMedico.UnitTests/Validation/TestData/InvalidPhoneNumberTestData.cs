using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class InvalidPhoneNumberTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "12312312312312a3123123" };
        yield return new object[] { "B" };
        yield return new object[] { "B1234" };
        yield return new object[] { "1234-1234" };
        yield return new object[] { "1234/1234" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}