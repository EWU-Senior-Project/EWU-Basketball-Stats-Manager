namespace server.Data;

public class PlayerSeasonStat
{
    public int PlayerSeasonStatId { get; set; }
    public int PlayerId { get; set; }
    public virtual Player Player { get; set;} = null!;
    public int? SeasonId { get; set; }
    public virtual Season season { get; set; } = null!;
    public int GamesPlayed { get; set; }
    public int Minutes { get; set; }
    public int FieldGoalsMade { get; set; }
    public int FieldGoalsAttempted { get; set; }
    public int ThreePointFieldGoalsMade { get; set; }
    public int ThreePointFieldGoalsAttempted { get; set; }
    public int FreeThrowsMade { get; set; }
    public int FreeThrowsAttempted { get; set; }
    public int OffensiveRebounds { get; set; }
    public int DefensiveRebounds { get; set; }
    public int Rebounds { get; set; }
    public int Assists { get; set; }
    public int Steals { get; set; }
    public int Blocks { get; set; }
    public int Turnovers { get; set; }
    public int Fouls { get; set; }
    public int Points { get; set; }
    
}
