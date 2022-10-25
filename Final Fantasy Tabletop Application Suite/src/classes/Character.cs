using Final_Fantasy_Tabletop_Application_Suite.src.interfaces;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class Character : ICharacter
    {
        //Interface
        public int CharacterId { get; private set; }

        public string? Name { get; private set; }

        public string? Race { get; private set; }

        public string? Class { get; private set; }

        public int LevelPoints { get; private set; }

        public List<string>? Spells { get; private set; }

        public List<string>? Skills { get; private set; }

        public List<string>? Abilities { get; private set; }

        public string? CharacterStory { get; set; }

        //Constructor - Creates Character Object
        public Character(string name, string race, string @class, int levelpoints)
        {
            this.Name = name;
            this.Race = race;
            this.Class = @class;
            this.LevelPoints = levelpoints;
        }
    }
}
