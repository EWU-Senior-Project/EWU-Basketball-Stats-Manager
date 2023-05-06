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
    public IEnumerable<PlayerDto> GetTopScorers(string query)
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
}
