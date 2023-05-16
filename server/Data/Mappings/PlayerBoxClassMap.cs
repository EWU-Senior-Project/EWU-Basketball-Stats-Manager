using  CsvHelper.Configuration;

namespace server.Data.Mappings;

public sealed class PlayerBoxClassMap : ClassMap<PlayerBox>
{
    //Mapping this class to player_box.csv
    public PlayerBoxClassMap()
    {
        Map(m => m.GameId).Name("game_id");
        Map(m => m.Season).Name("season");
        Map(m => m.SeasonType).Name("season_type");
        Map(m => m.PlayerId).Name("athlete_id");
        Map(m => m.Minutes).Name("minutes");
        Map(m => m.FieldGoalsMade).Name("field_goals_made");
        Map(m => m.FieldGoalsAttempted).Name("field_goals_attempted");
        Map(m => m.ThreePointFieldGoalsMade).Name("three_point_field_goals_made");
        Map(m => m.ThreePointFieldGoalsAttempted).Name("three_point_field_goals_attempted");
        Map(m => m.FreeThrowsMade).Name("free_throws_made");
        Map(m => m.FreeThrowsAttempted).Name("free_throws_attempted");
        Map(m => m.OffensiveRebounds).Name("offensive_rebounds");
        Map(m => m.DefensiveRebounds).Name("defensive_rebounds");
        Map(m => m.Rebounds).Name("rebounds");
        Map(m => m.Assists).Name("assists");
        Map(m => m.Steals).Name("steals");
        Map(m => m.Blocks).Name("blocks");
        Map(m => m.Turnovers).Name("turnovers");
        Map(m => m.Fouls).Name("fouls");
        Map(m => m.Points).Name("points");
        Map(m => m.Starter).Name("starter");
        Map(m => m.Ejected).Name("ejected");
        Map(m => m.DidNotPlay).Name("did_not_play");
        Map(m => m.IsActive).Name("active");
    }
}