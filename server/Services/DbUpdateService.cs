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
        using (var reader = new StreamReader("../../../Content/team_box.csv"))
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
        using (var reader = new StreamReader("../../../Content/player_box.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<PlayerClassMap>();
            var verboseRecords = csv.GetRecords<Player>();

            var filteredRecords = verboseRecords.GroupBy(player => player.PlayerId)
                                                .Select(group => group.First())
                                                .ToList();
            int playersWithoutTeams = 0;
            foreach (var row in filteredRecords)
            {
                if(!context.Players.Any(player => player.PlayerId == row.PlayerId))
                {
                    
                    if(!context.Teams.Any(team => team.TeamId == row.TeamId))
                    {
                        playersWithoutTeams ++;
                        Console.WriteLine("entries without matching teamID: " + playersWithoutTeams);
                    }
                    context.Players.Add(row);
                }
            }
            context.SaveChanges();
        }
    }

    public static void SeedGames (AppDbContext context)
    {
        using (var reader = new StreamReader("../../../Content/team_box.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<GameRowClassMap>();
            var records = csv.GetRecords<GameRow>();

            //This method is very readable but can be very inefficient
            //Will add another method using dictionary to improve performance. 
            var games = records
                .GroupBy(g => g.Id)
                .Select(g => new Game
                {
                   GameId = g.Key,
                    Season = g.First().Season,
                    SeasonType = g.First().SeasonType,
                    GameDate = g.First().GameDate,
                    GameDateTime = g.First().GameDateTime,
                    HomeTeamId = g.Single(r => r.TeamHomeAway == "home").TeamId,
                    AwayTeamId = g.Single(r => r.TeamHomeAway == "away").TeamId,
                    HomeScore = g.Single(r => r.TeamHomeAway == "home").TeamScore,
                    AwayScore = g.Single(r => r.TeamHomeAway == "away").TeamScore 
                });

            foreach (var game in games)
            {
                if(!context.Games.Any(g => g.GameId == game.GameId))
                {
                    context.Games.Add(game);
                }
            }
            context.SaveChanges();
        }
    }
}