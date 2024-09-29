using HciMedico.Domain.Models.Entities;
using HciMedico.UnitTests.Services.SearchService.TestData;
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
        OutputPatientTargetSet(targetSet);
        OutputPatientSearchResults(1, resultSet);

        Assert.Equal(1, resultSet?.Count);
        resultSet?.ForEach(result => Assert.Equal(firstName.ToLower(), result.FirstName.ToLower()));
    }

    [Theory]
    [ClassData(typeof(PatientsLastNameWithResultsTestData))]
    public void SearchMatchingPatientByLastNameTest(string lastName, List<Patient> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchPatients(targetSet, lastName);

        _output.WriteLine($"Input key: {lastName}");
        OutputPatientTargetSet(targetSet);
        OutputPatientSearchResults(2, resultSet);

        Assert.Equal(2, resultSet?.Count);
        resultSet?.ForEach(result => Assert.Equal(lastName.ToLower(), result.LastName.ToLower()));
    }

    [Theory]
    [ClassData(typeof(PatientsFullNameWithResultsTestData))]
    public void SearchMatchingPatientByFullNameTest(string fullName, List<Patient> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchPatients(targetSet, fullName);

        _output.WriteLine($"Input key: {fullName}");
        OutputPatientTargetSet(targetSet);
        OutputPatientSearchResults(1, resultSet);

        Assert.Equal(1, resultSet?.Count);
        resultSet?.ForEach(result => Assert.Equal(fullName.ToLower(), result.FullName.ToLower()));
    }

    [Theory]
    [ClassData(typeof(PatientsFullNameWithoutResultsTestData))]
    public void SearchMatchingPatientByFullNameInNotContainingSetTest(string fullName, List<Patient> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchPatients(targetSet, fullName);

        _output.WriteLine($"Input key: {fullName}");
        OutputPatientTargetSet(targetSet);
        OutputPatientSearchResults(0, resultSet);

        Assert.Equal(0, resultSet?.Count);
    }

    [Theory]
    [ClassData(typeof(AppointmentsFirstNameWithResultsTestData))]
    public void SearchMatchingAppointmentByFirstNameTest(string firstName, List<Appointment> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchTrendingAppointments(targetSet, firstName);

        _output.WriteLine($"Input key: {firstName}");
        OutputAppointmentTargetSet(targetSet);
        OutputAppointmentSearchResults(1, resultSet);

        Assert.Equal(1, resultSet?.Count);

        foreach (var result in resultSet ?? [])
        {
            if (!string.IsNullOrEmpty(result.IdentifierName))
            {
                //TODO: Not good test - identifier can be anything and in any order; Rewrite

                string identifierFirstName = result.IdentifierName.Split(" ")[0].ToLower();

                Assert.Equal(firstName.ToLower(), identifierFirstName);
            }
            else if (result.Patient is not null)
                Assert.Equal(firstName.ToLower(), result.Patient.FirstName.ToLower());
        }
    }

    [Theory]
    [ClassData(typeof(AppointmentsLastNameWithResultsTestData))]
    public void SearchMatchingAppointmentByLastNameTest(string lastName, List<Appointment> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchTrendingAppointments(targetSet, lastName);

        _output.WriteLine($"Input key: {lastName}");
        OutputAppointmentTargetSet(targetSet);
        OutputAppointmentSearchResults(2, resultSet);

        Assert.Equal(2, resultSet?.Count);

        foreach (var result in resultSet ?? [])
        {
            if (!string.IsNullOrEmpty(result.IdentifierName))
            {
                //TODO: Not good test - identifier can be anything and in any order; Rewrite

                string identifierFirstName = result.IdentifierName.Split(" ")[0].ToLower();

                Assert.Equal(lastName.ToLower(), identifierFirstName);
            }
            else if (result.Patient is not null)
                Assert.Equal(lastName.ToLower(), result.Patient.LastName.ToLower());
        }
    }

    [Theory]
    [ClassData(typeof(AppointmentsFullNameWithResultsTestData))]
    public void SearchMatchingAppointmentByFullNameTest(string fullName, List<Appointment> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchTrendingAppointments(targetSet, fullName);

        _output.WriteLine($"Input key: {fullName}");
        OutputAppointmentTargetSet(targetSet);
        OutputAppointmentSearchResults(1, resultSet);

        Assert.Equal(1, resultSet?.Count);

        foreach (var result in resultSet ?? [])
        {
            if (!string.IsNullOrEmpty(result.IdentifierName))
            {
                //TODO: Not good test - identifier can be anything and in any order; Rewrite

                string identifierFirstName = result.IdentifierName.Split(" ")[0].ToLower();

                Assert.Equal(fullName.ToLower(), identifierFirstName);
            }
            else if (result.Patient is not null)
                Assert.Equal(fullName.ToLower(), result.Patient.FullName.ToLower());
        }
    }

    [Theory]
    [ClassData(typeof(AppointmentsIdentifierWithResultsTestData))]
    public void SearchMatchingAppointmentByIdentifierTest(string identifier, List<Appointment> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchTrendingAppointments(targetSet, identifier);

        _output.WriteLine($"Input key: {identifier}");
        OutputAppointmentTargetSet(targetSet);
        OutputAppointmentSearchResults(1, resultSet);

        Assert.Equal(1, resultSet?.Count);

        foreach (var result in resultSet ?? [])
        {
            if (!string.IsNullOrEmpty(result.IdentifierName))
            {
                //TODO: Not good test - identifier can be anything and in any order; Rewrite
                string identifierFirstName = result.IdentifierName.ToLower();
                Assert.Equal(identifier.ToLower(), identifierFirstName);
            }
        }
    }

    [Theory]
    [ClassData(typeof(AppointmentsFullNameWithoutResultsTestData))]
    public void SearchMatchingAppointmentByFullNameInNotContainingSetTest(string fullName, List<Appointment> targetSet)
    {
        var resultSet = _fixture.SearchService.SearchTrendingAppointments(targetSet, fullName);

        _output.WriteLine($"Input key: {fullName}");
        OutputAppointmentTargetSet(targetSet);
        OutputAppointmentSearchResults(0, resultSet);

        Assert.Equal(0, resultSet?.Count);
    }

    private void OutputPatientTargetSet(List<Patient> targetSet)
    {
        _output.WriteLine("Target set:");
        targetSet.ForEach(patient => _output.WriteLine($"    {patient.FullName}"));
        _output.WriteLine("-----------------------------------------");
    }

    private void OutputPatientSearchResults(int expectedCount, List<Patient>? results)
    {
        _output.WriteLine($"Expected result count: {expectedCount} | Actual result count: {results?.Count}");
        _output.WriteLine("Results:");

        results?.ForEach(patient => _output.WriteLine($"    {patient.FullName}"));
        _output.WriteLine("-----------------------------------------");
    }

    private void OutputAppointmentTargetSet(List<Appointment> targetSet)
    {
        _output.WriteLine("Target set:");

        foreach (var target in targetSet)
        {
            if (!string.IsNullOrEmpty(target.IdentifierName))
                _output.WriteLine($"    {target.IdentifierName}");
            else if (target.Patient is not null)
                _output.WriteLine($"    {target.Patient.FullName}");
        }

        _output.WriteLine("-----------------------------------------");
    }

    private void OutputAppointmentSearchResults(int expectedCount, List<Appointment>? results)
    {
        _output.WriteLine($"Expected result count: {expectedCount} | Actual result count: {results?.Count}");
        _output.WriteLine("Results:");

        foreach (var result in results)
        {
            if (!string.IsNullOrEmpty(result.IdentifierName))
                _output.WriteLine($"    {result.IdentifierName}");
            else if (result.Patient is not null)
                _output.WriteLine($"    {result.Patient.FullName}");
        }

        _output.WriteLine("-----------------------------------------");
    }
}
