using  CsvHelper.Configuration;

namespace server.Data.Mappings;

public sealed class TeamBoxClassMap : ClassMap<TeamBox>
{
    //Mapping this class to player_box.csv
    public TeamBoxClassMap()
    {
        Map(m => m.GameId).Name("game_id");
        Map(m => m.TeamId).Name("team_id");
        Map(m => m.TeamScore).Name("team_score");
        Map(m => m.TeamWinner).Name("team_winner");
        Map(m => m.Assists).Name("assists");
        Map(m => m.Blocks).Name("blocks");
        Map(m => m.FieldGoalPct).Name("field_goal_pct");
        Map(m => m.FieldGoalsMade).Name("field_goals_made");
        Map(m => m.FieldGoalsAttempted).Name("field_goals_attempted");
        Map(m => m.ThreePointFieldGoalsAttempted).Name("three_point_field_goals_attempted");
        Map(m => m.FreeThrowsMade).Name("free_throws_made");
        Map(m => m.FreeThrowsAttempted).Name("free_throws_attempted");
        Map(m => m.OffensiveRebounds).Name("offensive_rebounds");
        Map(m => m.DefensiveRebounds).Name("defensive_rebounds");
        Map(m => m.FlagrantFouls).Name("flagrant_fouls");
        Map(m => m.Assists).Name("assists");
        Map(m => m.Steals).Name("steals");
        Map(m => m.Blocks).Name("blocks");
        Map(m => m.Turnovers).Name("team_turnovers");
        Map(m => m.Fouls).Name("fouls");
        Map(m => m.LargestLead).Name("largest_lead");
        Map(m => m.Turnovers).Name("starter");
        Map(m => m.TotalTurnovers).Name("total_turnovers");
        Map(m => m.TotalRebounds).Name("total_rebounds");
        Map(m => m.TotalTechnicalFouls).Name("total_technical_fouls");

    }
}