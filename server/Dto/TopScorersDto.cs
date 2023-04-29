namespace server.Dto
{
    public class TopScorersDto
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public double Points { get; set; }

        public double FGMade { get; set; }
        public double FGAttempted { get; set; }

        public double FGPercent { get; set; }

        public double Assists { get; set; }
        public double Minutes { get; set; }

        public TopScorersDto(string name, int number, double points, double fgmade, double fgattempted, double fgpercent, double assists, double minutes)
        {
            Name = name;
            Number = number;
            Points = points;
            FGMade = fgmade;
            FGAttempted = fgattempted;
            FGPercent = fgpercent;
            Assists = assists;
            Minutes = minutes;
        }
    }
}