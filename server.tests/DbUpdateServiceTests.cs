namespace server.tests;

using server.Services;
using server.Data;
public class UserServiceTests : IClassFixture<TestFixture>
{
    private readonly AppDbContext _context;
    private readonly string _teamPath = "../../../Content/team_box.csv";
    private readonly string _playerPath = "../../../Content/player_box.csv";

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
        DbUpdateService.SeedTeams(_context, _teamPath);
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
        DbUpdateService.SeedTeams(_context, _teamPath);

        //act
        DbUpdateService.SeedPlayers(_context, _playerPath);

        //testing to make sure players were not entered twice under dif ID's
        var players = _context.Players
            .Select(p => new {p.DisplayName , p.HeadshotHref, p.TeamId})
            .Distinct();
        //Assert
        Assert.Equal(_context.Players.Count(), players.Count());
    }


    [Fact]
    [Obsolete]
    public void SeedGameTests()
    {
        //arrange
        DbUpdateService.SeedTeams(_context, _teamPath);
        DbUpdateService.SeedPlayers(_context, _playerPath);

        //act
        DbUpdateService.SeedGames(_context, _teamPath);

        //testing to make sure players were not entered twice under dif ID's
        var games = _context.Games
            .Select(g => new {g.GameDateTime, g.HomeTeamId})
            .Distinct();
        //Assert
        Assert.Equal(_context.Games.Count(), games.Count());
    }

    [Fact]
    public void SeedGameFastTests()
    {
        //arrange
        DbUpdateService.SeedTeams(_context, _teamPath);
        DbUpdateService.SeedPlayers(_context, _playerPath);

        //act
        DbUpdateService.SeedGamesFast(_context, _teamPath);
        var firstPass = _context.Games.Count();
        DbUpdateService.SeedGamesFast(_context, _teamPath);
        var secondPass = _context.Games.Count();

        var games = _context.Games
            .Select(g => new {g.GameDateTime , g.HomeTeamId})
            .Distinct();
        //Assert
        Assert.Equal(_context.Games.Count(), games.Count());
        Assert.Equal(firstPass, secondPass);
        
    }

    [Fact]
    public void SeedTeamBoxTests()
    {
        //arrange
        DbUpdateService.SeedTeams(_context, _teamPath);
        DbUpdateService.SeedPlayers(_context, _playerPath);
        DbUpdateService.SeedGamesFast(_context, _teamPath);

        //act
        DbUpdateService.SeedTeamBoxScores(_context, _teamPath);

        var total = _context.TeamBoxes.Count();
        var teamBoxes = _context.TeamBoxes
            .GroupBy(tb => new {tb.TeamId, tb.GameId})
            .Select(group => group.First());
        //var count = teamBoxes.Count();
        //Assert
        Assert.Equal(_context.TeamBoxes.Count(), teamBoxes.Count());
    }

    [Fact]
    public void SeedPlayerBoxTests()
    {
        //arrange
        DbUpdateService.SeedTeams(_context, _teamPath);
        DbUpdateService.SeedPlayers(_context, _playerPath);
        DbUpdateService.SeedGamesFast(_context, _teamPath);
        DbUpdateService.SeedTeamBoxScores(_context, _teamPath);
        //act
        DbUpdateService.SeedPlayerBoxScores(_context, _playerPath);

        //testing to make sure players were not entered twice under dif ID's
        var playerBoxes = _context.PlayerBoxes
            .GroupBy(pb => new {pb.PlayerId, pb.GameId})
            .Select(group => group.First());    
        //Assert
        Assert.Equal(_context.PlayerBoxes.Count(), playerBoxes.Count());
    }

    [Fact]
    public void QueryTeamBoxesFromTeamsTests()
    {
        
        DbUpdateService.SeedTeams(_context, _teamPath);
        DbUpdateService.SeedPlayers(_context, _playerPath);
        DbUpdateService.SeedGamesFast(_context, _teamPath);
        DbUpdateService.SeedTeamBoxScores(_context, _teamPath);
        //DbUpdateService.SeedPlayerBoxScores(_context);

        //testing to make sure players were not entered twice under dif ID's
        var team = _context.Teams.Include(t => t.TeamBoxes).First();
        var teamBoxes = team.TeamBoxes;
        //Assert
        Assert.NotNull(teamBoxes);
    }
}