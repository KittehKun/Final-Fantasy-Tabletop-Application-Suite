using System.Text.Json.Serialization;

namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class AscensionSkills : Skills
    {
        //Fields
        private string _ascensionPath; //Dictates what path a user takes

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
            this._ascensionPath = null!; //Placeholder until ascension path is set.
        }

        //Properties
        public string AscensionPath { get { return _ascensionPath; } }
        public new int Level { get; set; }
        public new string Name { get; set; }
        public new string Type { get; set; }
        public new string Potency { get; set; }
        public new string Cooldown { get; set; }
        public new string Target { get; set; }
        public new string Description { get; set; }

        //Methods
        /// <summary>
        /// Sets the Charachter's ascension path.
        /// </summary>
        /// <param name="ascensionPath">The ascension path. Checked for valid ascension path.</param>
        public void SetAscensionPath(string ascensionPath)
        {
            this._ascensionPath = ascensionPath;
        }
    }
}
