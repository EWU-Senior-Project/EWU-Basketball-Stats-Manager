namespace server.Data
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string DisplayName { get; set; } = null!;
        public virtual Team Team { get; set; } = null!;
        public int TeamId { get; set; }
        public string Jersey { get; set; } = null!;
        public string ShortName { get; set; } = null!;
        public string HeadshotHref { get; set; } = null!;
        public string PositionName { get; set; } = null!;
        public string PositionAbbreviation { get; set; } = null!;
        public ICollection<PlayerBox> PlayerBoxes { get; set; } = null!;

        //I think we should calculate these totals from the players box scores for the season instead of storing them in the db
        /*
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
        */
    }
}