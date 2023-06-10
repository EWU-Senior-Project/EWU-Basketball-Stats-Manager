namespace server.tests;

using server.Services;
using server.Data;
public class SeasonServiceTests : IClassFixture<TestFixture>
{
    private readonly AppDbContext _context;
    private readonly string _teamPath = "../../../Content/team_box.csv";
    private readonly string _playerPath = "../../../Content/player_box.csv";

    public SeasonServiceTests(TestFixture fixture)
    {
        _context = fixture.DbContext;
    }

    [Fact]
    public void UpdatePlayerSeasonStats()
    {   
        var updateService = new DbUpdateService(_context);
        var seasonService = new SeasonService(_context);
        var seasonStatService = new SeasonStatsService(_context);

        updateService.SeedDb(_teamPath, _playerPath);

        var seasonStats = _context.Players 
                .Any(p => p.PlayerSeasonStats.Any(ss => ss.GamesPlayed == 0));
        
        var seasons = _context.Games.Where(g => g.Season.SeasonString == "2021-2022");
        var count = seasons.Count();
        var players = _context.Players.Include(p => p.PlayerSeasonStats);

        var list = _context.Seasons.ToList();

        Assert.False(seasonStats);
        Assert.Equal(seasons.Count(), _context.Games.Count());
    }


}