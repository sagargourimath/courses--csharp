using System.Collections.Generic;
using Udemy___dotNET_5_Jumpstart.Models;

namespace Udemy___dotNET_5_Jumpstart.Services.CharacterService
{
    public interface ICharacterService
    {
         List<Character> GetAllCharacters();

         Character GetCharacterById(int id);

         List<Character> AddCharacter(Character newCharacter);
    }
}