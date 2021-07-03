using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Udemy___dotNET_5_Jumpstart.Models;
using Udemy___dotNET_5_Jumpstart.Services.CharacterService;

namespace Udemy___dotNET_5_Jumpstart.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CharacterController : ControllerBase
  {
    private readonly ICharacterService _characterService;
    public CharacterController(ICharacterService characterService)
    {
      _characterService = characterService;
    }

    [HttpGet]
    [Route("GetAll")]
    public ActionResult<List<Character>> Get()
    {
      return Ok(_characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public ActionResult<Character> GetSingle(int id)
    {
      return Ok(_characterService.GetCharacterById(id));
    }

    [HttpPost]
    public ActionResult<List<Character>> AddCharacter(Character newCharacter)
    {
      return Ok(_characterService.AddCharacter(newCharacter));
    }
  }
}