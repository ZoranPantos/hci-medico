using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class InvalidUidTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { " 0000000000000" };
        yield return new object[] { "1234567891234 " };
        yield return new object[] { "1111 1111" };
        yield return new object[] { "12.3123123123123123123" };
        yield return new object[] { "96539,123942394923" };
        yield return new object[] { "96539,123942394923" };
        yield return new object[] { "96539a123942394923" };
        yield return new object[] { "96539123BB942394923" };
        yield return new object[] { "$965123942394923" };
        yield return new object[] { "5391239!42394923" };
        yield return new object[] { "9691239423949?23" };
        yield return new object[] { "965323+942394923" };
        yield return new object[] { "96-5391942394923" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
