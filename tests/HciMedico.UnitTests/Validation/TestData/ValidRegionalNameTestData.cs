using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class ValidRegionalNameTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "Bosnia and Herzegovina" };
        yield return new object[] { "Srbija" };
        yield return new object[] { "Hrvatska" };
        yield return new object[] { "Češka" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
