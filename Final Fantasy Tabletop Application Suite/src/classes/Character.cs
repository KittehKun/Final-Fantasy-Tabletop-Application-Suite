using Final_Fantasy_Tabletop_Application_Suite.src.interfaces;
using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class Character : ICharacter
    {
        //Fields
        private List<string> _inventory;

        //Interface
        public string Name { get; private set; }

        public int Level { get; set; } //Added Property not from Interface

        public string Race { get; private set; }

        public string Class { get; private set; }

        public int LevelPoints { get; private set; }

        public int[] CharacterStats { get; private set; }

        public List<string>? Spells { get; private set; }

        public List<Skills>? Skills { get; private set; } //Abilities classified here as skills

        public string? CharacterStory { get; set; }

        public List<string> Inventory { get => _inventory; }

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
            this.Level = 1; //Start at Level 1 on character creation
            this.Race = race;
            this.Class = @class;
            this.LevelPoints = levelpoints;
            this.CharacterStats = new int[7]; // | HP | MP | STR | MAG | DEF | DEX | SPR |
            this.CharacterStats = stats;
            this._inventory = new List<string>();
        }

        [JsonConstructor] //Constructor arguments MUST match the properties of the class otherwise an unhandled exception will occur
        public Character(string Name, int Level, string Race, string @Class, int LevelPoints, int[] CharacterStats, List<string> Spells, List<Skills> Skills, string CharacterStory, List<string> inventory)
        {
            this.Name = Name;
            this.Level = Level;
            this.Race = Race;
            this.Class = @Class;
            this.LevelPoints = LevelPoints;
            this.CharacterStats = CharacterStats;
            this.Spells = Spells;
            this.Skills = Skills;
            this.CharacterStory = CharacterStory;
            this._inventory = inventory;
        }

        //Methods
        /// <summary>
        /// Gets a Character's inventory.
        /// </summary>
        /// <returns>A List of strings.</returns>
        public List<string> GetInventory()
        {
            return this._inventory;
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
                this._inventory.Add(item);
                return;
            }
            return;
        }

        public void SetSkills(List<Skills> skills)
        {
            this.Skills = skills;
        }
    }
}
