using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class InvalidDateOfBirthTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { DateTime.Now.AddDays(1) };
        yield return new object[] { new DateTime(1920, 1, 1).AddDays(-1) };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
