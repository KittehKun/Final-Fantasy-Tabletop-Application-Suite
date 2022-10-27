using Final_Fantasy_Tabletop_Application_Suite.src.classes;
using System.Diagnostics;

namespace Final_Fantasy_Tabletop_Application_Suite.src.utilities
{
    internal class LoadCharacter
    {
        private Character character;
        private static string loadPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitteh's Application Suite/Jared's Final Fantasy Tabletop RPG/characters/");

        //Loads .JSON from documents folder
        public static void Load(string characterName)
        {
            string fileName = $"{characterName}.json";
            loadPath = Path.Combine(loadPath, characterName);
            string jsonContents = File.ReadAllText(loadPath);
            Debug.WriteLine(jsonContents);
            Debug.WriteLine("\nCharacter Loaded!");
        }
    }
}
