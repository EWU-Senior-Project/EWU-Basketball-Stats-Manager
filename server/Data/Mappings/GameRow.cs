public class GameRow
{
    public int Id { get; set; }
    public int Season { get; set; }
    public int SeasonType { get; set; }
    public DateTime GameDate { get; set; }
    public DateTime GameDateTime { get; set; }
    public int TeamId { get; set; }
    public string TeamHomeAway { get; set; } = null!;
    public int TeamScore { get; set; }
    
}