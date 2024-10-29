using HciMedico.App.Validation;
using HciMedico.Domain.Models.Entities;
using HciMedico.Integration.Data.Repositories;
using Moq;

namespace HciMedico.UnitTests.Validation;

public class InputValidatorFixture
{
    public Mock<IRepository<Patient>> PatientsRepositoryMock = new();

    public InputValidator InputValidator { get; private set; }

    public InputValidatorFixture() => InputValidator = new(PatientsRepositoryMock.Object);
}
