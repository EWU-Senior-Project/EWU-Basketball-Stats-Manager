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
        /*
        **
        public DateTime GameDate { get; set; }
        public DateTime GameDateTime { get; set; }
        public int AthleteId { get; set; }
        public string AthleteDisplayName { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string TeamLocation { get; set; }
        public string TeamShortDisplayName { get; set; }
        **
        public string AthleteJersey { get; set; }
        public string AthleteShortName { get; set; }
        public string AthleteHeadshotHref { get; set; }
        public string AthletePositionName { get; set; }
        public string AthletePositionAbbreviation { get; set; }
        public string TeamDisplayName { get; set; }
        public string TeamUid { get; set; }
        public string TeamSlug { get; set; }
        public string TeamLogo { get; set; }
        public string TeamAbbreviation { get; set; }
        public string TeamColor { get; set; }
        public string TeamAlternateColor { get; set; }
        public string HomeAway { get; set; }
        public bool TeamWinner { get; set; }
        public int TeamScore { get; set; }
        public int OpponentTeamId { get; set; }
        public string OpponentTeamName { get; set; }
        public string OpponentTeamLocation { get; set; }
        public string OpponentTeamDisplayName { get; set; }
        public string OpponentTeamAbbreviation { get; set; }
        public string OpponentTeamLogo { get; set; }
        public string OpponentTeamColor { get; set; }
        public string OpponentTeamAlternateColor { get; set; }
        public int OpponentTeamScore { get; set; }
        */
        public virtual Game Game { get; set; } = null!;
        public int GameId { get; set; }
        public virtual Player Player { get; set; } = null!;
        public int PlayerId { get; set; }
        //public virtual Team Team { get; set; }
    }
}