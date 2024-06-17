using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class ValidUidTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "0000000000000" };
        yield return new object[] { "1234567891234" };
        yield return new object[] { "11111111" };
        yield return new object[] { "123123123123123123123" };
        yield return new object[] { "96539123942394923" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
