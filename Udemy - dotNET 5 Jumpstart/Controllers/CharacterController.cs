using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Udemy___dotNET_5_Jumpstart.Models;

namespace Udemy___dotNET_5_Jumpstart.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> 
        {
            new Character(),
            new Character { Name = "Sam" }
        };

        [HttpGet]
        [Route("GetAll")]
        public ActionResult<List<Character>> Get() 
        {
            return Ok(characters);
        }

        [HttpGet]
        public ActionResult<Character> GetSingle() 
        {
            return Ok(characters[0]);
        }
    }
}