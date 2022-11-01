using Final_Fantasy_Tabletop_Application_Suite.src.classes;
using Final_Fantasy_Tabletop_Application_Suite.src.utilities;
using System.Diagnostics;

namespace Final_Fantasy_Tabletop_Application_Suite
{
    public partial class LoadCharacter : Form
    {
        private List<Character> characters;

        public LoadCharacter()
        {
            InitializeComponent();
            this.characters = new List<Character>();
            SelectCharacter();
        }

        //Method will populate form with all the Characters found in the Documents folder
        private void SelectCharacter()
        {
            //Find all .JSON files in Documents folder
            try
            {
                string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitteh's Application Suite/Jared's Final Fantasy Tabletop RPG/characters/");
                string[] files = Directory.GetFiles(path, "*.json"); //Search only for JSON files

                if (files.Length != 0) //Check if empty array was returned
                {
                    //Loop through all files that were found in the Documents folder
                    foreach (string filePath in files)
                    {
                        string characterName = Path.GetFileNameWithoutExtension(filePath);
                        var character = CharacterUtilities.Load(characterName);

                        if (character != null) //Check if Characters were loaded properly
                        {
                            characters.Add(character);
                            Debug.WriteLine($"{characterName} was loaded to the list!");
                        }
                    }

                    var grid = dataGridCharacters;
                    //Add loaded characters into DataGrid component
                    foreach (Character character in characters)
                    {
                        string[] row = { $"{character.Name}", $"{character.Race}", $"{character.Class}", $"{character.LevelPoints}" };
                        grid.Rows.Add(row);
                    }
                    return;
                }
                MessageBox.Show("WARNING: No characters found.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception error)
            {
                MessageBox.Show($"ERROR: {error.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridCharacters_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var characterRow = dataGridCharacters.Rows[e.RowIndex];
            var characterName = characterRow.Cells[0].Value.ToString(); //Expected Output: Character Name of row selected
            Debug.WriteLine(characterName);

            //Check if a character name was grabbed
            if (String.IsNullOrEmpty(characterName))
            {
                Debug.WriteLine("Loading super mega ultra character!!!");
            }
        }
    }
}
