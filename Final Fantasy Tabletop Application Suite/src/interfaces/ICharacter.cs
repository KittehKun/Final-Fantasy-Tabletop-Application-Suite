using Final_Fantasy_Tabletop_Application_Suite.src.classes;

namespace Final_Fantasy_Tabletop_Application_Suite.src.interfaces
{
    internal interface ICharacter
    {
        public string? Name { get; }
        public string? Race { get; }
        public string? Class { get; }
        public int LevelPoints { get; }
        public int[] CharacterStats { get; }
        public List<string>? Spells { get; }
        public List<Skills>? Skills { get; } //Abilities classified here as skills
        public string? CharacterStory { get; set; }

    }
}
