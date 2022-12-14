namespace Final_Fantasy_Tabletop_Application_Suite.forms.calculators
{
    public partial class Attack : Form
    {
        private readonly Random _d20;
        private int _potency, _diceAmount, _diceSides, _diceResult, _finalStat;
        private double _total;
        private bool _isMultiRoll;

        /// <summary>
        /// Initializes a new instance of the Attack form. This constructor is used to build the GUI.
        /// </summary>
        public Attack()
        {
            InitializeComponent();
            txtTotal.PlaceholderText = "0";
            txtTotal.Text = "";
            this._d20 = new();
        }

        /// <summary>
        /// Uses session mythic point. Restores on reinitializing form.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e"></param>
        private void btnMythicPoint_Click(object sender, EventArgs e)
        {

            //Check if Roll is available
            if (btnRoll.Enabled)
            {
                MessageBox.Show("You already have a roll available.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("Use session mythic point?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                btnMythicPoint.Enabled = false;
                btnRoll.Enabled = true;
                txtDiceAmount.Text = "";
                txtDiceSides.Text = "";
                txtResult.Text = "";
                ResetFields();
            }

        }

        /// <summary>
        /// Calculates the attack based on potency, the roll, and final stat.
        /// </summary>
        /// <param name="sender">The object that fired the event.</param>
        /// <param name="e">The event's arguments.</param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                _total = (double)_potency / 10 * _diceResult * _finalStat / 100; //Formula follows order of operations - no parenthesis needed
                txtTotal.Text = String.Format("{0:0.00}", _total); //"D2" signfies 2 decimal points
                ResetFields();
                btnCalculate.Enabled = false;
                btnRoll.Enabled = true;
            }
        }

        /// <summary>
        /// Rolls a D20 dice and populates the text field. Supports multi-dice and rolls and will display a dialog showing each individual roll before updating the total of all rolls.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRoll_Click(object sender, EventArgs e)
        {
            //Check if txtDiceAmount and txtDiceSides are empty or null first before rolling
            if (String.IsNullOrEmpty(txtDiceAmount.Text) || String.IsNullOrEmpty(txtDiceSides.Text))
            {
                MessageBox.Show("Dice parameters must be filled before rolling.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _diceSides = int.Parse(txtDiceSides.Text) + 1; //Max Value
                _diceAmount = int.Parse(txtDiceAmount.Text); //Amount of dice being rolled

                if (_diceSides == 1)
                {
                    MessageBox.Show("You can't roll a 1 sided dice forehead.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Roll dice depending on the number of dice given
                List<int> rolls = new(_diceAmount);
                if (_diceAmount > 1)
                {
                    _isMultiRoll = true;
                }

                do
                {
                    rolls.Add(RollDice(_diceSides));
                    _diceAmount--; //Subtract the die that was rolled
                } while (_diceAmount != 0); //Check if there are any dice left to roll

                btnRoll.Enabled = false;

                //Show MessageBox if it was a multi-dice roll
                if (_isMultiRoll)
                {
                    string multiRoll = String.Join(", ", rolls);
                    MessageBox.Show($"[ {multiRoll} ]", "Multi-Roll Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //Add up the running total of all dice rolls
                foreach (int roll in rolls)
                {
                    _diceResult += roll;
                }

                _isMultiRoll = false; //Reset flag
                txtResult.Text = _diceResult.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show($"Dice fields must be numbers.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        /// <summary>
        /// Rolls a dice given the number of sides. This method uses the Random object filling in the minimum and maximum value.
        /// </summary>
        /// <param name="maxValue">The number of sides the dice will have.</param>
        /// <returns>A random <c>int</c> from 1 to the <c>upperBound</c>. Max value is inclusive in calculation.</returns>
        private int RollDice(int maxValue)
        {
            btnCalculate.Enabled = true;
            return _d20.Next(1, maxValue);
        }

        /// <summary>
        /// Checks current form if all TextBoxes are filled properly. If any errors are found, this method will return false.
        /// </summary>
        /// <returns><c>true</c> only if all fields were filled in correctly. Otherwise, returns <c>false</c>.</returns>
        private bool ValidateFields()
        {
            //Set _potency variable from form
            if (String.IsNullOrEmpty(txtPotency.Text) || !int.TryParse(txtPotency.Text, out _potency)) // True | False
            {
                MessageBox.Show("Potency field must be numbers.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //Set dice result from form
            if (String.IsNullOrEmpty(txtResult.Text) || !int.TryParse(txtResult.Text, out _diceResult))
            {
                return false;
            }

            //Set _finalStat from form
            if (String.IsNullOrEmpty(txtFinalStat.Text) || !int.TryParse(txtFinalStat.Text, out _finalStat))
            {
                return false;
            }

            //Return true if all fields are valid
            return true;
        }

        /// <summary>
        /// Resets all current variable fields back to zero. This method is used after calculation to reset the form.
        /// </summary>
        private void ResetFields()
        {
            _diceAmount = 0;
            _diceSides = 0;
            _diceResult = 0;
            _potency = 0;
            _finalStat = 0;
            _total = 0;
        }
    }
}
