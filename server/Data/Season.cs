//format for SeasonString: "{year}-{year+1}"

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace server.Data
{
    public class Season
    {
        public int SeasonId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SeasonString {get; set; } = null!;
        public ICollection<Game> Games { get; set; } = null!;

    }
}