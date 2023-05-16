using  CsvHelper.Configuration;

namespace server.Data.Mappings;

public sealed class GameClassMap : ClassMap<Game>
{
    //Mapping this class to schedule.csv
    public GameClassMap()
    {
        Map(m => m.GameId).Name("id");
        Map(m => m.Season).Name("season");
        Map(m => m.SeasonType).Name("season_type");
        Map(m => m.GameDate).Name("game_date");
        Map(m => m.GameDateTime).Name("game_date_time");
        Map(m => m.HomeScore).Name("home_score");
        Map(m => m.HomeTeamId).Name("home_id");
        Map(m => m.AwayScore).Name("away_score");
        Map(m => m.AwayTeamId).Name("away_id");
    }
}