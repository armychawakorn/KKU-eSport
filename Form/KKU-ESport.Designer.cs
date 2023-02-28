namespace KKU_ESport
{
    partial class KKUESport
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
            this.playerMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.GridName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridGameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridTell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerMenuToolStripMenuItem,
            this.playerToolStripMenuItem,
            this.teamToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // playerMenuToolStripMenuItem
            // 
            this.playerMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.loadFileToolStripMenuItem});
            this.playerMenuToolStripMenuItem.Name = "playerMenuToolStripMenuItem";
            this.playerMenuToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.playerMenuToolStripMenuItem.Text = "File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveFileToolStripMenuItem.Text = "Save";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadFileToolStripMenuItem.Text = "Load";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlayerToolStripMenuItem});
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.playerToolStripMenuItem.Text = "Player";
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.addPlayerToolStripMenuItem.Text = "AddPlayer";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click_1);
            // 
            // teamToolStripMenuItem
            // 
            this.teamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageToolStripMenuItem});
            this.teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            this.teamToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.teamToolStripMenuItem.Text = "Team";
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.manageToolStripMenuItem.Text = "Manage";
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridName,
            this.GridLastname,
            this.GridStudentID,
            this.GridMajor,
            this.GridGameName,
            this.GridEmail,
            this.GridTell,
            this.GridAge});
            this.GridView.Location = new System.Drawing.Point(12, 27);
            this.GridView.Name = "GridView";
            this.GridView.RowTemplate.Height = 25;
            this.GridView.Size = new System.Drawing.Size(843, 411);
            this.GridView.TabIndex = 1;
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
            // KKUESport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(883, 489);
            this.MinimumSize = new System.Drawing.Size(883, 489);
            this.Name = "KKUESport";
            this.Text = "PlayerList";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EventKeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem playerMenuToolStripMenuItem;
        private DataGridView GridView;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem addPlayerToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private DataGridViewTextBoxColumn GridName;
        private DataGridViewTextBoxColumn GridLastname;
        private DataGridViewTextBoxColumn GridStudentID;
        private DataGridViewTextBoxColumn GridMajor;
        private DataGridViewTextBoxColumn GridGameName;
        private DataGridViewTextBoxColumn GridEmail;
        private DataGridViewTextBoxColumn GridTell;
        private DataGridViewTextBoxColumn GridAge;
    }
}