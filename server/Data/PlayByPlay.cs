namespace server.Data
{
    public class PlayByPlay
    {
        public int Id { get; set; }
        public string SequenceNumber { get; set; } = null!;
        public int TypeId { get; set; }
        public string TypeText { get; set; } = null!;
        public string Text { get; set; } = null!;
        public int AwayScore { get; set; }
        public int HomeScore { get; set; }
        public int PeriodNumber { get; set; }
        public string PeriodDisplayValue { get; set; } = null!;
        public string ClockDisplayValue { get; set; } = null!;
        public bool ScoringPlay { get; set; }
        public int ScoreValue { get; set; }
        public Team TeamPlay { get; set; } = null!;
        public DateTime Wallclock { get; set; }
        public bool ShootingPlay { get; set; }
        public double CoordinateXRaw { get; set; }
        public double CoordinateYRaw { get; set; }
        public int Season { get; set; }
        public string SeasonType { get; set; } = null!;
        public Team AwayTeam { get; set; } = null!;
        public Team HomeTeam { get; set; } = null!;
        public int Qtr { get; set; }
        public string Time { get; set; } = null!;
        public int ClockMinutes { get; set; }
        public int ClockSeconds { get; set; }
        public int Half { get; set; }
        public int GameHalf { get; set; }
        public int LeadQtr { get; set; }
        public int LeadGameHalf { get; set; }
        public int StartQuarterSecondsRemaining { get; set; }
        public int StartHalfSecondsRemaining { get; set; }
        public int StartGameSecondsRemaining { get; set; }
        public int GamePlayNumber { get; set; }
        public int EndQuarterSecondsRemaining { get; set; }
        public int EndHalfSecondsRemaining { get; set; }
        public int EndGameSecondsRemaining { get; set; }
        public int Period { get; set; }
        public Player AthleteId1 { get; set; } = null!;
        public int LagQtr { get; set; }
        public int LagGameHalf { get; set; }
        public Player AthleteId2 { get; set; } = null!;
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public DateTime GameDate { get; set; }
        public DateTime GameDateTime { get; set; }
        public virtual Game Game { get; set; } = null!;
    }
}