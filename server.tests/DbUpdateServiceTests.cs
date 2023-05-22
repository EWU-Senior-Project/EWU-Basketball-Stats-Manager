namespace server.tests;

using server.Services;
using server.Data;
public class UserServiceTests : IClassFixture<TestFixture>
{
    private readonly AppDbContext _context;

    public UserServiceTests(TestFixture fixture)
    {
        _context = fixture.DbContext;
    }

    [Fact]
    public void SeedTeamsTests()
    {
        //arrange
        //nothing since the method is static

        //act
        DbUpdateService.SeedTeams(_context);
        var teams = _context.Teams
            .Select(t => new {t.Name , t.Location})
            .Distinct();

        //Assert
        Assert.Equal(_context.Teams.Count(), teams.Count());
    }
}