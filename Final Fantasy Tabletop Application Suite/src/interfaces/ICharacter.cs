using Final_Fantasy_Tabletop_Application_Suite.src.classes;

namespace Final_Fantasy_Tabletop_Application_Suite.src.interfaces
{
    internal interface ICharacter
    {
        /// <summary>
        /// A Character's Name.
        /// </summary>
        public string? Name { get; }

        /// <summary>
        /// A Character's Race.
        /// </summary>
        public string? Race { get; }

        /// <summary>
        /// A Character's Primary Class.
        /// </summary>
        public string? Class { get; }

        /// <summary>
        /// The amount of current levelling points a Character has at a given time.
        /// </summary>
        public int LevelPoints { get; }

        /// <summary>
        /// The Character's Stats. In the current system, all Characters have the following -> | HP | MP | STR | MAG | DEF | DEX | SPR |
        /// </summary>
        public int[] CharacterStats { get; }

        /// <summary>
        /// A Character's list of Spells that they have unlocked.
        /// </summary>
        public List<string>? Spells { get; }

        /// <summary>
        /// A Character's list of Skills that they have unlocked. Does not include ascension skills.
        /// </summary>
        public List<Skills>? Skills { get; } //Abilities classified here as skills

        /// <summary>
        /// A Character's story should a user decide to import a story to the Character.
        /// </summary>
        public string? CharacterStory { get; set; }

    }
}
