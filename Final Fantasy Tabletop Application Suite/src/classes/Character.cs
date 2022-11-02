using Final_Fantasy_Tabletop_Application_Suite.src.interfaces;
using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class Character : ICharacter
    {
        //Fields
        private List<string> inventory;

        //Interface
        public string Name { get; private set; }

        public string Race { get; private set; }

        public string Class { get; private set; }

        public int LevelPoints { get; private set; }

        public int[] CharacterStats { get; private set; }

        public List<string>? Spells { get; private set; }

        public List<Skills>? Skills { get; private set; }

        public List<string>? Abilities { get; private set; }

        public string? CharacterStory { get; set; }

        //Constructor - Creates Character Object
        /// <summary>
        /// Initializes an instance of the <c>Character</c> class.
        /// </summary>
        /// <param name="name">The character's name.</param>
        /// <param name="race">The character's race.</param>
        /// <param name="class">The character's primary class.</param>
        /// <param name="levelpoints">The character's current available leveling points.</param>
        /// <param name="stats">The character's stats.</param>
        public Character(string name, string race, string @class, int levelpoints, int[] stats)
        {
            this.Name = name;
            this.Race = race;
            this.Class = @class;
            this.LevelPoints = levelpoints;
            this.CharacterStats = new int[7]; // | HP | MP | STR | MAG | DEF | DEX | SPR |
            this.CharacterStats = stats;
            this.inventory = new List<string>();
        }

        [JsonConstructor] //Constructor arguments MUST match the properties of the class otherwise an unhandled exception will occur
        public Character(string Name, string Race, string @Class, int LevelPoints, int[] CharacterStats, List<string> Spells, List<Skills> Skills, List<string> Abilities, string CharacterStory, List<string> inventory)
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
            this.inventory = inventory;
        }

        //Methods
        /// <summary>
        /// Gets a Character's inventory.
        /// </summary>
        /// <returns>A List of strings.</returns>
        public List<string> GetInventory()
        {
            return this.inventory;
        }

        /// <summary>
        /// Adds an item to a Character's inventory. Prompts for confirmation.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        public void AddToInventory(string item)
        {
            DialogResult result = MessageBox.Show($"Add {item} to inventory?", "INFO", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.inventory.Add(item);
                return;
            }
            return;
        }
    }
}
