using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class InvalidPersonNameTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { " Aleksandar" };
        yield return new object[] { "Aleksandar " };
        yield return new object[] { " Aleksandar " };
        yield return new object[] { "4Aleksandar" };
        yield return new object[] { "Aleksandar9" };
        yield return new object[] { "Aleks5andar" };
        yield return new object[] { "Aleksandar 5" };
        yield return new object[] { "1 Aleksandar" };
        yield return new object[] { "12345" };
        yield return new object[] { "+Aleksandar" };
        yield return new object[] { "Aleks£andar" };
        yield return new object[] { "Aleksandar#" };
        yield return new object[] { "Al$eksandar" };
        yield return new object[] { "Aleks%andar" };
        yield return new object[] { "Aleksan^dar" };
        yield return new object[] { "Aleksa&ndar" };
        yield return new object[] { "Aleksa*ndar" };
        yield return new object[] { "Aleksand(ar" };
        yield return new object[] { "Alek)sandar" };
        yield return new object[] { "Alek.sandar" };
        yield return new object[] { "Alek,sandar" };
        yield return new object[] { "Al¬eksandar" };
        yield return new object[] { "Aleksand\"ar" };
        yield return new object[] { "Ale_ksandar" };
        yield return new object[] { "=Aleksandar" };
        yield return new object[] { "Aleksand/ar" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
