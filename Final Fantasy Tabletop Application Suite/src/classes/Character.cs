﻿using Final_Fantasy_Tabletop_Application_Suite.src.interfaces;
using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class Character : ICharacter
    {
        //Interface
        public string Name { get; private set; }

        public string Race { get; private set; }

        public string Class { get; private set; }

        public int LevelPoints { get; private set; }

        public int[] CharacterStats { get; private set; }

        public List<string>? Spells { get; private set; }

        public List<string>? Skills { get; private set; }

        public List<string>? Abilities { get; private set; }

        public string? CharacterStory { get; set; }

        //Constructor - Creates Character Object
        public Character(string name, string race, string @class, int levelpoints, int[] stats)
        {
            this.Name = name;
            this.Race = race;
            this.Class = @class;
            this.LevelPoints = levelpoints;
            this.CharacterStats = new int[7]; // | HP | MP | STR | MAG | DEF | DEX | SPR |
            this.CharacterStats = stats;
        }

        [JsonConstructor] //Constructor arguments MUST match the properties of the class otherwise an unhandled exception will occur
        public Character(string Name, string Race, string @Class, int LevelPoints, int[] CharacterStats, List<string> Spells, List<string> Skills, List<string> Abilities, string CharacterStory)
        {
            this.Name = Name;
            this.Race = Race;
            this.Class = @Class;
            this.LevelPoints = LevelPoints;
            this.CharacterStats = CharacterStats;
            this.Spells = Spells;
            this.Skills = Skills;
            this.Abilities = Abilities;
            this.CharacterStory = CharacterStory;
        }
    }
}
