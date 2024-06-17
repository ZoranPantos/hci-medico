using System.Collections;

namespace HciMedico.UnitTests.Validation.TestData;

public class ValidPersonNameTestData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { "Aleksandar" };
        yield return new object[] { "Čedomir" };
        yield return new object[] { "Nataša" };
        yield return new object[] { "Бојана" };
        yield return new object[] { "Светлана" };
        yield return new object[] { "Дмитрий" };
        yield return new object[] { "Анастасия" };
        yield return new object[] { "Ирина" };
        yield return new object[] { "DuBois" };
        yield return new object[] { "Ó Súilleabháin" };
        yield return new object[] { "Yamaguchi" };
        yield return new object[] { "Dlamini-Mandela" };
        yield return new object[] { "García y Pérez" };
        yield return new object[] { "Silva e Souza" };
        yield return new object[] { "Farahani-Tehrani" };
        yield return new object[] { "Xia" };
        yield return new object[] { "Yàn" };
        yield return new object[] { "Zhēn" };
        yield return new object[] { "Petrović" };
        yield return new object[] { "Милановић" };
        yield return new object[] { "Skłodowska-Curie" };
        yield return new object[] { "Silva e Souza" };
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
