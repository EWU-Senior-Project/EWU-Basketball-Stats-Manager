using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Services;

namespace server.Controllers;

[Route("[controller]")]
[ApiController]
public class PlayerStatsController : ControllerBase
{
    private readonly PlayerStatsService _PlayerStatsService;
    public PlayerStatsController(PlayerStatsService playerStatsService)
    {
        _PlayerStatsService = playerStatsService;
    }

    /// <summary>
    /// Retrieves Top scorers
    /// </summary>
    /// <returns>List of players.</returns>
    [HttpGet("GetTopScorers")]
    public IEnumerable<Player> GetTopScorers()
    {
        return _PlayerStatsService.GetTopScorers();

        // PlayerDto player = new PlayerDto();
        // player.number = 2;
        // player.name = "Leborn";
        // player.pts = 10;
        // player.fgm = 11.1;
        // player.fga = 12.2;
        // player.fgp = 99.9;

        // var playerList = new List<PlayerDto>();
        // playerList.Add(player);
        // playerList.Add(player);
        // playerList.Add(player);
        // playerList.Add(player);
        // playerList.Add(player);

        // return playerList;
    }
}
