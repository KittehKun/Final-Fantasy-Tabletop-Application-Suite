namespace Final_Fantasy_Tabletop_Application_Suite
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.toolbarMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolbarFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbarImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarCreate = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolbarCreateCharacter = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxCharTools = new System.Windows.Forms.GroupBox();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.btnLoadCharacter = new System.Windows.Forms.Button();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.groupBoxCalculators = new System.Windows.Forms.GroupBox();
            this.btnRegularCalculator = new System.Windows.Forms.Button();
            this.btnDefenseCalculator = new System.Windows.Forms.Button();
            this.btnAttackCalculator = new System.Windows.Forms.Button();
            this.toolbarMainMenu.SuspendLayout();
            this.groupBoxCharTools.SuspendLayout();
            this.groupBoxCalculators.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbarMainMenu
            // 
            this.toolbarMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarFile,
            this.toolbarCreate});
            this.toolbarMainMenu.Location = new System.Drawing.Point(0, 0);
            this.toolbarMainMenu.Name = "toolbarMainMenu";
            this.toolbarMainMenu.Size = new System.Drawing.Size(784, 25);
            this.toolbarMainMenu.TabIndex = 0;
            this.toolbarMainMenu.Text = "toolStrip1";
            // 
            // toolbarFile
            // 
            this.toolbarFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarImport,
            this.toolbarExport,
            this.toolbarExit});
            this.toolbarFile.Image = ((System.Drawing.Image)(resources.GetObject("toolbarFile.Image")));
            this.toolbarFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarFile.Name = "toolbarFile";
            this.toolbarFile.Size = new System.Drawing.Size(38, 22);
            this.toolbarFile.Text = "File";
            // 
            // toolbarImport
            // 
            this.toolbarImport.Name = "toolbarImport";
            this.toolbarImport.Size = new System.Drawing.Size(119, 22);
            this.toolbarImport.Text = "Import...";
            this.toolbarImport.ToolTipText = "Import a character.";
            // 
            // toolbarExport
            // 
            this.toolbarExport.Name = "toolbarExport";
            this.toolbarExport.Size = new System.Drawing.Size(119, 22);
            this.toolbarExport.Text = "Export...";
            this.toolbarExport.ToolTipText = "Export a character.";
            // 
            // toolbarExit
            // 
            this.toolbarExit.Name = "toolbarExit";
            this.toolbarExit.Size = new System.Drawing.Size(119, 22);
            this.toolbarExit.Text = "Exit";
            this.toolbarExit.ToolTipText = "Exit the application.";
            this.toolbarExit.Click += new System.EventHandler(this.toolbarExit_Click);
            // 
            // toolbarCreate
            // 
            this.toolbarCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolbarCreate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolbarCreateCharacter});
            this.toolbarCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolbarCreate.Image")));
            this.toolbarCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbarCreate.Name = "toolbarCreate";
            this.toolbarCreate.Size = new System.Drawing.Size(54, 22);
            this.toolbarCreate.Text = "Create";
            // 
            // toolbarCreateCharacter
            // 
            this.toolbarCreateCharacter.Name = "toolbarCreateCharacter";
            this.toolbarCreateCharacter.Size = new System.Drawing.Size(134, 22);
            this.toolbarCreateCharacter.Text = "Character...";
            this.toolbarCreateCharacter.ToolTipText = "Create a new character.";
            this.toolbarCreateCharacter.Click += new System.EventHandler(this.toolbarCreateCharacter_Click);
            // 
            // groupBoxCharTools
            // 
            this.groupBoxCharTools.BackColor = System.Drawing.Color.White;
            this.groupBoxCharTools.Controls.Add(this.btnDeleteCharacter);
            this.groupBoxCharTools.Controls.Add(this.btnLoadCharacter);
            this.groupBoxCharTools.Controls.Add(this.btnCreateCharacter);
            this.groupBoxCharTools.Location = new System.Drawing.Point(24, 48);
            this.groupBoxCharTools.Name = "groupBoxCharTools";
            this.groupBoxCharTools.Size = new System.Drawing.Size(736, 240);
            this.groupBoxCharTools.TabIndex = 1;
            this.groupBoxCharTools.TabStop = false;
            this.groupBoxCharTools.Text = "Character Tools";
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Location = new System.Drawing.Point(520, 40);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(192, 176);
            this.btnDeleteCharacter.TabIndex = 2;
            this.btnDeleteCharacter.Text = "Delete Character";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            // 
            // btnLoadCharacter
            // 
            this.btnLoadCharacter.Location = new System.Drawing.Point(272, 40);
            this.btnLoadCharacter.Name = "btnLoadCharacter";
            this.btnLoadCharacter.Size = new System.Drawing.Size(192, 176);
            this.btnLoadCharacter.TabIndex = 1;
            this.btnLoadCharacter.Text = "Load Character";
            this.btnLoadCharacter.UseVisualStyleBackColor = true;
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Location = new System.Drawing.Point(24, 40);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(192, 176);
            this.btnCreateCharacter.TabIndex = 0;
            this.btnCreateCharacter.Text = "Create Character";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // groupBoxCalculators
            // 
            this.groupBoxCalculators.BackColor = System.Drawing.Color.White;
            this.groupBoxCalculators.Controls.Add(this.btnRegularCalculator);
            this.groupBoxCalculators.Controls.Add(this.btnDefenseCalculator);
            this.groupBoxCalculators.Controls.Add(this.btnAttackCalculator);
            this.groupBoxCalculators.Location = new System.Drawing.Point(24, 304);
            this.groupBoxCalculators.Name = "groupBoxCalculators";
            this.groupBoxCalculators.Size = new System.Drawing.Size(736, 240);
            this.groupBoxCalculators.TabIndex = 2;
            this.groupBoxCalculators.TabStop = false;
            this.groupBoxCalculators.Text = "Calculators";
            // 
            // btnRegularCalculator
            // 
            this.btnRegularCalculator.Location = new System.Drawing.Point(520, 40);
            this.btnRegularCalculator.Name = "btnRegularCalculator";
            this.btnRegularCalculator.Size = new System.Drawing.Size(192, 176);
            this.btnRegularCalculator.TabIndex = 5;
            this.btnRegularCalculator.Text = "Regular Calculator";
            this.btnRegularCalculator.UseVisualStyleBackColor = true;
            // 
            // btnDefenseCalculator
            // 
            this.btnDefenseCalculator.Location = new System.Drawing.Point(272, 40);
            this.btnDefenseCalculator.Name = "btnDefenseCalculator";
            this.btnDefenseCalculator.Size = new System.Drawing.Size(192, 176);
            this.btnDefenseCalculator.TabIndex = 4;
            this.btnDefenseCalculator.Text = "Defense Calculator";
            this.btnDefenseCalculator.UseVisualStyleBackColor = true;
            // 
            // btnAttackCalculator
            // 
            this.btnAttackCalculator.Location = new System.Drawing.Point(24, 40);
            this.btnAttackCalculator.Name = "btnAttackCalculator";
            this.btnAttackCalculator.Size = new System.Drawing.Size(192, 176);
            this.btnAttackCalculator.TabIndex = 3;
            this.btnAttackCalculator.Text = "Attack Calculator";
            this.btnAttackCalculator.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBoxCalculators);
            this.Controls.Add(this.groupBoxCharTools);
            this.Controls.Add(this.toolbarMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.toolbarMainMenu.ResumeLayout(false);
            this.toolbarMainMenu.PerformLayout();
            this.groupBoxCharTools.ResumeLayout(false);
            this.groupBoxCalculators.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolbarMainMenu;
        private ToolStripDropDownButton toolbarFile;
        private ToolStripMenuItem toolbarImport;
        private ToolStripMenuItem toolbarExport;
        private ToolStripMenuItem toolbarExit;
        private ToolStripDropDownButton toolbarCreate;
        private ToolStripMenuItem toolbarCreateCharacter;
        private GroupBox groupBoxCharTools;
        private GroupBox groupBoxCalculators;
        private Button btnDeleteCharacter;
        private Button btnLoadCharacter;
        private Button btnCreateCharacter;
        private Button btnRegularCalculator;
        private Button btnDefenseCalculator;
        private Button btnAttackCalculator;
    }
}