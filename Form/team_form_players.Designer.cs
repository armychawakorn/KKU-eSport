namespace KKU_ESport
{
    partial class team_form_players
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridView_Team = new System.Windows.Forms.DataGridView();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.team_form_player_submit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Team)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // GridView_Team
            // 
            this.GridView_Team.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Team.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridName,
            this.GridLastname,
            this.GridStudentID,
            this.GridMajor,
            this.GridGameName,
            this.Team,
            this.GridEmail,
            this.GridTell,
            this.GridAge});
            this.GridView_Team.Location = new System.Drawing.Point(12, 27);
            this.GridView_Team.Name = "GridView_Team";
            this.GridView_Team.RowTemplate.Height = 25;
            this.GridView_Team.Size = new System.Drawing.Size(940, 358);
            this.GridView_Team.TabIndex = 2;
            // 
            // GridName
            // 
            this.GridName.HeaderText = "ชื่อ";
            this.GridName.Name = "GridName";
            this.GridName.ReadOnly = true;
            // 
            // GridLastname
            // 
            this.GridLastname.HeaderText = "นามสกุล";
            this.GridLastname.Name = "GridLastname";
            this.GridLastname.ReadOnly = true;
            // 
            // GridStudentID
            // 
            this.GridStudentID.HeaderText = "รหัสนักศึกษา";
            this.GridStudentID.Name = "GridStudentID";
            this.GridStudentID.ReadOnly = true;
            // 
            // GridMajor
            // 
            this.GridMajor.HeaderText = "สาขา";
            this.GridMajor.Name = "GridMajor";
            this.GridMajor.ReadOnly = true;
            // 
            // GridGameName
            // 
            this.GridGameName.HeaderText = "ชื่อในเกม";
            this.GridGameName.Name = "GridGameName";
            this.GridGameName.ReadOnly = true;
            // 
            // Team
            // 
            this.Team.HeaderText = "ทีม";
            this.Team.Name = "Team";
            this.Team.ReadOnly = true;
            // 
            // GridEmail
            // 
            this.GridEmail.HeaderText = "อีเมล";
            this.GridEmail.Name = "GridEmail";
            this.GridEmail.ReadOnly = true;
            // 
            // GridTell
            // 
            this.GridTell.HeaderText = "เบอร์โทรศัพท์";
            this.GridTell.Name = "GridTell";
            this.GridTell.ReadOnly = true;
            // 
            // GridAge
            // 
            this.GridAge.HeaderText = "อายุ";
            this.GridAge.Name = "GridAge";
            this.GridAge.ReadOnly = true;
            // 
            // team_form_player_submit
            // 
            this.team_form_player_submit.Location = new System.Drawing.Point(436, 402);
            this.team_form_player_submit.Name = "team_form_player_submit";
            this.team_form_player_submit.Size = new System.Drawing.Size(75, 23);
            this.team_form_player_submit.TabIndex = 3;
            this.team_form_player_submit.Text = "Add";
            this.team_form_player_submit.UseVisualStyleBackColor = true;
            this.team_form_player_submit.Click += new System.EventHandler(this.team_form_player_submit_Click);
            // 
            // team_form_players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.team_form_player_submit);
            this.Controls.Add(this.GridView_Team);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(988, 489);
            this.MinimumSize = new System.Drawing.Size(988, 489);
            this.Name = "team_form_players";
            this.Text = "Players";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Team)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private DataGridView GridView_Team;
        private DataGridViewTextBoxColumn GridName;
        private DataGridViewTextBoxColumn GridLastname;
        private DataGridViewTextBoxColumn GridStudentID;
        private DataGridViewTextBoxColumn GridMajor;
        private DataGridViewTextBoxColumn GridGameName;
        private DataGridViewTextBoxColumn Team;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridTell;
        private DataGridViewTextBoxColumn GridAge;
        private Button team_form_player_submit;
    }
}