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
    [Obsolete("Use SeedGamesFast()")]
    //keeping as a reference for readability
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
    public static void SeedGamesFast(AppDbContext context)
    {
        using (var reader = new StreamReader("../../../Content/team_box.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<GameRowClassMap>();
            var records = csv.GetRecords<GameRow>();

            // A dictionary to hold games in progress of being built.
            // The key is game ID and the value is the Game object.
            Dictionary<int, Game> gamesInProgress = new Dictionary<int, Game>();

            foreach (var record in records)
            {
                if (gamesInProgress.TryGetValue(record.Id, out Game? gameInProgress))
                {
                    // second row of a game.
                    if (record.TeamHomeAway == "away")
                    {
                        gameInProgress.AwayTeamId = record.TeamId;
                        gameInProgress.AwayScore = record.TeamScore;
                    }
                    else
                    {
                        gameInProgress.HomeTeamId = record.TeamId;
                        gameInProgress.HomeScore = record.TeamScore;
                    }

                    // if true then entry is complete and should be added to context
                    if (!context.Games.Any(game => game.GameId == gameInProgress.GameId))
                    {
                        context.Games.Add(gameInProgress);
                    }
                    //no longer in progress so remove from dictionary
                    gamesInProgress.Remove(record.Id);
                }
                else
                {
                    //New game so start building it
                    //wont be added to the context until object is complete
                    Game newGame = new Game
                    {
                        GameId = record.Id,
                        Season = record.Season,
                        SeasonType = record.SeasonType,
                        GameDate = record.GameDate,
                        GameDateTime = record.GameDateTime
                    };
                    if (record.TeamHomeAway == "away")
                    {
                        newGame.AwayTeamId = record.TeamId;
                        newGame.AwayScore = record.TeamScore;
                    }
                    else
                    {
                        newGame.HomeTeamId = record.TeamId;
                        newGame.HomeScore = record.TeamScore;
                    }
                    gamesInProgress[record.Id] = newGame;
                }
            }
            context.SaveChanges();
        }
    }

    public static void SeedTeamBoxScores (AppDbContext context)
    {
        using (var reader = new StreamReader("../../../Content/team_box.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<TeamBoxClassMap>();
            var verboseRecords = csv.GetRecords<TeamBox>();

             var filteredRecords = verboseRecords.GroupBy(box => new {box.GameId, box.TeamId})
                                                .Select(group => group.First())
                                                .ToList();
            //loading db to check against
            var existingRecords = new HashSet<(int, int)>(
                context.TeamBoxes.Select(box => new {box.GameId, box.TeamId})
                                    .ToList()
                                    .Select(x => (x.GameId, x.TeamId))
            );

            foreach (var row in filteredRecords)
            {
                if(!existingRecords.Contains((row.GameId, row.TeamId)))
                {
                    context.TeamBoxes.Add(row);
                }
            }
            context.SaveChanges();
        }
    }

    public static void SeedPlayerBoxScores (AppDbContext context)
    {
        using (var reader = new StreamReader("../../../Content/player_box.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            csv.Context.RegisterClassMap<PlayerBoxClassMap>();
            var verboseRecords = csv.GetRecords<PlayerBox>();
            
            //removing duplicates from update file
            var filteredRecords = verboseRecords.GroupBy(box => new {box.GameId, box.PlayerId})
                                                .Select(group => group.First())
                                                .ToList();
            //loading db to check against
            var existingRecords = new HashSet<(int, int)>(
                context.PlayerBoxes.Select(box => new {box.GameId, box.PlayerId})
                                    .ToList()
                                    .Select(x => (x.GameId, x.PlayerId))
            );

            foreach (var row in filteredRecords)
            {
                //making sure we are not adding twice
                if(!existingRecords.Contains((row.GameId, row.PlayerId)))
                {
                    context.PlayerBoxes.Add(row);
                }
            }
            context.SaveChanges();
        }
    }

}