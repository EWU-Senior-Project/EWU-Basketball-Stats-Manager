using server.Data;
using Microsoft.EntityFrameworkCore;

namespace server.Services;

public class SeasonService
{
    private readonly AppDbContext _context;

    public SeasonService(AppDbContext context)
    {
        _context = context; 
    }

    public void SeedSeasons()
    {
        var startYear = 2015;
        var endYear = 2030;
        for (int year = startYear; year <= endYear; year++)
        {
            var season = new Season{
                    StartDate = new DateTime(year, 10, 1).ToUniversalTime(),
                    EndDate = new DateTime(year+1, 4, 30).ToUniversalTime(),
                    SeasonString = $"{year}-{year+1}"
            };
            if(!_context.Seasons.Any(s=>s.StartDate == season.StartDate))
            {
                _context.Seasons.Add(season);
                _context.SaveChanges();
            }
            
        }
    } 

    public void UpdateExistingRecordsSeasons()
    {
        var games = _context.Games.ToList();

        foreach(var game in games)
        {
            var season = GetSeasonFromGame(_context, game);

            if (season != null)
            {
                game.SeasonId = season.SeasonId;
            }
            else 
            {
                throw new InvalidOperationException($"No season found for game {game.GameId} with date {game.GameDateTime}");
            }
        }

        _context.SaveChanges();

        var playerBoxes = _context.PlayerBoxes.Include(pb => pb.Game).ToList();

        foreach(var pb in playerBoxes)
        {
            pb.SeasonId = pb.Game.SeasonId;
        }
        _context.SaveChanges();
    }

    public static Season GetSeasonFromGame(AppDbContext context, Game game)
    {
        return context.Seasons.
            FirstOrDefault(s => s.StartDate <= game.GameDateTime && game.GameDateTime <= s.EndDate)!;
    }
    
}