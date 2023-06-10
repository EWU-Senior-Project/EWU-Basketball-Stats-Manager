using Microsoft.EntityFrameworkCore;
using server.Data;

namespace server.Services;

public class SeasonStatsService
{
    private readonly AppDbContext _context;
    public SeasonStatsService(AppDbContext context)
    {
        _context = context;
    }


    public void UpdatePlayerSeasonStats()
    {
        var playerBoxes = _context.PlayerBoxes
                .Include(pb => pb.Player)
                    .ThenInclude(p => p.PlayerSeasonStats)
                    .Where(pb => !pb.isAggregated);


        foreach(var pb in playerBoxes)
        {
            var seasonStatExist = pb.Player.PlayerSeasonStats
                    .FirstOrDefault(p => p.SeasonId == pb.SeasonId);

            if (seasonStatExist is null)
            {
                _context.PlayerSeasonStats.Add(new PlayerSeasonStat
                {   
                    PlayerId = pb.PlayerId,
                    SeasonId = pb.SeasonId!,

                });
            }

            var seasonStats = pb.Player.PlayerSeasonStats
                    .First(p => p.SeasonId == pb.SeasonId);

            
            seasonStats.GamesPlayed++;
            seasonStats.Assists += pb.Assists;
            seasonStats.FieldGoalsMade += pb.FieldGoalsMade;
            seasonStats.FieldGoalsAttempted += pb.FieldGoalsAttempted;
            seasonStats.ThreePointFieldGoalsMade += pb.ThreePointFieldGoalsMade;
            seasonStats.ThreePointFieldGoalsAttempted += pb.ThreePointFieldGoalsAttempted;
            seasonStats.FreeThrowsAttempted += pb.FreeThrowsAttempted;
            seasonStats.FreeThrowsMade += pb.FreeThrowsMade;
            seasonStats.OffensiveRebounds += pb.OffensiveRebounds;
            seasonStats.DefensiveRebounds += pb.DefensiveRebounds;
            seasonStats.Rebounds += pb.Rebounds;
            seasonStats.Steals += pb.Steals;
            seasonStats.Blocks += pb.Blocks;
            seasonStats.Turnovers += pb.Turnovers;
            seasonStats.Fouls += pb.Fouls;
            seasonStats.Points += pb.Points;
            seasonStats.Minutes += pb.Minutes;

            pb.isAggregated = true;
        }

        _context.SaveChanges();
        
    }    

}