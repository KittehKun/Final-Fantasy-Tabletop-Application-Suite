using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class Skills
    {
        /// <summary>
        /// Initializes a new instance of a Skill. Has the JsonConstructor attribute for JSON serialization and deserialization.
        /// </summary>
        /// <param name="Level">A skills' current level.</param>
        /// <param name="Name">The skill name.</param>
        /// <param name="Type">The skills' type of attack.</param>
        /// <param name="Potency">The potency of the skill.</param>
        /// <param name="Cooldown">The cooldown of the skill.</param>
        /// <param name="Target">The amount of targets a skill will affect.</param>
        /// <param name="Description">The brief description of the skill.</param>
        [JsonConstructor]
        public Skills(int Level, string Name, string Type, string Potency, string Cooldown, string Target, string Description)
        {
            this.Level = Level;
            this.Name = Name;
            this.Type = Type;
            this.Potency = Potency;
            this.Cooldown = Cooldown;
            this.Target = Target;
            this.Description = Description;
        }

        public int Level { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Potency { get; set; }
        public string Cooldown { get; set; }
        public string Target { get; set; }
        public string Description { get; set; }
    }
}
