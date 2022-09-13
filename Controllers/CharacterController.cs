using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_api.Models;

namespace dotnet_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> knights = new List<Character> {
            new Character(),
            new Character {Name = "Sam"}
        };

        [HttpGet]
        public ActionResult<List<Character>> Get() {
            return Ok(knights);
        }
    }
}