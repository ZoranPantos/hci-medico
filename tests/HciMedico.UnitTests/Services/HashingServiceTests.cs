using HciMedico.UnitTests.Services.TestData;
using Xunit.Abstractions;

namespace HciMedico.UnitTests.Services;

public class HashingServiceTests : IClassFixture<HashingServiceFixture>
{
    private readonly HashingServiceFixture _fixture;
    private readonly ITestOutputHelper _output;

    public HashingServiceTests(HashingServiceFixture fixture, ITestOutputHelper output)
    {
        _fixture = fixture;
        _output = output;
    }

    [Theory]
    [ClassData(typeof(ValidHashTestData))]
    public void ValidHashTest(string input, string hash)
    {
        string actual = _fixture.HashingService.GetHashString(input);

        _output.WriteLine($"Input: {input} | Expected: {true} | Actual: {actual}");

        Assert.Equal(hash, actual);
    }

    [Theory]
    [ClassData(typeof(InvalidHashTestData))]
    public void InvalidHashTest(string input, string hash)
    {
        string actual = _fixture.HashingService.GetHashString(input);

        _output.WriteLine($"Input: {input} | Expected: {false} | Actual: {actual}");

        Assert.NotEqual(hash, actual);
    }
}
