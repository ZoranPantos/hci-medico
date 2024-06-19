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
}
