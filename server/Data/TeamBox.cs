namespace server.Data
{
    

    public class TeamBox
    {
        public int TeamBoxId { get; set; }
        public int TeamScore { get; set; }
        public bool TeamWinner { get; set; }
        public int Assists { get; set; }
        public int Blocks { get; set; }
        public int DefensiveRebounds { get; set; }
        public double FieldGoalPct { get; set; }
        public int FieldGoalsMade { get; set; }
        public int FieldGoalsAttempted { get; set; }
        public int FlagrantFouls { get; set; }
        public int Fouls { get; set; }
        public double FreeThrowPct { get; set; }
        public int FreeThrowsMade { get; set; }
        public int FreeThrowsAttempted { get; set; }
        public int LargestLead { get; set; }
        public int OffensiveRebounds { get; set; }
        public int Steals { get; set; }
        public int TeamTurnovers { get; set; }
        public int TechnicalFouls { get; set; }
        public double ThreePointFieldGoalPct { get; set; }
        public int ThreePointFieldGoalsMade { get; set; }
        public int ThreePointFieldGoalsAttempted { get; set; }
        public int TotalRebounds { get; set; }
        public int TotalTechnicalFouls { get; set; }
        public int TotalTurnovers { get; set; }
        public int Turnovers { get; set; }
        public virtual Game Game { get; set; } = null!;
        public int GameId { get; set; }
        public virtual Team Team { get; set; } = null!;
        public int TeamId { get; set; }
    }
}