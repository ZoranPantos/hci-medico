using HciMedico.App.Validation;

namespace HciMedico.UnitTests.Validation;

public class InputValidatorFixture
{
    public InputValidator InputValidator { get; private set; }

    public InputValidatorFixture() => InputValidator = new();
}
