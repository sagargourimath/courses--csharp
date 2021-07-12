using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy___dotNET_5_Jumpstart.Models;

namespace Udemy___dotNET_5_Jumpstart.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<Character>>> GetAllCharacters();

         Task<ServiceResponse<Character>> GetCharacterById(int id);

         Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}