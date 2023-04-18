using Microsoft.AspNetCore.Mvc;
using server.dto;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerStatsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<PlayerStatsController> _logger;

    public PlayerStatsController(ILogger<PlayerStatsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPlayerStat")]
    public PlayerDto Get()
    {
        return new PlayerDto
        {
            name = "Bugsy Bouges",
            num = 23,
            avgPoints = 29.6,
            avgRebounds = 9.8
        };
    }
}