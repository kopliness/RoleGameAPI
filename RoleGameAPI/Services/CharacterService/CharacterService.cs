﻿using RoleGameAPI.Models;

namespace RoleGameAPI.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character(){ Id=1,Name="Trall", Class=RpgClass.Orc}
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
            var character = characters.FirstOrDefault(c => c.Id == id);
            if(character is not null) 
                return character;
            throw new Exception("Character is not found");
        }
    }
}
