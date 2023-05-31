using  CsvHelper.Configuration;

namespace server.Data.Mappings;

public sealed class PlayerClassMap : ClassMap<Player>
{
    //Mapping this class to player_box.csv
    public PlayerClassMap()
    {
        Map(m => m.PlayerId).Name("athlete_id");
        Map(m => m.DisplayName).Name("athlete_display_name");
        Map(m => m.TeamId).Name("team_id");
        Map(m => m.Jersey).Name("athlete_jersey");
        Map(m => m.ShortName).Name("athlete_short_name");
        Map(m => m.HeadshotHref).Name("athlete_headshot_href");
        Map(m => m.PositionName).Name("athlete_position_name");
        Map(m => m.PositionAbbreviation).Name("athlete_position_abbreviation");
             
    }
}