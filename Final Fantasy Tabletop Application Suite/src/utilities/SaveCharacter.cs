using Final_Fantasy_Tabletop_Application_Suite.src.classes;
using System.Diagnostics;
using System.Text.Json;

namespace Final_Fantasy_Tabletop_Application_Suite.src.utilities
{
    internal class SaveCharacter
    {
        private static string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitteh's Application Suite/Jared's Final Fantasy Tabletop RPG/characters/");

        //Method will create a .JSON file and save it to documents
        public static void Save(Character character)
        {
            string fileName = $"{character.Name}.json";
            string json = JsonSerializer.Serialize(character);
            Debug.WriteLine(json);
            Debug.WriteLine(fileName);

            Directory.CreateDirectory(savePath); //Returns Directory Info if already exists

            savePath += fileName;

            File.WriteAllText(savePath, json);
        }
    }
}
