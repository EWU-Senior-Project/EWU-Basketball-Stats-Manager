namespace server.tests;

using server.Services;
using server.Data;
public class SeasonServiceTests : IClassFixture<TestFixture>
{
    private readonly AppDbContext _context;

    public SeasonServiceTests(TestFixture fixture)
    {
        _context = fixture.DbContext;
    }

    [Fact]
    public void UpdateGamesSeasonTests()
    {   
              
    }


}