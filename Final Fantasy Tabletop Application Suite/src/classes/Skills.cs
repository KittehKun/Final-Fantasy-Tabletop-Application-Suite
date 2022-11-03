using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class Skills
    {
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
