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

    public IEnumerable<Player> GetTopScorersByTeamId(int teamId)
    {
        var playersByTeamId = _db.Players.Where(player => player.TeamId == teamId);
        var playerList = playersByTeamId.ToArray();
        var playersSeasonalAvgList = new List<PlayerSeasonalAvgPoints>();
        foreach (Player player in playerList)
        {
            playersSeasonalAvgList.Add(GetSeasonalAveragePoints(player.PlayerId));
        }
        var queryableList = playersSeasonalAvgList.AsQueryable();
        return GetPlayersByIds(queryableList.OrderBy(player => player.seasonalAvgPoints).Select(player => player.playerId).Take(5).ToList());
    }

    private PlayerSeasonalAvgPoints GetSeasonalAveragePoints(int playerId)
    {
        var totalPoints = _db.Players.Where(player => player.PlayerId == playerId).Select(player => player.PlayerBoxes.Select(box => box.Points)).First().First();
        var totalGames = _db.Players.Where(player => player.PlayerId == playerId).Select(player => player.PlayerBoxes.Select(box => box.Game)).Count();
        var playerSeasonalAvgPoints = new PlayerSeasonalAvgPoints();
        playerSeasonalAvgPoints.playerId = playerId;
        playerSeasonalAvgPoints.seasonalAvgPoints = totalPoints / totalGames;
        return playerSeasonalAvgPoints;
    }

    private List<Player> GetPlayersByIds(List<int> playerIds)
    {
        var players = new List<Player>();
        foreach (int playerId in playerIds)
        {
            players.Add(_db.Players.Where(player => player.PlayerId == playerId).First());
        }
        return players;
    }
}