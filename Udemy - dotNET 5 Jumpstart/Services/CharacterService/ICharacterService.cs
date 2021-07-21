using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy___dotNET_5_Jumpstart.DTOs.Character;
using Udemy___dotNET_5_Jumpstart.Models;

namespace Udemy___dotNET_5_Jumpstart.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();

         Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);

         Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
    }
}