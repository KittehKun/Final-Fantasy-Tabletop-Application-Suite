namespace Final_Fantasy_Tabletop_Application_Suite
{
    public partial class CreateCharacter : Form
    {
        private int statPoints;
        private int currentHPPoints, currentMPPoints;
        public CreateCharacter()
        {
            InitializeComponent();
            comboBoxRaces.SelectedItem = "Hume";
            comboBoxClasses.SelectedItem = "Archer";
            this.statPoints = 18; //Default 18 stat points to allocate
            statRemaining.Text = this.statPoints.ToString();

            //Stat Points
            this.currentHPPoints = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            ValidateCharacter();
        }

        //Method will verify that all inputs are entered
        private void ValidateCharacter()
        {
            string characterName;
            if (!String.IsNullOrEmpty(txtCharName.Text))
            {
                characterName = txtCharName.Text;
            }

            string characterRace;
            if (!String.IsNullOrEmpty(comboBoxRaces.SelectedText))
            {
                characterRace = comboBoxRaces.SelectedText;
            }

            string characterPrimaryClass;
            if (!String.IsNullOrEmpty(comboBoxClasses.SelectedText))
            {
                characterPrimaryClass = comboBoxClasses.SelectedText;
            }

            string? characterStory;
            characterStory = txtCharacterStory.Text;

        }

        private void btnHPPlus_Click(object sender, EventArgs e)
        {
            if (this.statPoints > 0)
            {
                this.currentHPPoints++;
                this.statPoints--;
                statHP.Text = this.currentHPPoints.ToString();
                this.statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnHPMinus_Click(object sender, EventArgs e)
        {
            if (this.currentHPPoints > 0)
            {
                this.currentHPPoints--;
                this.statPoints++;
                statHP.Text = this.currentHPPoints.ToString();
                statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnMPMinus_Click(object sender, EventArgs e)
        {
            if (this.currentMPPoints > 0)
            {
                this.currentMPPoints--;
                this.statPoints++;
                statMP.Text = this.currentMPPoints.ToString();
                statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnMPPlus_Click(object sender, EventArgs e)
        {
            if (this.statPoints > 0)
            {
                this.currentMPPoints++;
                this.statPoints--;
                statMP.Text = this.currentMPPoints.ToString();
                this.statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }
    }
}
