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

        /// <summary>
        /// Initializes a <c>CreateCharacter</c> instance.
        /// </summary>
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

        /// <summary>
        /// Closes the current form.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Processes a new character for saving.
        /// </summary>
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            ValidateCharacter();
        }

        /// <summary>
        /// Verifies that all inputs are valid for character creation.
        /// </summary>
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

            int[] stats = new int[7]; // | HP | MP | STR | MAG | DEF | DEX | SPR |
            stats[0] = int.Parse(statHP.Text);
            stats[1] = int.Parse(statMP.Text);
            stats[2] = int.Parse(statSTR.Text);
            stats[3] = int.Parse(statMAG.Text);
            stats[4] = int.Parse(statDEX.Text);
            stats[5] = int.Parse(statDEF.Text);
            stats[6] = int.Parse(statSPR.Text);

            int levelPoints = int.Parse(statRemaining.Text);

            this.character = new Character(characterName, characterRace, characterPrimaryClass, levelPoints, stats); //Creates a Character

            this.character.CharacterStory = characterStory; //Sets backstory

            //The following methods are class specific
            List<Skills> skills = ProcessSkills(characterPrimaryClass);
            foreach (Skills skill in skills)
            {
                Debug.WriteLine(skill.Name); //Expected Output: Up to level 30 skills
            }

            CharacterUtilities.Save(this.character);

            Close();
        }

        private List<Skills> ProcessSkills(string characterClass)
        {
            List<Skills> skills = new List<Skills>();
            switch (characterClass)
            {
                case "Archer":
                    skills = CharacterUtilities.LoadSkills(characterClass);
                    break;
                default:
                    Debug.WriteLine("KittehKun your code is broken. Fix it~");
                    break;
            }

            return skills;
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
