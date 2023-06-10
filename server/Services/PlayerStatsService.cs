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
        var query = from p in _db.Players join b in _db.PlayerSeasonStats on p.PlayerId equals b.PlayerId into grouping from d in grouping.DefaultIfEmpty() orderby d.Points descending select new { d, p };
        var result = query.Where(e => e.p.TeamId == teamId).Select(e => new { e.p.Jersey, e.p.DisplayName, e.d.Points, e.d.FieldGoalsMade, e.d.FieldGoalsAttempted, e.d.GamesPlayed }).Take(5).ToList();

        var playerList = new List<PlayerDto>();

        foreach (var item in result)
        {
            var player = new PlayerDto();

            if (item.GamesPlayed != 0)
            {
                player.fgm = item.FieldGoalsMade / item.GamesPlayed;
                player.fga = item.FieldGoalsAttempted / item.GamesPlayed;
                player.pts = item.Points / item.GamesPlayed;
            }
            player.number = Int32.Parse(item.Jersey);
            player.name = item.DisplayName;

            if (item.FieldGoalsAttempted != 0)
            {
                player.fgp = Math.Round(((double)item.FieldGoalsMade / (double)item.FieldGoalsAttempted), 2);
            }

            playerList.Add(player);
        }

        return playerList;
    }
}