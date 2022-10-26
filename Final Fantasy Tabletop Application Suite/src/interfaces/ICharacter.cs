namespace Final_Fantasy_Tabletop_Application_Suite.src.interfaces
{
    internal interface ICharacter
    {
        public int CharacterId { get; }
        public string? Name { get; }
        public string? Race { get; }
        public string? Class { get; }
        public int LevelPoints { get; }
        public int[] CharacterStats { get; }
        public List<string>? Spells { get; }
        public List<string>? Skills { get; }
        public List<string>? Abilities { get; }
        public string? CharacterStory { get; set; }

    }
}
