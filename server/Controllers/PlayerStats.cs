using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Dto;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerStats : ControllerBase
    {
        [HttpGet(Name = "GetPlayerByName")]
        public PlayerDto Get()
        {
            return new PlayerDto
                (
                "Michael Jordan",
                23
                );
        }
    }
}