namespace HciMedico.UnitTests.Services.SearchService;

public class SearchServiceFixture
{
    public App.Services.SearchService SearchService { get; private set; }

    public SearchServiceFixture() => SearchService = new();
}
