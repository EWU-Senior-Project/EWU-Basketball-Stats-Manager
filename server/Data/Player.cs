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
        public ICollection<PlayerSeasonStat> PlayerSeasonStats { get; set; } = null!;

    }
}