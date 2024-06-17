using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class ValidPhoneNumberTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "+38766123456" };
        yield return new object[] { "066345987" };
        yield return new object[] { "06512436723" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
