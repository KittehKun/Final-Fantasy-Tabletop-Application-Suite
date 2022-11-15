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
        /// Initializes a <c>CreateCharacter</c> instance. This is used for building the GUI.
        /// </summary>
        public CreateCharacter()
        {
            InitializeComponent();
            comboBoxRaces.SelectedItem = "Hume"; //Default value
            comboBoxClasses.SelectedItem = "Archer"; //Default value
            this.statPoints = 18; //Default 18 stat points to allocate
            statRemaining.Text = this.statPoints.ToString();
        }

        /// <summary>
        /// Closes the current form.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Processes a new character for saving. The form will be verified to make sure all fields were filled in correctly.
        /// </summary>
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            ValidateCharacter();
        }

        /// <summary>
        /// Verifies that all inputs are valid for character creation. This method is used to scan the form to make sure there are no errors. If any errors are found, the method returns and a MessageBox is created.
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
            this.character.SetSkills(skills);

            CharacterUtilities.Save(this.character);

            Close();
        }

        /// <summary>
        /// Uses CharacterUtilities to fill a newly created character with abilities. Creates List objects that will be used to pass onto the utilities class.
        /// </summary>
        /// <param name="characterClass">A character's primary class.</param>
        /// <returns>A List of Skills objects.</returns>
        private List<Skills> ProcessSkills(string characterClass)
        {
            List<Skills> skills = new List<Skills>(); //FOR TESTING PURPOSES
            List<AscensionSkills> ascensionSkills = new List<AscensionSkills>(); //FOR TESTING PURPOSES
            switch (characterClass)
            {
                case "Archer":
                    skills = CharacterUtilities.LoadSkills(characterClass);
                    //ascensionSkills = CharacterUtilities.LoadAscensionSkills(characterClass, "Gunner"); //FOR TESTING PURPOSES
                    //this.character!.SetAscensionSkills(ascensionSkills);
                    break;
                case "Marauder":
                    skills = CharacterUtilities.LoadSkills(characterClass);
                    //ascensionSkills = CharacterUtilities.LoadAscensionSkills(characterClass, "Paladin"); //FOR TESTING PURPOSES
                    //this.character!.SetAscensionSkills(ascensionSkills);
                    break;
                case "Lancer":
                    skills = CharacterUtilities.LoadSkills(characterClass);
                    //ascensionSkills = CharacterUtilities.LoadAscensionSkills(characterClass, "ChocoboKnight"); //FOR TESTING PURPOSES
                    //this.character!.SetAscensionSkills(ascensionSkills);
                    break;
                default:
                    Debug.WriteLine("KittehKun your code is broken. Fix it~");
                    break;
            }

            return skills;
        }

        /// <summary>
        /// Increases the Character's HP stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Decreases the Character's HP stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Increases the Character's MP stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Decreases the Character's MP stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Increases the Character's MAG stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Increases the Character's DEX stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Decreases the Character's DEX stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Increases the Character's DEF stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Decreases the Character's DEF stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Increases the Character's SPR stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Decreases the Character's SPR stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Decreases the Character's MAG stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Increases the Character's STR stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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

        /// <summary>
        /// Decreases the Character's STR stat by one.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
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
