using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Udemy___dotNET_5_Jumpstart.Models;

namespace Udemy___dotNET_5_Jumpstart.Services.CharacterService
{
  public class CharacterService : ICharacterService
  {
    private static List<Character> characters = new List<Character> 
    {
        new Character(),
        new Character { Id = 1, Name = "Sam" }
    };

    public async Task<List<Character>> AddCharacter(Character newCharacter)
    {
      characters.Add(newCharacter);
      return characters;
    }

    public async Task<List<Character>> GetAllCharacters()
    {
      return characters;
    }

    public async Task<Character> GetCharacterById(int id)
    {
      return characters.FirstOrDefault(x => x.Id == id);
    }
  }
}