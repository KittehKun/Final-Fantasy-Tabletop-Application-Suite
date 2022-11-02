using Final_Fantasy_Tabletop_Application_Suite.src.classes;
using System.Diagnostics;
using System.Text.Json;

namespace Final_Fantasy_Tabletop_Application_Suite.src.utilities
{
    internal class CharacterUtilities
    {
        private static string savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitteh's Application Suite/Jared's Final Fantasy Tabletop RPG/characters/");

        /// <summary>
        /// Saves a <c>Character</c> object into a JSON file located in a user's documents folder.
        /// </summary>
        /// <param name="character">A Character object.</param>
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

        /// <summary>
        /// Loads a character's JSON file in a user's documents folder. Finds the character by their name.
        /// </summary>
        /// <param name="characterName">A Character's name that will be used to search for the JSON.</param>
        /// <returns>A <c>Character</c> object. Returns <c>null</c> if no character is found.</returns>
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

                //Debug.WriteLine(jsonContents);
                return character;
            }
            catch (Exception error)
            {
                Debug.WriteLine(error.Message);
                MessageBox.Show($"ERROR: {error.Message}", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }
    }
}
