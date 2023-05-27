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
        //nothing since teams is the first data seeded
        //testing to ensure that every entry is unique

        //act
        DbUpdateService.SeedTeams(_context);
        var teams = _context.Teams
            .Select(t => new {t.Name , t.Location})
            .Distinct();

        //Assert
        Assert.Equal(_context.Teams.Count(), teams.Count());
    }

    [Fact]
    public void SeedPlayerTests()
    {
        //arrange
        DbUpdateService.SeedTeams(_context);

        //act
        DbUpdateService.SeedPlayers(_context);

        //testing to make sure players were not entered twice under dif ID's
        var players = _context.Players
            .Select(p => new {p.DisplayName , p.HeadshotHref, p.TeamId})
            .Distinct();
        //Assert
        Assert.Equal(_context.Players.Count(), players.Count());
    }


    [Fact]
    public void SeedGameTests()
    {
        //arrange
        DbUpdateService.SeedTeams(_context);
        DbUpdateService.SeedPlayers(_context);

        //act
        DbUpdateService.SeedGames(_context);

        //testing to make sure players were not entered twice under dif ID's
        var games = _context.Games
            .Select(g => new {g.GameDateTime , g.GameDate, g.HomeTeamId})
            .Distinct();
        //Assert
        Assert.Equal(_context.Games.Count(), games.Count());
    }
}