using  CsvHelper.Configuration;
using server.Data.Mappings.MappingUtils;
namespace server.Data.Mappings;

public sealed class PlayerBoxClassMap : ClassMap<PlayerBox>
{
    //Mapping this class to player_box.csv
    public PlayerBoxClassMap()
    {
        Map(m => m.GameId).Name("game_id");
        Map(m => m.TeamId).Name("team_id");
        Map(m => m.PlayerId).Name("athlete_id");
        Map(m => m.Minutes).Name("minutes").TypeConverter<CustomInt32Converter>();
        Map(m => m.FieldGoalsMade).Name("field_goals_made").TypeConverter<CustomInt32Converter>();
        Map(m => m.FieldGoalsAttempted).Name("field_goals_attempted").TypeConverter<CustomInt32Converter>();
        Map(m => m.ThreePointFieldGoalsMade).Name("three_point_field_goals_made").TypeConverter<CustomInt32Converter>();
        Map(m => m.ThreePointFieldGoalsAttempted).Name("three_point_field_goals_attempted").TypeConverter<CustomInt32Converter>();
        Map(m => m.FreeThrowsMade).Name("free_throws_made").TypeConverter<CustomInt32Converter>();
        Map(m => m.FreeThrowsAttempted).Name("free_throws_attempted").TypeConverter<CustomInt32Converter>();
        Map(m => m.OffensiveRebounds).Name("offensive_rebounds").TypeConverter<CustomInt32Converter>();
        Map(m => m.DefensiveRebounds).Name("defensive_rebounds").TypeConverter<CustomInt32Converter>();
        Map(m => m.Rebounds).Name("rebounds").TypeConverter<CustomInt32Converter>();
        Map(m => m.Assists).Name("assists").TypeConverter<CustomInt32Converter>();
        Map(m => m.Steals).Name("steals").TypeConverter<CustomInt32Converter>();
        Map(m => m.Blocks).Name("blocks").TypeConverter<CustomInt32Converter>();
        Map(m => m.Turnovers).Name("turnovers").TypeConverter<CustomInt32Converter>();
        Map(m => m.Fouls).Name("fouls").TypeConverter<CustomInt32Converter>();
        Map(m => m.Points).Name("points").TypeConverter<CustomInt32Converter>();
        Map(m => m.Starter).Name("starter");
        Map(m => m.Ejected).Name("ejected");
        Map(m => m.DidNotPlay).Name("did_not_play");
        Map(m => m.IsActive).Name("active");
    }
}