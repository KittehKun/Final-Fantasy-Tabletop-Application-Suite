using Final_Fantasy_Tabletop_Application_Suite.forms;
using Final_Fantasy_Tabletop_Application_Suite.forms.calculators;
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

        /// <summary>
        /// Exits the application.
        /// </summary>
        private void toolbarExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Opens Character Creation form.
        /// </summary>
        /// <param name="sender">The object that fired current event.</param>
        /// <param name="e">The current event.</param>
        private void toolbarCreateCharacter_Click(object sender, EventArgs e)
        {
            CreateCharacter createCharacter = new(); //Creates new form object
            this.Visible = false;
            createCharacter.ShowDialog();
            this.Visible = true;
        }

        /// <summary>
        /// Opens Character Creation form.
        /// </summary>
        /// <param name="sender">The object that fired current event.</param>
        /// <param name="e">The current event.</param>
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            //CreateCharacter createCharacter = new(); //Creates new form object
            this.Visible = false;
            _ = new CreateCharacter().ShowDialog(); //Refactored from above line
            this.Visible = true;
        }

        /// <summary>
        /// Opens Load Character form.
        /// </summary>
        /// <param name="sender">The object that fired current event.</param>
        /// <param name="e">The current event.</param>
        private void btnLoadCharacter_Click(object sender, EventArgs e)
        {
            //Open LoadCharacter.cs form
            this.Visible = false;
            _ = new LoadCharacter().ShowDialog(); //Discard value used just for calling the form
            this.Visible = true;
        }

        /// <summary>
        /// Opens Windows built-in calculator.
        /// </summary>
        /// <param name="sender">The object that fired current event.</param>
        /// <param name="e">The current event.</param>
        private void btnRegularCalculator_Click(object sender, EventArgs e)
        {
            Process.Start("Calc"); //Starts Windows Calculator
        }

        /// <summary>
        /// Opens a form asking which character to delete.
        /// </summary>
        /// <param name="sender">The object that fired current event.</param>
        /// <param name="e">The current event.</param>
        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            //Open DeleteCharacter.cs form
            this.Visible = false;
            _ = new DeleteCharacter().ShowDialog();
            this.Visible = true;
        }

        /// <summary>
        /// Opens a moveable form for attack calculations.
        /// </summary>
        /// <param name="sender">The object that fired current event.</param>
        /// <param name="e">The current event.</param>
        private void btnAttackCalculator_Click(object sender, EventArgs e)
        {
            //This event handler will not hide the main form.
            Attack atkCalc = new Attack();
            if ((Application.OpenForms["Attack"] as Attack) != null)
            {
                Debug.WriteLine("Attack Calculator form is already open.");
                return;
            }

            atkCalc.Show();
        }
    }
}