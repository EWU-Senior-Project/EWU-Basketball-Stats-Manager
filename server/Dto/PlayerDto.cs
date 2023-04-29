namespace server.Dto 
{
    public class PlayerDto
    {
        public string? Name {get; set;} 
        public int Number {get; set;}
        public double ppg {get; set;}
        public double rbpg {get; set;}
        public double apg {get; set;}
        public double minpg {get; set;}
        


        public PlayerDto(string name, int number)
        {
            Name = name;
            Number = number;
        }
    }
}

