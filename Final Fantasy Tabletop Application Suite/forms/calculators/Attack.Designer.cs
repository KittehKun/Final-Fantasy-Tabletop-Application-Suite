namespace Final_Fantasy_Tabletop_Application_Suite.forms.calculators
{
    partial class Attack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblDiceSides = new System.Windows.Forms.Label();
            this.txtDiceSides = new System.Windows.Forms.TextBox();
            this.lblDice = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtFinalStat = new System.Windows.Forms.TextBox();
            this.lblFinalStat = new System.Windows.Forms.Label();
            this.btnMythicPoint = new System.Windows.Forms.Button();
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtDiceAmount = new System.Windows.Forms.TextBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.txtPotency = new System.Windows.Forms.TextBox();
            this.lblPotency = new System.Windows.Forms.Label();
            this.lblDamageCalculator = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.lblResult);
            this.panelContent.Controls.Add(this.txtResult);
            this.panelContent.Controls.Add(this.lblDiceSides);
            this.panelContent.Controls.Add(this.txtDiceSides);
            this.panelContent.Controls.Add(this.lblDice);
            this.panelContent.Controls.Add(this.txtTotal);
            this.panelContent.Controls.Add(this.lblTotal);
            this.panelContent.Controls.Add(this.btnCalculate);
            this.panelContent.Controls.Add(this.txtFinalStat);
            this.panelContent.Controls.Add(this.lblFinalStat);
            this.panelContent.Controls.Add(this.btnMythicPoint);
            this.panelContent.Controls.Add(this.btnRoll);
            this.panelContent.Controls.Add(this.txtDiceAmount);
            this.panelContent.Controls.Add(this.lblRoll);
            this.panelContent.Controls.Add(this.txtPotency);
            this.panelContent.Controls.Add(this.lblPotency);
            this.panelContent.Controls.Add(this.lblDamageCalculator);
            this.panelContent.Location = new System.Drawing.Point(16, 16);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(304, 584);
            this.panelContent.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(32, 300);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(57, 21);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(96, 296);
            this.txtResult.Name = "txtResult";
            this.txtResult.PlaceholderText = "0";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(176, 29);
            this.txtResult.TabIndex = 15;
            this.txtResult.TabStop = false;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDiceSides
            // 
            this.lblDiceSides.AutoSize = true;
            this.lblDiceSides.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiceSides.Location = new System.Drawing.Point(40, 264);
            this.lblDiceSides.Name = "lblDiceSides";
            this.lblDiceSides.Size = new System.Drawing.Size(49, 21);
            this.lblDiceSides.TabIndex = 14;
            this.lblDiceSides.Text = "Sided";
            // 
            // txtDiceSides
            // 
            this.txtDiceSides.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiceSides.Location = new System.Drawing.Point(96, 260);
            this.txtDiceSides.Name = "txtDiceSides";
            this.txtDiceSides.PlaceholderText = "Enter number of sides...";
            this.txtDiceSides.Size = new System.Drawing.Size(176, 29);
            this.txtDiceSides.TabIndex = 5;
            // 
            // lblDice
            // 
            this.lblDice.AutoSize = true;
            this.lblDice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDice.Location = new System.Drawing.Point(48, 228);
            this.lblDice.Name = "lblDice";
            this.lblDice.Size = new System.Drawing.Size(40, 21);
            this.lblDice.TabIndex = 12;
            this.lblDice.Text = "Dice";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(40, 536);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(240, 29);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TabStop = false;
            this.txtTotal.Text = "Kitteh\'s Placeholder Data";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(40, 496);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 39);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Enabled = false;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(72, 440);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(176, 40);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtFinalStat
            // 
            this.txtFinalStat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFinalStat.Location = new System.Drawing.Point(40, 392);
            this.txtFinalStat.Name = "txtFinalStat";
            this.txtFinalStat.PlaceholderText = "Enter final stat here...";
            this.txtFinalStat.Size = new System.Drawing.Size(240, 29);
            this.txtFinalStat.TabIndex = 6;
            // 
            // lblFinalStat
            // 
            this.lblFinalStat.AutoSize = true;
            this.lblFinalStat.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinalStat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFinalStat.Location = new System.Drawing.Point(40, 352);
            this.lblFinalStat.Name = "lblFinalStat";
            this.lblFinalStat.Size = new System.Drawing.Size(113, 29);
            this.lblFinalStat.TabIndex = 7;
            this.lblFinalStat.Text = "Final Stat";
            // 
            // btnMythicPoint
            // 
            this.btnMythicPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMythicPoint.Location = new System.Drawing.Point(168, 184);
            this.btnMythicPoint.Name = "btnMythicPoint";
            this.btnMythicPoint.Size = new System.Drawing.Size(107, 31);
            this.btnMythicPoint.TabIndex = 3;
            this.btnMythicPoint.Text = "Use Mythic Point";
            this.btnMythicPoint.UseVisualStyleBackColor = true;
            this.btnMythicPoint.Click += new System.EventHandler(this.btnMythicPoint_Click);
            // 
            // btnRoll
            // 
            this.btnRoll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoll.Location = new System.Drawing.Point(104, 184);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(56, 31);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtDiceAmount
            // 
            this.txtDiceAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiceAmount.Location = new System.Drawing.Point(96, 224);
            this.txtDiceAmount.Name = "txtDiceAmount";
            this.txtDiceAmount.PlaceholderText = "Enter amount of dice...";
            this.txtDiceAmount.Size = new System.Drawing.Size(176, 29);
            this.txtDiceAmount.TabIndex = 4;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.Color.Transparent;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRoll.Location = new System.Drawing.Point(40, 184);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(56, 29);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "Roll";
            // 
            // txtPotency
            // 
            this.txtPotency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPotency.Location = new System.Drawing.Point(40, 128);
            this.txtPotency.Name = "txtPotency";
            this.txtPotency.PlaceholderText = "Enter attack/spell potency here...";
            this.txtPotency.Size = new System.Drawing.Size(240, 29);
            this.txtPotency.TabIndex = 1;
            // 
            // lblPotency
            // 
            this.lblPotency.AutoSize = true;
            this.lblPotency.BackColor = System.Drawing.Color.Transparent;
            this.lblPotency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPotency.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPotency.Location = new System.Drawing.Point(40, 88);
            this.lblPotency.Name = "lblPotency";
            this.lblPotency.Size = new System.Drawing.Size(99, 29);
            this.lblPotency.TabIndex = 1;
            this.lblPotency.Text = "Potency";
            // 
            // lblDamageCalculator
            // 
            this.lblDamageCalculator.AutoSize = true;
            this.lblDamageCalculator.BackColor = System.Drawing.Color.Transparent;
            this.lblDamageCalculator.Font = new System.Drawing.Font("Calibri", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDamageCalculator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDamageCalculator.Location = new System.Drawing.Point(16, 16);
            this.lblDamageCalculator.Name = "lblDamageCalculator";
            this.lblDamageCalculator.Size = new System.Drawing.Size(278, 41);
            this.lblDamageCalculator.TabIndex = 0;
            this.lblDamageCalculator.Text = "Damage Calculator";
            // 
            // Attack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(339, 611);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Attack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attack Calculator";
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelContent;
        private Label lblDamageCalculator;
        private Label lblPotency;
        private TextBox txtPotency;
        private TextBox txtDiceAmount;
        private Label lblRoll;
        private Button btnMythicPoint;
        private Button btnRoll;
        private TextBox txtFinalStat;
        private Label lblFinalStat;
        private Button btnCalculate;
        private Label lblTotal;
        private TextBox txtTotal;
        private Label lblDice;
        private Label lblDiceSides;
        private TextBox txtDiceSides;
        private Label lblResult;
        private TextBox txtResult;
    }
}