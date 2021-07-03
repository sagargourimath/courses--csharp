using System.Collections.Generic;
using System.Threading.Tasks;
using Udemy___dotNET_5_Jumpstart.Models;

namespace Udemy___dotNET_5_Jumpstart.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<List<Character>> GetAllCharacters();

         Task<Character> GetCharacterById(int id);

         Task<List<Character>> AddCharacter(Character newCharacter);
    }
}