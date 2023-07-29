﻿namespace RoleGameAPI
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto> ();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
