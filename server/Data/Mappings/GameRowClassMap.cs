using  CsvHelper.Configuration;

namespace server.Data.Mappings;

public sealed class GameRowClassMap : ClassMap<GameRow>
{
    
    public GameRowClassMap()
    {
        Map(m => m.Id).Name("game_id");
        Map(m => m.Season).Name("season");
        Map(m => m.SeasonType).Name("season_type");
        Map(m => m.GameDate).Name("game_date");
        Map(m => m.GameDateTime).Name("game_date_time");
        Map(m => m.TeamId).Name("team_id");
        Map(m => m.TeamHomeAway).Name("team_home_away");
        Map(m => m.TeamScore).Name("team_score");
    }
}