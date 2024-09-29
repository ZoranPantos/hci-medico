namespace HciMedico.UnitTests.Services.SearchService;

public class SearchServiceFixture
{
    public App.Services.Classes.SearchService SearchService { get; private set; }

    public SearchServiceFixture() => SearchService = new();
}
