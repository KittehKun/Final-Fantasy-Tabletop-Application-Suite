using Final_Fantasy_Tabletop_Application_Suite.src.classes;
using Final_Fantasy_Tabletop_Application_Suite.src.utilities;
using System.Diagnostics;

namespace Final_Fantasy_Tabletop_Application_Suite
{
    public partial class CreateCharacter : Form
    {
        private int statPoints;
        private int currentHPPoints, currentMPPoints, currentSTRPoints, currentMAGPoints, currentDEXPoints, currentDEFPoints, currentSPRPoints;
        private Character? character;

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
            else
            {
                MessageBox.Show("Character must have a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string characterRace;
            if (!String.IsNullOrEmpty(comboBoxRaces.SelectedItem.ToString()))
            {
                characterRace = comboBoxRaces.SelectedItem.ToString()!;
            }
            else
            {
                MessageBox.Show("Character must have a race.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string characterPrimaryClass;
            if (!String.IsNullOrEmpty(comboBoxClasses.SelectedItem.ToString()))
            {
                characterPrimaryClass = comboBoxClasses.SelectedItem.ToString()!;
            }
            else
            {
                MessageBox.Show("Character must have a class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string? characterStory;
            characterStory = txtCharacterStory.Text;

            int[] skills = new int[7]; // | HP | MP | STR | MAG | DEF | DEX | SPR |
            skills[0] = int.Parse(statHP.Text);
            skills[1] = int.Parse(statMP.Text);
            skills[2] = int.Parse(statSTR.Text);
            skills[3] = int.Parse(statMAG.Text);
            skills[4] = int.Parse(statDEX.Text);
            skills[5] = int.Parse(statDEF.Text);
            skills[6] = int.Parse(statSPR.Text);

            int levelPoints = int.Parse(statRemaining.Text);

            this.character = new Character(characterName, characterRace, characterPrimaryClass, levelPoints, skills); //Creates a Character

            this.character.CharacterStory = characterStory; //Sets backstory
            Debug.WriteLine("Character Created with the following information:");
            Debug.WriteLine($"Character Name: {this.character.Name}");
            Debug.WriteLine($"Race: {this.character.Race}");
            Debug.WriteLine($"Primary Class: {this.character.Class}");
            Debug.WriteLine($"Level Points: {this.character.LevelPoints}");

            CharacterSlots.characters.Add(this.character);
            SaveCharacter.Save(this.character);
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

        private void btnMAGPlus_Click(object sender, EventArgs e)
        {
            if (this.statPoints > 0)
            {
                this.currentMAGPoints++;
                this.statPoints--;
                statMAG.Text = this.currentMAGPoints.ToString();
                this.statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnDEXPlus_Click(object sender, EventArgs e)
        {
            if (this.statPoints > 0)
            {
                this.currentDEXPoints++;
                this.statPoints--;
                statDEX.Text = this.currentDEXPoints.ToString();
                this.statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnDEXMinus_Click(object sender, EventArgs e)
        {
            if (this.currentDEXPoints > 0)
            {
                this.currentDEXPoints--;
                this.statPoints++;
                statDEX.Text = this.currentDEXPoints.ToString();
                statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnDEFPlus_Click(object sender, EventArgs e)
        {
            if (this.statPoints > 0)
            {
                this.currentDEFPoints++;
                this.statPoints--;
                statDEF.Text = this.currentDEFPoints.ToString();
                this.statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnDEFMinus_Click(object sender, EventArgs e)
        {
            if (this.currentDEFPoints > 0)
            {
                this.currentDEFPoints--;
                this.statPoints++;
                statDEF.Text = this.currentDEFPoints.ToString();
                statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnSPRPlus_Click(object sender, EventArgs e)
        {
            if (this.statPoints > 0)
            {
                this.currentSPRPoints++;
                this.statPoints--;
                statSPR.Text = this.currentSPRPoints.ToString();
                this.statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnSPRMinus_Click(object sender, EventArgs e)
        {
            if (this.currentSPRPoints > 0)
            {
                this.currentSPRPoints--;
                this.statPoints++;
                statSPR.Text = this.currentSPRPoints.ToString();
                statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnMAGMinus_Click(object sender, EventArgs e)
        {
            if (this.currentSTRPoints > 0)
            {
                this.currentMAGPoints--;
                this.statPoints++;
                statMAG.Text = this.currentMAGPoints.ToString();
                statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnSTRPlus_Click(object sender, EventArgs e)
        {
            if (this.statPoints > 0)
            {
                this.currentSTRPoints++;
                this.statPoints--;
                statSTR.Text = this.currentSTRPoints.ToString();
                this.statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

        private void btnSTRMinus_Click(object sender, EventArgs e)
        {
            if (this.currentSTRPoints > 0)
            {
                this.currentSTRPoints--;
                this.statPoints++;
                statSTR.Text = this.currentSTRPoints.ToString();
                statRemaining.Text = this.statPoints.ToString();
            }
            else
            {
                return;
            }
        }

    }
}
