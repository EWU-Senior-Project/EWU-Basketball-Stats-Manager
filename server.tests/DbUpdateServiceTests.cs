namespace server.tests;

using server.Services;
using server.Data;
public class DbUpdateServiceTests : IClassFixture<TestFixture>
{
    private readonly AppDbContext _context;
    private readonly string _teamPath = "../../../Content/team_box.csv";
    private readonly string _playerPath = "../../../Content/player_box.csv";

    public DbUpdateServiceTests(TestFixture fixture)
    {
        _context = fixture.DbContext;
    }

    [Fact]
    public void SeedTeamsTests()
    {
        //arrange
        var updateService = new DbUpdateService(_context);
        
        //act
        updateService.SeedTeams(_teamPath);
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
        var updateService = new DbUpdateService(_context);
        updateService.SeedTeams( _teamPath);

        //act
        updateService.SeedPlayers( _playerPath);

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
        var updateService = new DbUpdateService(_context);
        var seasonService = new SeasonService(_context);
        seasonService.SeedSeasons();
        updateService.SeedTeams( _teamPath);
        updateService.SeedPlayers(_playerPath);

        //act
        updateService.SeedGames(_teamPath);

        //testing to make sure players were not entered twice under dif ID's
        var games = _context.Games
            .Select(g => new {g.GameDateTime, g.HomeTeamId})
            .Distinct();

        var seasons = _context.Games.Any(g => g.SeasonId == null);
        //Assert
        Assert.False(seasons);
        Assert.Equal(_context.Games.Count(), games.Count());
    }

    [Fact]
    public void SeedGameFastTests()
    {
        //arrange
        var updateService = new DbUpdateService(_context);
        var seasonService = new SeasonService(_context);
        seasonService.SeedSeasons();
        updateService.SeedTeams( _teamPath);
        updateService.SeedPlayers(_playerPath);

        //act
        updateService.SeedGamesFast( _teamPath);
        var firstPass = _context.Games.Count();
        updateService.SeedGamesFast(_teamPath);
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
        var updateService = new DbUpdateService(_context);
        var seasonService = new SeasonService(_context);
        seasonService.SeedSeasons();
        updateService.SeedTeams(  _teamPath);
        updateService.SeedPlayers(  _playerPath);
        updateService.SeedGamesFast(  _teamPath);

        //act
        updateService.SeedTeamBoxScores(  _teamPath);

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
        var updateService = new DbUpdateService(_context);
        var seasonService = new SeasonService(_context);
        seasonService.SeedSeasons();
        updateService.SeedTeams(  _teamPath);
        updateService.SeedPlayers(  _playerPath);
        updateService.SeedGamesFast(  _teamPath);
        updateService.SeedTeamBoxScores(  _teamPath);
        //act
        updateService.SeedPlayerBoxScores(  _playerPath);

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
        var updateService = new DbUpdateService(_context);
        var seasonService = new SeasonService(_context);
        seasonService.SeedSeasons();
        updateService.SeedTeams(  _teamPath);
        updateService.SeedPlayers(  _playerPath);
        updateService.SeedGamesFast(  _teamPath);
        updateService.SeedTeamBoxScores(  _teamPath);
        //DbUpdateService.SeedPlayerBoxScores(_context);

        //testing to make sure players were not entered twice under dif ID's
        var team = _context.Teams.Include(t => t.TeamBoxes).First();
        var teamBoxes = team.TeamBoxes;
        //Assert
        Assert.NotNull(teamBoxes);
    }
}