using HciMedico.Domain.Models;
using HciMedico.UnitTests.Services.SearchService.TestData;
using System.Xml.Linq;
using Xunit.Abstractions;

namespace HciMedico.UnitTests.Services.SearchService;

public class SearchServiceTests : IClassFixture<SearchServiceFixture>
{
    private readonly SearchServiceFixture _fixture;
    private readonly ITestOutputHelper _output;

    public SearchServiceTests(SearchServiceFixture fixture, ITestOutputHelper output)
    {
        _fixture = fixture;
        _output = output;
    }

    [Theory]
    [ClassData(typeof(PatientsFirstNameWithResultsTestData))]
    public void SearchMatchingPatientByFirstNameTest(string firstName, List<Patient> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchPatients(targetSet, firstName);

        _output.WriteLine($"Input key: {firstName}");
        OutputTargetSet(targetSet);
        OutputSearchResults(1, resultSet);

        Assert.Equal(1, resultSet?.Count);
        resultSet?.ForEach(result => Assert.Equal(firstName.ToLower(), result.FirstName.ToLower()));
    }

    [Theory]
    [ClassData(typeof(PatientsLastNameWithResultsTestData))]
    public void SearchMatchingPatientByLastNameTest(string lastName, List<Patient> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchPatients(targetSet, lastName);

        _output.WriteLine($"Input key: {lastName}");
        OutputTargetSet(targetSet);
        OutputSearchResults(2, resultSet);

        Assert.Equal(2, resultSet?.Count);
        resultSet?.ForEach(result => Assert.Equal(lastName.ToLower(), result.LastName.ToLower()));
    }

    [Theory]
    [ClassData(typeof(PatientsFullNameWithResultsTestData))]
    public void SearchMatchingPatientByFullNameTest(string fullName, List<Patient> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchPatients(targetSet, fullName);

        _output.WriteLine($"Input key: {fullName}");
        OutputTargetSet(targetSet);
        OutputSearchResults(1, resultSet);

        Assert.Equal(1, resultSet?.Count);
        resultSet?.ForEach(result => Assert.Equal(fullName.ToLower(), result.FullName.ToLower()));
    }

    [Theory]
    [ClassData(typeof(PatientsFullNameWithoutResultsTestData))]
    public void SearchMatchingPatientByFullNameInNotContainingSet(string fullName, List<Patient> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchPatients(targetSet, fullName);

        _output.WriteLine($"Input key: {fullName}");
        OutputTargetSet(targetSet);
        OutputSearchResults(0, resultSet);

        Assert.Equal(0, resultSet?.Count);
    }

    private void OutputTargetSet(List<Patient> targetSet)
    {
        _output.WriteLine("Target set:");
        targetSet.ForEach(patient => _output.WriteLine($"    {patient.FullName}"));
        _output.WriteLine("-----------------------------------------");
    }

    private void OutputSearchResults(int expectedCount, List<Patient>? results)
    {
        _output.WriteLine($"Expected result count: {expectedCount} | Actual result count: {results?.Count}");
        _output.WriteLine("Results:");

        results?.ForEach(patient => _output.WriteLine($"    {patient.FullName}"));
        _output.WriteLine("-----------------------------------------");
    }
}
