using server.Data;

namespace server.Services;

public class PlayerStatsService
{

    private readonly AppDbContext _db;
    public PlayerStatsService(AppDbContext db)
    {
        _db = db;
    }

    public IEnumerable<Player> GetTopScorersAsync(int teamId)
    {
        return _db.Players.Where(player => player.TeamId == teamId).OrderBy(Player => Player.PlayerBoxes.Select(box => box.Points)).ToList();
    }

    // public Player GetSeasonalAveragePoints(int playerId)
    // {
    //     var totalPoints = _db.Players.Where(player => player.PlayerId == playerId).Select(player => player.PlayerBoxes.Select(box => box.Points));
    //     var totalGames = _db.Players.Where(player => player.PlayerId == playerId).Select(player => player.PlayerBoxes.Select(box => box.Game)).Count();
    //     var seasonAvg = totalPoints / totalPoints;
    // }
}