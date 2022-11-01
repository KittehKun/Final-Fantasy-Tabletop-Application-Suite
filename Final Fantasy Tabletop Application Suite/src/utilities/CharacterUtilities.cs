using Final_Fantasy_Tabletop_Application_Suite.src.classes;
using System.Diagnostics;
using System.Text.Json;

namespace Final_Fantasy_Tabletop_Application_Suite.src.utilities
{
    internal class CharacterUtilities
    {
        private static string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitteh's Application Suite/Jared's Final Fantasy Tabletop RPG/characters/");

        //Method will create a .JSON file and save it to documents
        public static void Save(Character character)
        {
            string fileName = $"{character.Name}.json";
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(character, options);
            Debug.WriteLine(json);
            Debug.WriteLine(fileName);

            Directory.CreateDirectory(savePath); //Returns Directory Info if already exists

            File.WriteAllText($"{savePath}{fileName}", json);
        }

        //Method will attempt to load .JSON file from documents
        public static Character? Load(string characterName)
        {
            string fileName = $"{characterName}.json";
            try
            {
                string loadPath = Path.Combine(savePath, fileName);
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };
                string jsonContents = File.ReadAllText(loadPath);

                var character = JsonSerializer.Deserialize<Character>(jsonContents);

                Debug.WriteLine(jsonContents);
                Debug.WriteLine("\nCharacter Loaded!");

                return character;
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                MessageBox.Show($"ERROR: {error.Message}\n\nThe character file may not exist.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
