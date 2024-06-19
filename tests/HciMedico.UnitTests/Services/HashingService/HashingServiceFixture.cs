using HciMedico.App.Services;

namespace HciMedico.UnitTests.Services.HashingService;

public class HashingServiceFixture
{
    public App.Services.HashingService HashingService { get; private set; }

    public HashingServiceFixture() => HashingService = new();
}
