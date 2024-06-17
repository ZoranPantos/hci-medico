using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class ValidEmailTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "test@test.com" };
        yield return new object[] { "drhouse@gmail.com" };
        yield return new object[] { "sky@news.net" };
        yield return new object[] { "123@321.com" };
        yield return new object[] { "test96@test.com" };
        yield return new object[] { "te2st@test.com" };
        yield return new object[] { "1teABCst@test.com" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
