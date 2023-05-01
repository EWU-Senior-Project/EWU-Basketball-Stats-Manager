using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


public class Teams
{

    [Key]
    public Guid TeamId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(50)]
    public string Mascot { get; set; } = null!;

    [MaxLength(100)]
    public string Arena { get; set; } = null!;

    [MaxLength(100)]
    public string Coach { get; set; } = null!;

    [Range(0, int.MaxValue)]
    public int Wins { get; set; }

    [Range(0, int.MaxValue)]
    public int Losses { get; set; }

    //public ICollection<Player> Players { get; set; } = new List<Player>();

}