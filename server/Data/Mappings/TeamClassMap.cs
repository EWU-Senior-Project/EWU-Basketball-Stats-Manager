using  CsvHelper.Configuration;

namespace server.Data.Mappings;

public sealed class TeamClassMap : ClassMap<Team>
{
    //Mapping this class to schedule.csv
    public TeamClassMap()
    {
        Map(m => m.TeamId).Name("team_id");
        Map(m => m.Location).Name("team_location");
        Map(m => m.Name).Name("team_name");
        Map(m => m.Abbreviation).Name("team_abbreviation");
        Map(m => m.DisplayName).Name("team_display_name");
        Map(m => m.ShortDisplayName).Name("team_short_display_name");
        Map(m => m.Color).Name("team_color");
        Map(m => m.AlternateColor).Name("team_alternate_color");
        Map(m => m.Logo).Name("team_logo");
    }
}