using server.Data;
using server.Data.Mappings;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace server.Services;

public class DbUpdateService
{
    private readonly AppDbContext _context;

    public DbUpdateService(AppDbContext context)
    {
        _context = context;
    }

    public static void SeedTeams (AppDbContext context)
    {
        using (var reader = new StreamReader("../Content/schedule.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<TeamClassMap>();
            var verboseRecords = csv.GetRecords<Team>();

            var filteredRecords = verboseRecords.GroupBy(team => team.TeamId)
                                                .Select(group => group.First())
                                                .ToList();

            foreach (var row in filteredRecords)
            {
                if(!context.Teams.Any(team => team.TeamId == row.TeamId))
                {
                    context.Teams.Add(row);
                }
            }
            context.SaveChanges();
        }
    }

    public static void SeedPlayers (AppDbContext context)
    {
        using (var reader = new StreamReader("../Content/player_box.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<PlayerClassMap>();
            var verboseRecords = csv.GetRecords<Player>();

            var filteredRecords = verboseRecords.GroupBy(player => player.PlayerId)
                                                .Select(group => group.First())
                                                .ToList();

            foreach (var row in filteredRecords)
            {
                if(!context.Players.Any(player => player.PlayerId == row.PlayerId))
                {
                    context.Players.Add(row);
                }
            }
            context.SaveChanges();
        }
    }

    public static void SeedGames (AppDbContext context)
    {
        using (var reader = new StreamReader("../Content/player_box.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<GameClassMap>();
            var verboseRecords = csv.GetRecords<Game>();

            var filteredRecords = verboseRecords.GroupBy(game => game.GameId)
                                                .Select(group => group.First())
                                                .ToList();

            foreach (var row in filteredRecords)
            {
                if(!context.Games.Any(game => game.GameId == row.GameId))
                {
                    context.Games.Add(row);
                }
            }
            context.SaveChanges();
        }
    }
}