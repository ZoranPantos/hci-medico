using HciMedico.UnitTests.Validation.TestData;
using Xunit.Abstractions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HciMedico.UnitTests.Validation;

public class InputValidatorTests : IClassFixture<InputValidatorFixture>
{
    private readonly InputValidatorFixture _fixture;
    private readonly ITestOutputHelper _output;

    public InputValidatorTests(InputValidatorFixture fixture, ITestOutputHelper output)
    {
        _fixture = fixture;
        _output = output;
    }

    [Theory]
    [ClassData(typeof(ValidPersonNameTestData))]
    public void ValidPersonNameTest(string name)
    {
        bool actual = _fixture.InputValidator.IsPersonNameValid(name);

        _output.WriteLine($"Input: {name} | Expected: {true} | Actual: {actual}");

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(InvalidPersonNameTestData))]
    public void InvalidPersonNameTest(string name)
    {
        bool actual = _fixture.InputValidator.IsPersonNameValid(name);

        _output.WriteLine($"Input: {name} | Expected: {false} | Actual: {actual}");

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(ValidUidTestData))]
    public void ValidUidTest(string uid)
    {
        bool actual = _fixture.InputValidator.IsUidValid(uid);

        _output.WriteLine($"Input: {uid} | Expected: {true} | Actual: {actual}");

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(InvalidUidTestData))]
    public void InvalidUidTest(string uid)
    {
        bool actual = _fixture.InputValidator.IsUidValid(uid);

        _output.WriteLine($"Input: {uid} | Expected: {false} | Actual: {actual}");

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(ValidEmailTestData))]
    public void ValidEmailTest(string email)
    {
        bool actual = _fixture.InputValidator.IsEmailValid(email);

        _output.WriteLine($"Input: {email} | Expected: {true} | Actual: {actual}");

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(InvalidEmailTestData))]
    public void InvalidEmailTest(string email)
    {
        bool actual = _fixture.InputValidator.IsEmailValid(email);

        _output.WriteLine($"Input: {email} | Expected: {false} | Actual: {actual}");

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(ValidDateOfBirthTestData))]
    public void ValidDateOfBirthTest(DateTime date)
    {
        bool actual = _fixture.InputValidator.IsDateOfBirthValid(date);

        _output.WriteLine($"Input: {date} | Expected: {true} | Actual: {actual}");

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(InvalidDateOfBirthTestData))]
    public void InvalidDateOfBirthTest(DateTime date)
    {
        bool actual = _fixture.InputValidator.IsDateOfBirthValid(date);

        _output.WriteLine($"Input: {date} | Expected: {false} | Actual: {actual}");

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(ValidStreetNumberTestData))]
    public void ValidStreetNumberTest(string streetNumber)
    {
        bool actual = _fixture.InputValidator.IsStreetNumberValid(streetNumber);

        _output.WriteLine($"Input: {streetNumber} | Expected: {true} | Actual: {actual}");

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(InvalidStreetNumberTestData))]
    public void InvalidStreetNumberTest(string streetNumber)
    {
        bool actual = _fixture.InputValidator.IsStreetNumberValid(streetNumber);

        _output.WriteLine($"Input: {streetNumber} | Expected: {false} | Actual: {actual}");

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(ValidRegionalNameTestData))]
    public void ValidRegionalNameTest(string regionalName)
    {
        bool actual = _fixture.InputValidator.IsRegionalNameValid(regionalName);

        _output.WriteLine($"Input: {regionalName} | Expected: {true} | Actual: {actual}");

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(InvalidRegionalNameTestData))]
    public void InvalidRegionalNameTest(string regionalName)
    {
        bool actual = _fixture.InputValidator.IsRegionalNameValid(regionalName);

        _output.WriteLine($"Input: {regionalName} | Expected: {false} | Actual: {actual}");

        Assert.False(actual);
    }

    [Theory]
    [ClassData(typeof(ValidPhoneNumberTestData))]
    public void ValidPhoneNumberTest(string phoneNumber)
    {
        bool actual = _fixture.InputValidator.IsPhoneNumberValid(phoneNumber);

        _output.WriteLine($"Input: {phoneNumber} | Expected: {true} | Actual: {actual}");

        Assert.True(actual);
    }

    [Theory]
    [ClassData(typeof(InvalidPhoneNumberTestData))]
    public void InvalidPhoneNumberTest(string phoneNumber)
    {
        bool actual = _fixture.InputValidator.IsPhoneNumberValid(phoneNumber);

        _output.WriteLine($"Input: {phoneNumber} | Expected: {false} | Actual: {actual}");

        Assert.False(actual);
    }
}
