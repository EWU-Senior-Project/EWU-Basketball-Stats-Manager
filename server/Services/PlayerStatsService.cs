using server.Data;

namespace server.Services;

public class PlayerStatsService
{

    private readonly AppDbContext _db;
    public PlayerStatsService(AppDbContext db)
    {
        _db = db;
    }
    private class PlayerSeasonalAvgPoints
    {
        public int playerId { get; set; }
        public int seasonalAvgPoints { get; set; }
    }

    public IEnumerable<PlayerDto> GetTopScorersByTeamId(int teamId)
    {
        var team = _db.Teams.Where(team => team.TeamId == teamId);

        var players = team.Select(team => team.Players).ToList();

        var topScorers = new List<PlayerDto>();
        foreach (Player player in players)
        {
            IQueryable<Player> queryablePlayer = (IQueryable<Player>)player;
            PlayerDto topScorer = new PlayerDto();

            topScorer.number = Int32.Parse(queryablePlayer.Select(p => p.Jersey).First());
            topScorer.name = queryablePlayer.Select(p => p.DisplayName).First();
            topScorer.pts = queryablePlayer.Select(p => p.PlayerSeasonStats.Select(stat => stat.Points).First()).First();
            topScorer.fga = queryablePlayer.Select(p => p.PlayerSeasonStats.Select(stat => stat.FieldGoalsAttempted).First()).First();
            topScorer.fgm = queryablePlayer.Select(p => p.PlayerSeasonStats.Select(stat => stat.FieldGoalsMade).First()).First();
            topScorer.fgp = topScorer.fgm / topScorer.fga;

            // topScorer.number = 2;
            // topScorer.name = "hello";
            // topScorer.pts = 2;
            // topScorer.fga = 2;
            // topScorer.fgm = 2;
            // topScorer.fgp = 2;
        }
        return topScorers;
    }
}