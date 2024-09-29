namespace HciMedico.UnitTests.Services.HashingService;

public class HashingServiceFixture
{
    public App.Services.Classes.HashingService HashingService { get; private set; }

    public HashingServiceFixture() => HashingService = new();
}
