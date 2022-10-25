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
            this.toolbarMainMenu.SuspendLayout();
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
            this.toolbarImport.Size = new System.Drawing.Size(180, 22);
            this.toolbarImport.Text = "Import...";
            this.toolbarImport.ToolTipText = "Import a character.";
            // 
            // toolbarExport
            // 
            this.toolbarExport.Name = "toolbarExport";
            this.toolbarExport.Size = new System.Drawing.Size(180, 22);
            this.toolbarExport.Text = "Export...";
            this.toolbarExport.ToolTipText = "Export a character.";
            // 
            // toolbarExit
            // 
            this.toolbarExit.Name = "toolbarExit";
            this.toolbarExit.Size = new System.Drawing.Size(180, 22);
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
            this.toolbarCreateCharacter.Size = new System.Drawing.Size(180, 22);
            this.toolbarCreateCharacter.Text = "Character...";
            this.toolbarCreateCharacter.ToolTipText = "Create a new character.";
            this.toolbarCreateCharacter.Click += new System.EventHandler(this.toolbarCreateCharacter_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.toolbarMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.toolbarMainMenu.ResumeLayout(false);
            this.toolbarMainMenu.PerformLayout();
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
    }
}