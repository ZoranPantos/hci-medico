using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class ValidDateOfBirthTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { DateTime.Today };
        yield return new object[] { DateTime.Today.AddDays(-1) };
        yield return new object[] { new DateTime(1920, 1, 1) };
        yield return new object[] { new DateTime(1920, 1, 2) };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
