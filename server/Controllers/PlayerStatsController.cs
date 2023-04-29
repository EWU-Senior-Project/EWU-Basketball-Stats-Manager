using Microsoft.AspNetCore.Mvc;
using server.Dto;
namespace server.Controllers;

[ApiController]
[Route("[controller]")]
public class PlayerStatsController : ControllerBase
{
    [HttpGet(Name = "GetTopScorers")]
    public TopScorersDto GetTopScorers()
    {
        return new TopScorersDto(
            "Bugsy Bouges",
            23,
            29.6,
            9.8,
            9.8,
            9.8,
            9.8,
            9.8
        );
    }
}
