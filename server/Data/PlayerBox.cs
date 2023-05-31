namespace server.Data
{
    public class PlayerBox
    {
        public int PlayerBoxId { get; set; }
        public int Season { get; set; }
        public int SeasonType { get; set; }
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
        public bool Starter { get; set; }
        public bool Ejected { get; set; }
        public bool DidNotPlay { get; set; }
        public bool IsActive { get; set; }
   
        public virtual Game Game { get; set; } = null!;
        public int GameId { get; set; }
        public virtual Player Player { get; set; } = null!;
        public int PlayerId { get; set; }
        public virtual Team Team { get; set; } = null!;
        public int TeamId { get; set; }
    }
}