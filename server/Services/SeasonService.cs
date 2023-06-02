using server.Data;

namespace server.Services;

public class SeasonService
{
    private readonly AppDbContext _context;

    public SeasonService(AppDbContext context)
    {
        _context = context; 
    }

    public static void SeedSeasons(AppDbContext context)
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
            context.Seasons.Add(season);
        }
    } 

    public static void UpdateExistingRecordsSeasons(AppDbContext context)
    {
        var games = context.Games.ToList();

        foreach(var game in games)
        {
            var season = GetSeasonFromGame(context, game);

            if (season != null)
            {
                game.SeasonId = season.SeasonId;
            }
            else 
            {
                throw new InvalidOperationException($"No season found for game {game.GameId} with date {game.GameDateTime}");
            }
        }

        context.SaveChanges();
    }
    
    public static Season GetSeasonFromGame(AppDbContext context, Game game)
    {
        return context.Seasons.
            FirstOrDefault(s => s.StartDate <= game.GameDateTime && game.GameDateTime <= s.EndDate)!;
    }
    
}