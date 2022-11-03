namespace Final_Fantasy_Tabletop_Application_Suite.forms
{
    partial class DeleteCharacter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridCharacters = new System.Windows.Forms.DataGridView();
            this.CharacterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterRace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CharacterLevelPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCharacters)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.dataGridCharacters);
            this.panel1.Location = new System.Drawing.Point(32, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 512);
            this.panel1.TabIndex = 0;
            // 
            // dataGridCharacters
            // 
            this.dataGridCharacters.AllowUserToAddRows = false;
            this.dataGridCharacters.AllowUserToDeleteRows = false;
            this.dataGridCharacters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCharacters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCharacters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCharacters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CharacterName,
            this.CharacterRace,
            this.CharacterClass,
            this.CharacterLevelPoints});
            this.dataGridCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCharacters.Location = new System.Drawing.Point(0, 0);
            this.dataGridCharacters.Name = "dataGridCharacters";
            this.dataGridCharacters.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridCharacters.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridCharacters.RowTemplate.Height = 25;
            this.dataGridCharacters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridCharacters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCharacters.Size = new System.Drawing.Size(520, 512);
            this.dataGridCharacters.TabIndex = 1;
            // 
            // CharacterName
            // 
            this.CharacterName.HeaderText = "Name";
            this.CharacterName.Name = "CharacterName";
            this.CharacterName.ReadOnly = true;
            this.CharacterName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CharacterName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CharacterRace
            // 
            this.CharacterRace.HeaderText = "Race";
            this.CharacterRace.Name = "CharacterRace";
            this.CharacterRace.ReadOnly = true;
            // 
            // CharacterClass
            // 
            this.CharacterClass.HeaderText = "Class";
            this.CharacterClass.Name = "CharacterClass";
            this.CharacterClass.ReadOnly = true;
            // 
            // CharacterLevelPoints
            // 
            this.CharacterLevelPoints.HeaderText = "Level Points";
            this.CharacterLevelPoints.Name = "CharacterLevelPoints";
            this.CharacterLevelPoints.ReadOnly = true;
            // 
            // DeleteCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteCharacter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Character";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCharacters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridCharacters;
        private DataGridViewTextBoxColumn CharacterName;
        private DataGridViewTextBoxColumn CharacterRace;
        private DataGridViewTextBoxColumn CharacterClass;
        private DataGridViewTextBoxColumn CharacterLevelPoints;
    }
}