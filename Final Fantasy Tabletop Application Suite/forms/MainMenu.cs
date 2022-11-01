using Final_Fantasy_Tabletop_Application_Suite.src.utilities;
using System.Diagnostics;

namespace Final_Fantasy_Tabletop_Application_Suite
{
    public partial class MainMenu : Form
    {
        private readonly string savePath;
        public MainMenu()
        {
            InitializeComponent();

            //Create a Directory in Documents if none exists
            Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitteh's Application Suite/Jared's Final Fantasy Tabletop RPG/"));

            this.savePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Kitteh's Application Suite/Jared's Final Fantasy Tabletop RPG/");
            Debug.WriteLine(savePath);
        }

        private void toolbarExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void toolbarCreateCharacter_Click(object sender, EventArgs e)
        {
            CreateCharacter createCharacter = new(); //Creates new form object
            this.Visible = false;
            createCharacter.ShowDialog();
            this.Visible = true;
        }

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            //CreateCharacter createCharacter = new(); //Creates new form object
            this.Visible = false;
            _ = new CreateCharacter().ShowDialog(); //Refactored from above line
            this.Visible = true;
        }

        private void btnLoadCharacter_Click(object sender, EventArgs e)
        {
            //Test Load Character and print out string that is grabbed
            var character = CharacterUtilities.Load("KittehKun")!; //Expected Output: KittehKun.json if exists
            if (character != null) //Check if Character was properly loaded
            {
                this.Visible = false;
                _ = new LoadCharacter().ShowDialog(); //Discard value used just for calling the form
                this.Visible = true;
            }
        }

        private void btnRegularCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("Calc"); //Starts Windows Calculator
        }
    }
}