namespace Final_Fantasy_Tabletop_Application_Suite
{
    partial class CreateCharacter
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
            this.lblCharName = new System.Windows.Forms.Label();
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.comboBoxRaces = new System.Windows.Forms.ComboBox();
            this.comboBoxClasses = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblCharacterStory = new System.Windows.Forms.Label();
            this.txtCharacterStory = new System.Windows.Forms.TextBox();
            this.panelCharStats = new System.Windows.Forms.Panel();
            this.btnSPRPlus = new System.Windows.Forms.Button();
            this.btnSPRMinus = new System.Windows.Forms.Button();
            this.statSPR = new System.Windows.Forms.Label();
            this.btnDEFPlus = new System.Windows.Forms.Button();
            this.btnDEFMinus = new System.Windows.Forms.Button();
            this.statDEF = new System.Windows.Forms.Label();
            this.btnDEXPlus = new System.Windows.Forms.Button();
            this.btnDEXMinus = new System.Windows.Forms.Button();
            this.statDEX = new System.Windows.Forms.Label();
            this.btnMAGPlus = new System.Windows.Forms.Button();
            this.btnMAGMinus = new System.Windows.Forms.Button();
            this.statMAG = new System.Windows.Forms.Label();
            this.btnSTRPlus = new System.Windows.Forms.Button();
            this.btnSTRMinus = new System.Windows.Forms.Button();
            this.statSTR = new System.Windows.Forms.Label();
            this.btnMPPlus = new System.Windows.Forms.Button();
            this.btnMPMinus = new System.Windows.Forms.Button();
            this.statMP = new System.Windows.Forms.Label();
            this.btnHPPlus = new System.Windows.Forms.Button();
            this.btnHPMinus = new System.Windows.Forms.Button();
            this.statHP = new System.Windows.Forms.Label();
            this.lblStatSPR = new System.Windows.Forms.Label();
            this.lblStatDEF = new System.Windows.Forms.Label();
            this.lblStatDEX = new System.Windows.Forms.Label();
            this.lblStatMAG = new System.Windows.Forms.Label();
            this.lblStatSTR = new System.Windows.Forms.Label();
            this.lblStatMP = new System.Windows.Forms.Label();
            this.lblStatHP = new System.Windows.Forms.Label();
            this.lblCharStatsTitle = new System.Windows.Forms.Label();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStatRemainingPoints = new System.Windows.Forms.Label();
            this.statRemaining = new System.Windows.Forms.Label();
            this.panelCharStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharName.Location = new System.Drawing.Point(32, 32);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(170, 30);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Character Name";
            // 
            // txtCharName
            // 
            this.txtCharName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCharName.Location = new System.Drawing.Point(32, 64);
            this.txtCharName.MaxLength = 256;
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(272, 32);
            this.txtCharName.TabIndex = 1;
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRace.Location = new System.Drawing.Point(32, 120);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(59, 30);
            this.lblRace.TabIndex = 2;
            this.lblRace.Text = "Race";
            // 
            // comboBoxRaces
            // 
            this.comboBoxRaces.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxRaces.FormattingEnabled = true;
            this.comboBoxRaces.Items.AddRange(new object[] {
            "Hume",
            "Au\'Ra",
            "Lalafell",
            "The Qu",
            "Elves",
            "Ronso",
            "Hypello",
            "Jumi"});
            this.comboBoxRaces.Location = new System.Drawing.Point(32, 152);
            this.comboBoxRaces.Name = "comboBoxRaces";
            this.comboBoxRaces.Size = new System.Drawing.Size(272, 33);
            this.comboBoxRaces.TabIndex = 2;
            // 
            // comboBoxClasses
            // 
            this.comboBoxClasses.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxClasses.FormattingEnabled = true;
            this.comboBoxClasses.Items.AddRange(new object[] {
            "Archer",
            "Marauder",
            "Lancer",
            "Thief",
            "Thaumaturge",
            "Red Mage",
            "Mender",
            "Summoner",
            "Fighter"});
            this.comboBoxClasses.Location = new System.Drawing.Point(32, 240);
            this.comboBoxClasses.Name = "comboBoxClasses";
            this.comboBoxClasses.Size = new System.Drawing.Size(272, 33);
            this.comboBoxClasses.TabIndex = 3;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClass.Location = new System.Drawing.Point(32, 208);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(141, 30);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Primary Class";
            // 
            // lblCharacterStory
            // 
            this.lblCharacterStory.AutoSize = true;
            this.lblCharacterStory.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharacterStory.Location = new System.Drawing.Point(32, 296);
            this.lblCharacterStory.Name = "lblCharacterStory";
            this.lblCharacterStory.Size = new System.Drawing.Size(162, 30);
            this.lblCharacterStory.TabIndex = 5;
            this.lblCharacterStory.Text = "Character Story";
            // 
            // txtCharacterStory
            // 
            this.txtCharacterStory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCharacterStory.Location = new System.Drawing.Point(32, 328);
            this.txtCharacterStory.Multiline = true;
            this.txtCharacterStory.Name = "txtCharacterStory";
            this.txtCharacterStory.Size = new System.Drawing.Size(272, 320);
            this.txtCharacterStory.TabIndex = 6;
            // 
            // panelCharStats
            // 
            this.panelCharStats.BackColor = System.Drawing.Color.White;
            this.panelCharStats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCharStats.Controls.Add(this.btnSPRPlus);
            this.panelCharStats.Controls.Add(this.btnSPRMinus);
            this.panelCharStats.Controls.Add(this.statSPR);
            this.panelCharStats.Controls.Add(this.btnDEFPlus);
            this.panelCharStats.Controls.Add(this.btnDEFMinus);
            this.panelCharStats.Controls.Add(this.statDEF);
            this.panelCharStats.Controls.Add(this.btnDEXPlus);
            this.panelCharStats.Controls.Add(this.btnDEXMinus);
            this.panelCharStats.Controls.Add(this.statDEX);
            this.panelCharStats.Controls.Add(this.btnMAGPlus);
            this.panelCharStats.Controls.Add(this.btnMAGMinus);
            this.panelCharStats.Controls.Add(this.statMAG);
            this.panelCharStats.Controls.Add(this.btnSTRPlus);
            this.panelCharStats.Controls.Add(this.btnSTRMinus);
            this.panelCharStats.Controls.Add(this.statSTR);
            this.panelCharStats.Controls.Add(this.btnMPPlus);
            this.panelCharStats.Controls.Add(this.btnMPMinus);
            this.panelCharStats.Controls.Add(this.statMP);
            this.panelCharStats.Controls.Add(this.btnHPPlus);
            this.panelCharStats.Controls.Add(this.btnHPMinus);
            this.panelCharStats.Controls.Add(this.statHP);
            this.panelCharStats.Controls.Add(this.lblStatSPR);
            this.panelCharStats.Controls.Add(this.lblStatDEF);
            this.panelCharStats.Controls.Add(this.lblStatDEX);
            this.panelCharStats.Controls.Add(this.lblStatMAG);
            this.panelCharStats.Controls.Add(this.lblStatSTR);
            this.panelCharStats.Controls.Add(this.lblStatMP);
            this.panelCharStats.Controls.Add(this.lblStatHP);
            this.panelCharStats.Controls.Add(this.lblCharStatsTitle);
            this.panelCharStats.Location = new System.Drawing.Point(336, 32);
            this.panelCharStats.Name = "panelCharStats";
            this.panelCharStats.Size = new System.Drawing.Size(320, 344);
            this.panelCharStats.TabIndex = 7;
            // 
            // btnSPRPlus
            // 
            this.btnSPRPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSPRPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSPRPlus.Location = new System.Drawing.Point(256, 288);
            this.btnSPRPlus.Name = "btnSPRPlus";
            this.btnSPRPlus.Size = new System.Drawing.Size(35, 24);
            this.btnSPRPlus.TabIndex = 28;
            this.btnSPRPlus.Text = "+";
            this.btnSPRPlus.UseVisualStyleBackColor = true;
            // 
            // btnSPRMinus
            // 
            this.btnSPRMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSPRMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSPRMinus.Location = new System.Drawing.Point(184, 288);
            this.btnSPRMinus.Name = "btnSPRMinus";
            this.btnSPRMinus.Size = new System.Drawing.Size(35, 24);
            this.btnSPRMinus.TabIndex = 27;
            this.btnSPRMinus.Text = "-";
            this.btnSPRMinus.UseVisualStyleBackColor = true;
            // 
            // statSPR
            // 
            this.statSPR.AutoSize = true;
            this.statSPR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statSPR.Location = new System.Drawing.Point(228, 288);
            this.statSPR.Name = "statSPR";
            this.statSPR.Size = new System.Drawing.Size(19, 21);
            this.statSPR.TabIndex = 26;
            this.statSPR.Text = "0";
            // 
            // btnDEFPlus
            // 
            this.btnDEFPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDEFPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDEFPlus.Location = new System.Drawing.Point(256, 248);
            this.btnDEFPlus.Name = "btnDEFPlus";
            this.btnDEFPlus.Size = new System.Drawing.Size(35, 24);
            this.btnDEFPlus.TabIndex = 25;
            this.btnDEFPlus.Text = "+";
            this.btnDEFPlus.UseVisualStyleBackColor = true;
            // 
            // btnDEFMinus
            // 
            this.btnDEFMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDEFMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDEFMinus.Location = new System.Drawing.Point(184, 248);
            this.btnDEFMinus.Name = "btnDEFMinus";
            this.btnDEFMinus.Size = new System.Drawing.Size(35, 24);
            this.btnDEFMinus.TabIndex = 24;
            this.btnDEFMinus.Text = "-";
            this.btnDEFMinus.UseVisualStyleBackColor = true;
            // 
            // statDEF
            // 
            this.statDEF.AutoSize = true;
            this.statDEF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statDEF.Location = new System.Drawing.Point(228, 248);
            this.statDEF.Name = "statDEF";
            this.statDEF.Size = new System.Drawing.Size(19, 21);
            this.statDEF.TabIndex = 23;
            this.statDEF.Text = "0";
            // 
            // btnDEXPlus
            // 
            this.btnDEXPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDEXPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDEXPlus.Location = new System.Drawing.Point(256, 208);
            this.btnDEXPlus.Name = "btnDEXPlus";
            this.btnDEXPlus.Size = new System.Drawing.Size(35, 24);
            this.btnDEXPlus.TabIndex = 22;
            this.btnDEXPlus.Text = "+";
            this.btnDEXPlus.UseVisualStyleBackColor = true;
            // 
            // btnDEXMinus
            // 
            this.btnDEXMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDEXMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDEXMinus.Location = new System.Drawing.Point(184, 208);
            this.btnDEXMinus.Name = "btnDEXMinus";
            this.btnDEXMinus.Size = new System.Drawing.Size(35, 24);
            this.btnDEXMinus.TabIndex = 21;
            this.btnDEXMinus.Text = "-";
            this.btnDEXMinus.UseVisualStyleBackColor = true;
            // 
            // statDEX
            // 
            this.statDEX.AutoSize = true;
            this.statDEX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statDEX.Location = new System.Drawing.Point(228, 208);
            this.statDEX.Name = "statDEX";
            this.statDEX.Size = new System.Drawing.Size(19, 21);
            this.statDEX.TabIndex = 20;
            this.statDEX.Text = "0";
            // 
            // btnMAGPlus
            // 
            this.btnMAGPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMAGPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMAGPlus.Location = new System.Drawing.Point(256, 168);
            this.btnMAGPlus.Name = "btnMAGPlus";
            this.btnMAGPlus.Size = new System.Drawing.Size(35, 24);
            this.btnMAGPlus.TabIndex = 19;
            this.btnMAGPlus.Text = "+";
            this.btnMAGPlus.UseVisualStyleBackColor = true;
            // 
            // btnMAGMinus
            // 
            this.btnMAGMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMAGMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMAGMinus.Location = new System.Drawing.Point(184, 168);
            this.btnMAGMinus.Name = "btnMAGMinus";
            this.btnMAGMinus.Size = new System.Drawing.Size(35, 24);
            this.btnMAGMinus.TabIndex = 18;
            this.btnMAGMinus.Text = "-";
            this.btnMAGMinus.UseVisualStyleBackColor = true;
            // 
            // statMAG
            // 
            this.statMAG.AutoSize = true;
            this.statMAG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statMAG.Location = new System.Drawing.Point(228, 168);
            this.statMAG.Name = "statMAG";
            this.statMAG.Size = new System.Drawing.Size(19, 21);
            this.statMAG.TabIndex = 17;
            this.statMAG.Text = "0";
            // 
            // btnSTRPlus
            // 
            this.btnSTRPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSTRPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSTRPlus.Location = new System.Drawing.Point(256, 128);
            this.btnSTRPlus.Name = "btnSTRPlus";
            this.btnSTRPlus.Size = new System.Drawing.Size(35, 24);
            this.btnSTRPlus.TabIndex = 16;
            this.btnSTRPlus.Text = "+";
            this.btnSTRPlus.UseVisualStyleBackColor = true;
            // 
            // btnSTRMinus
            // 
            this.btnSTRMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSTRMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSTRMinus.Location = new System.Drawing.Point(184, 128);
            this.btnSTRMinus.Name = "btnSTRMinus";
            this.btnSTRMinus.Size = new System.Drawing.Size(35, 24);
            this.btnSTRMinus.TabIndex = 15;
            this.btnSTRMinus.Text = "-";
            this.btnSTRMinus.UseVisualStyleBackColor = true;
            // 
            // statSTR
            // 
            this.statSTR.AutoSize = true;
            this.statSTR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statSTR.Location = new System.Drawing.Point(228, 128);
            this.statSTR.Name = "statSTR";
            this.statSTR.Size = new System.Drawing.Size(19, 21);
            this.statSTR.TabIndex = 14;
            this.statSTR.Text = "0";
            // 
            // btnMPPlus
            // 
            this.btnMPPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMPPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMPPlus.Location = new System.Drawing.Point(256, 88);
            this.btnMPPlus.Name = "btnMPPlus";
            this.btnMPPlus.Size = new System.Drawing.Size(35, 24);
            this.btnMPPlus.TabIndex = 13;
            this.btnMPPlus.Text = "+";
            this.btnMPPlus.UseVisualStyleBackColor = true;
            this.btnMPPlus.Click += new System.EventHandler(this.btnMPPlus_Click);
            // 
            // btnMPMinus
            // 
            this.btnMPMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMPMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMPMinus.Location = new System.Drawing.Point(184, 88);
            this.btnMPMinus.Name = "btnMPMinus";
            this.btnMPMinus.Size = new System.Drawing.Size(35, 24);
            this.btnMPMinus.TabIndex = 12;
            this.btnMPMinus.Text = "-";
            this.btnMPMinus.UseVisualStyleBackColor = true;
            this.btnMPMinus.Click += new System.EventHandler(this.btnMPMinus_Click);
            // 
            // statMP
            // 
            this.statMP.AutoSize = true;
            this.statMP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statMP.Location = new System.Drawing.Point(228, 88);
            this.statMP.Name = "statMP";
            this.statMP.Size = new System.Drawing.Size(19, 21);
            this.statMP.TabIndex = 11;
            this.statMP.Text = "0";
            // 
            // btnHPPlus
            // 
            this.btnHPPlus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHPPlus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHPPlus.Location = new System.Drawing.Point(256, 48);
            this.btnHPPlus.Name = "btnHPPlus";
            this.btnHPPlus.Size = new System.Drawing.Size(35, 24);
            this.btnHPPlus.TabIndex = 10;
            this.btnHPPlus.Text = "+";
            this.btnHPPlus.UseVisualStyleBackColor = true;
            this.btnHPPlus.Click += new System.EventHandler(this.btnHPPlus_Click);
            // 
            // btnHPMinus
            // 
            this.btnHPMinus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHPMinus.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHPMinus.Location = new System.Drawing.Point(184, 48);
            this.btnHPMinus.Name = "btnHPMinus";
            this.btnHPMinus.Size = new System.Drawing.Size(35, 24);
            this.btnHPMinus.TabIndex = 9;
            this.btnHPMinus.Text = "-";
            this.btnHPMinus.UseVisualStyleBackColor = true;
            this.btnHPMinus.Click += new System.EventHandler(this.btnHPMinus_Click);
            // 
            // statHP
            // 
            this.statHP.AutoSize = true;
            this.statHP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statHP.Location = new System.Drawing.Point(228, 48);
            this.statHP.Name = "statHP";
            this.statHP.Size = new System.Drawing.Size(19, 21);
            this.statHP.TabIndex = 8;
            this.statHP.Text = "0";
            // 
            // lblStatSPR
            // 
            this.lblStatSPR.AutoSize = true;
            this.lblStatSPR.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatSPR.Location = new System.Drawing.Point(32, 288);
            this.lblStatSPR.Name = "lblStatSPR";
            this.lblStatSPR.Size = new System.Drawing.Size(50, 30);
            this.lblStatSPR.TabIndex = 7;
            this.lblStatSPR.Text = "SPR";
            // 
            // lblStatDEF
            // 
            this.lblStatDEF.AutoSize = true;
            this.lblStatDEF.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatDEF.Location = new System.Drawing.Point(32, 248);
            this.lblStatDEF.Name = "lblStatDEF";
            this.lblStatDEF.Size = new System.Drawing.Size(50, 30);
            this.lblStatDEF.TabIndex = 6;
            this.lblStatDEF.Text = "DEF";
            // 
            // lblStatDEX
            // 
            this.lblStatDEX.AutoSize = true;
            this.lblStatDEX.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatDEX.Location = new System.Drawing.Point(32, 208);
            this.lblStatDEX.Name = "lblStatDEX";
            this.lblStatDEX.Size = new System.Drawing.Size(52, 30);
            this.lblStatDEX.TabIndex = 5;
            this.lblStatDEX.Text = "DEX";
            // 
            // lblStatMAG
            // 
            this.lblStatMAG.AutoSize = true;
            this.lblStatMAG.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatMAG.Location = new System.Drawing.Point(32, 168);
            this.lblStatMAG.Name = "lblStatMAG";
            this.lblStatMAG.Size = new System.Drawing.Size(62, 30);
            this.lblStatMAG.TabIndex = 4;
            this.lblStatMAG.Text = "MAG";
            // 
            // lblStatSTR
            // 
            this.lblStatSTR.AutoSize = true;
            this.lblStatSTR.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatSTR.Location = new System.Drawing.Point(32, 128);
            this.lblStatSTR.Name = "lblStatSTR";
            this.lblStatSTR.Size = new System.Drawing.Size(50, 30);
            this.lblStatSTR.TabIndex = 3;
            this.lblStatSTR.Text = "STR";
            // 
            // lblStatMP
            // 
            this.lblStatMP.AutoSize = true;
            this.lblStatMP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatMP.Location = new System.Drawing.Point(32, 88);
            this.lblStatMP.Name = "lblStatMP";
            this.lblStatMP.Size = new System.Drawing.Size(45, 30);
            this.lblStatMP.TabIndex = 2;
            this.lblStatMP.Text = "MP";
            // 
            // lblStatHP
            // 
            this.lblStatHP.AutoSize = true;
            this.lblStatHP.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatHP.Location = new System.Drawing.Point(32, 48);
            this.lblStatHP.Name = "lblStatHP";
            this.lblStatHP.Size = new System.Drawing.Size(41, 30);
            this.lblStatHP.TabIndex = 1;
            this.lblStatHP.Text = "HP";
            // 
            // lblCharStatsTitle
            // 
            this.lblCharStatsTitle.AutoSize = true;
            this.lblCharStatsTitle.BackColor = System.Drawing.Color.White;
            this.lblCharStatsTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCharStatsTitle.Location = new System.Drawing.Point(120, 0);
            this.lblCharStatsTitle.Name = "lblCharStatsTitle";
            this.lblCharStatsTitle.Size = new System.Drawing.Size(88, 45);
            this.lblCharStatsTitle.TabIndex = 0;
            this.lblCharStatsTitle.Text = "Stats";
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateCharacter.Location = new System.Drawing.Point(496, 584);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(155, 55);
            this.btnCreateCharacter.TabIndex = 8;
            this.btnCreateCharacter.Text = "Create";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(328, 584);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 55);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStatRemainingPoints
            // 
            this.lblStatRemainingPoints.AutoSize = true;
            this.lblStatRemainingPoints.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatRemainingPoints.Location = new System.Drawing.Point(336, 384);
            this.lblStatRemainingPoints.Name = "lblStatRemainingPoints";
            this.lblStatRemainingPoints.Size = new System.Drawing.Size(203, 32);
            this.lblStatRemainingPoints.TabIndex = 10;
            this.lblStatRemainingPoints.Text = "Remaining Points:";
            // 
            // statRemaining
            // 
            this.statRemaining.AutoSize = true;
            this.statRemaining.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.statRemaining.Location = new System.Drawing.Point(552, 384);
            this.statRemaining.Name = "statRemaining";
            this.statRemaining.Size = new System.Drawing.Size(25, 30);
            this.statRemaining.TabIndex = 11;
            this.statRemaining.Text = "0";
            // 
            // CreateCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.statRemaining);
            this.Controls.Add(this.lblStatRemainingPoints);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateCharacter);
            this.Controls.Add(this.panelCharStats);
            this.Controls.Add(this.txtCharacterStory);
            this.Controls.Add(this.lblCharacterStory);
            this.Controls.Add(this.comboBoxClasses);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.comboBoxRaces);
            this.Controls.Add(this.lblRace);
            this.Controls.Add(this.txtCharName);
            this.Controls.Add(this.lblCharName);
            this.MaximizeBox = false;
            this.Name = "CreateCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Character";
            this.panelCharStats.ResumeLayout(false);
            this.panelCharStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblCharName;
        private TextBox txtCharName;
        private Label lblRace;
        private ComboBox comboBoxRaces;
        private ComboBox comboBoxClasses;
        private Label lblClass;
        private Label lblCharacterStory;
        private TextBox txtCharacterStory;
        private Panel panelCharStats;
        private Label lblCharStatsTitle;
        private Label lblStatHP;
        private Label lblStatMP;
        private Label lblStatSTR;
        private Label lblStatMAG;
        private Label lblStatDEX;
        private Label lblStatDEF;
        private Label lblStatSPR;
        private Label statHP;
        private Button btnHPMinus;
        private Button btnHPPlus;
        private Button btnMPPlus;
        private Button btnMPMinus;
        private Label statMP;
        private Button btnMAGPlus;
        private Button btnMAGMinus;
        private Label statMAG;
        private Button btnSTRPlus;
        private Button btnSTRMinus;
        private Label statSTR;
        private Button btnSPRPlus;
        private Button btnSPRMinus;
        private Label statSPR;
        private Button btnDEFPlus;
        private Button btnDEFMinus;
        private Label statDEF;
        private Button btnDEXPlus;
        private Button btnDEXMinus;
        private Label statDEX;
        private Button btnCreateCharacter;
        private Button btnCancel;
        private Label lblStatRemainingPoints;
        private Label statRemaining;
    }
}