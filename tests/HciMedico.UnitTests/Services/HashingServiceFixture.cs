using HciMedico.App.Services;

namespace HciMedico.UnitTests.Services;

public class HashingServiceFixture
{
    public HashingService HashingService { get; private set; }

    public HashingServiceFixture() => HashingService = new();
}
