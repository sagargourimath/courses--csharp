using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy___dotNET_5_Jumpstart.Models;
using Udemy___dotNET_5_Jumpstart.DTOs.Character;

namespace Udemy___dotNET_5_Jumpstart.Services.CharacterService
{
  public class CharacterService : ICharacterService
  {
    private static List<Character> characters = new List<Character>
    {
        new Character(),
        new Character { Id = 1, Name = "Sam" }
    };
    private readonly IMapper _mapper;

    public CharacterService(IMapper mapper)
    {
      _mapper = mapper;
    }
    public async Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter)
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
      var character = _mapper.Map<Character>(newCharacter);
      character.Id = characters.Max(c => c.Id) + 1;
      characters.Add(character);

      serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
      return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters()
    {
      var serviceResponse = new ServiceResponse<List<GetCharacterDTO>>();
      serviceResponse.Data = characters.Select(c => _mapper.Map<GetCharacterDTO>(c)).ToList();
      return serviceResponse;
    }

    public async Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id)
    {
      var serviceResponse = new ServiceResponse<GetCharacterDTO>();
      serviceResponse.Data = _mapper.Map<GetCharacterDTO>(characters.FirstOrDefault(x => x.Id == id));

      return serviceResponse;
    }

    public async Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updatedCharacter)
    {
      var serviceResponse = new ServiceResponse<GetCharacterDTO>();
      Character character = characters.FirstOrDefault(c => c.Id == updatedCharacter.Id);
      character.Name = updatedCharacter.Name;
      character.HitPoints = updatedCharacter.HitPoints;
      character.Strength = updatedCharacter.Strength;
      character.Defence = updatedCharacter.Defence;
      character.Intelligence = updatedCharacter.Intelligence;
      character.Class = updatedCharacter.Class;

      serviceResponse.Data = _mapper.Map<GetCharacterDTO>(character);

      return serviceResponse;
    }
  }
}