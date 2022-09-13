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
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Name = "Sam"}
        };

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get() {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle() {
            return Ok(characters[0]);
        }
    }
}