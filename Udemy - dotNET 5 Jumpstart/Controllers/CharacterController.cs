using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
    {
      return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
    {
      return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
    {
      return Ok(await _characterService.AddCharacter(newCharacter));
    }
  }
}