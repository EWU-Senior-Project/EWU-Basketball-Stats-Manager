namespace server.Dto 
{
    public class GameStatDto
    {
        public string? AwayTeam {get; set;} 
        public string? HomeTeam {get; set;}
        public IEnumerable<PlayerScoreDto>? AwayPlayerScores {get; set;}
        public IEnumerable<PlayerScoreDto>? HomePlayerScores {get; set;}
        public double TeamPoints {get; set;}
        public double TeamAssists {get; set;}
        public double TeamRebounds {get; set;}
        


        public GameStatDto(string awayTeam, string homeTeam)
        {
            AwayTeam = awayTeam;
            HomeTeam = homeTeam;
        }
    }
}
   