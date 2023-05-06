using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace server.Data
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Uid { get; set; } = null!;
        public string Slug { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Abbreviation { get; set; } = null!;
        public string DisplayName { get; set; } = null!;
        public string ShortDisplayName { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string AlternateColor { get; set; } = null!;
        public string Logo { get; set; } = null!;

        public ICollection<Game> HomeGames { get; set; } = null!;
        public ICollection<Game> AwayGames { get; set; } = null!;
        //public ICollection<PlayerBox> PlayerBoxes { get; set; } = null!;
        public ICollection<TeamBox> TeamBoxes { get; set; } = null!;
    }
}