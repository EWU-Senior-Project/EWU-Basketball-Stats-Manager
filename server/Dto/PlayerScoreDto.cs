namespace server.Dto 
{
    public class PlayerScoreDto
    {
        public string? Name {get; set;} 
        public int Number {get; set;}
        public double Points {get; set;}
        public double Rebounds {get; set;}
        public double Assists {get; set;}
        public double Minutes {get; set;}
        


        public PlayerScoreDto(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}