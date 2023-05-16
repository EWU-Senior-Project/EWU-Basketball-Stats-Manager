using  CsvHelper.Configuration;

namespace server.Data.Mappings;

public sealed class TeamClassMap : ClassMap<Team>
{
    //Mapping this class to schedule.csv
    public TeamClassMap()
    {
        Map(m => m.TeamId).Name("home_id");
        Map(m => m.Location).Name("home_location");
        Map(m => m.Name).Name("home_name");
        Map(m => m.Abbreviation).Name("home_abbreviation");
        Map(m => m.DisplayName).Name("game_date_time");
        Map(m => m.ShortDisplayName).Name("home_short_display_name");
        Map(m => m.Color).Name("home_color");
        Map(m => m.AlternateColor).Name("home_alternate_color");
        Map(m => m.Logo).Name("home_logo");
    }
}