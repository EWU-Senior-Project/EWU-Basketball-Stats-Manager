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
    public IEnumerable<Player> GetTopScorers(int teamId)
    {
        return _PlayerStatsService.GetTopScorersByTeamId(teamId);
    }
}
