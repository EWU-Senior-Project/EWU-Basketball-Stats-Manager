using Microsoft.AspNetCore.Mvc;
namespace server.Controllers;

[Route("[controller]")]
[ApiController]
public class PlayerStatsController : ControllerBase
{
    /// <summary>
    /// Retrieves Top scorers
    /// </summary>
    /// <returns>List of players.</returns>
    [HttpGet("GetTopScorers")]
    public IEnumerable<PlayerDto> GetTopScorers()
    {
        PlayerDto player = new PlayerDto();
        player.number = 2;
        player.name = "Leborn";
        player.pts = 10;
        player.fgm = 11.1;
        player.fga = 12.2;
        player.fgp = 99.9;

        var playerList = new List<PlayerDto>();
        playerList.Add(player);
        playerList.Add(player);
        playerList.Add(player);
        playerList.Add(player);
        playerList.Add(player);

        return playerList;
    }

    /// <summary>
    /// retrieves a players stats by his ID
    /// </summary>
    /// <param name="playerID">a given player's ID</param>
    /// <returns>A player</returns>
    [HttpGet("GetPlayerStatsById")]
    public PlayerDto GetPlayerStatsById(int playerID)
    {
        PlayerDto player = new PlayerDto();
        player.number = 2;
        player.name = "Leborn";
        player.pts = 10;
        player.fgmA = $"{5.7}-{8.3}";
        player.fgp = 99.9;
        player.threePMA = $"{5.7}-{8.3}";
        player.threeP = 10.2;
        player.ftmA = $"{1.6}-{2.6}";
        player.reb = 7.6;
        player.orb = 1.0;
        player.ast = 2.0;
        player.to = 1.7;

        return player;
    }
}
