using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{

    internal class AscensionSkills : Skills
    {
        /// <summary>
        /// This constructor is used only with the JsonSerializer in order to populate a Character's ascension skills. Ascension skills will only be loaded once a character chooses an ascension path.
        /// </summary>
        /// <param name="Level">A skills' current level.</param>
        /// <param name="Name">The skill name.</param>
        /// <param name="Type">The skills' type of attack.</param>
        /// <param name="Potency">The potency of the skill.</param>
        /// <param name="Cooldown">The cooldown of the skill.</param>
        /// <param name="Target">The amount of targets a skill will affect.</param>
        /// <param name="Description">The brief description of the skill.</param>
        [JsonConstructor]
        public AscensionSkills(int Level, string Name, string Type, string Potency, string Cooldown, string Target, string Description) : base(Level, Name, Type, Potency, Cooldown, Target, Description)
        {
            this.Level = Level;
            this.Name = Name;
            this.Type = Type;
            this.Potency = Potency;
            this.Cooldown = Cooldown;
            this.Target = Target;
            this.Description = Description;
        }

        //Properties
        public new int Level { get; set; }
        public new string Name { get; set; }
        public new string Type { get; set; }
        public new string Potency { get; set; }
        public new string Cooldown { get; set; }
        public new string Target { get; set; }
        public new string Description { get; set; }
    }
}
