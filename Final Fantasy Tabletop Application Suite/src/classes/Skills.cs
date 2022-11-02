namespace Final_Fantasy_Tabletop_Application_Suite.src.classes
{
    internal class Skills
    {
        //Properties
        private int level;
        private string name;
        private string type;
        private string potency;
        private string cooldown;
        private string target;
        private string description;

        public Skills(int level, string name, string type, string potency, string cooldown, string target, string description)
        {
            this.level = level;
            this.name = name;
            this.type = type;
            this.potency = potency;
            this.cooldown = cooldown;
            this.target = target;
            this.description = description;
        }

        public int Level { get => level; set => level = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Potency { get => potency; set => potency = value; }
        public string Cooldown { get => cooldown; set => cooldown = value; }
        public string Target { get => target; set => target = value; }
        public string Description { get => description; set => description = value; }
    }
}
