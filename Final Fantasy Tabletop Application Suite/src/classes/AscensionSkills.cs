using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{

    internal class AscensionSkills : Skills
    {
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
