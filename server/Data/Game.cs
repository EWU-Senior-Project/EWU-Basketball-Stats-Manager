namespace server.Data
{
    public class Game
    {
        public int GameId { get; set; }
        public int? SeasonId { get; set; }
        public DateTime GameDateTime { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public virtual Team HomeTeam { get; set; } = null!;
        public int HomeTeamId { get; set; }
        public virtual Team AwayTeam { get; set; } = null!;
        public int AwayTeamId { get; set; }
        public virtual Season Season { get; set;} = null!; 
        // @TODO
        //public virtual ICollection<PlayByPlay> PlayByPlays { get; set; } = null!;
        public virtual ICollection<PlayerBox> PlayerBoxes { get; set; } = null!;
        public virtual ICollection<TeamBox> TeamBoxes { get; set; } = null!;
    }
}