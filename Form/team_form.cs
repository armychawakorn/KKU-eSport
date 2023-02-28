using KKU_ESport.Class;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KKU_ESport
{
    public partial class team_form : Form
    {
        private List<Team> teams = new List<Team>();
        private FileStructure<Team> fileteam;
        private SaveFileDialog savefile;
        private OpenFileDialog openfile;
        FileDialog file;
        public team_form()
        {
            InitializeComponent();
            saveToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            file = new OpenFileDialog();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            team_form_reg tfr = new team_form_reg();
            tfr.ShowDialog();
            if(tfr.DialogResult == DialogResult.OK)
            {
                teams.Add(tfr.getTeam());
                ReloadTeamGrid();
                saveToolStripMenuItem.Enabled = true;
                saveAsToolStripMenuItem.Enabled = true;
            }
        }
        private void ReloadTeamGrid()
        {
            Team_Grid.Rows.Clear();
            foreach(Team team in teams)
            {
                Team_Grid.Rows.Add(team.TeamName, team.TeamMembers[0].Name, team.TeamMembers[1].Name, team.TeamMembers[2].Name, team.TeamMembers[3].Name, team.TeamMembers[4].Name);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileteam = new FileStructure<Team>();
            fileteam.Type = "Team";
            fileteam.Object = teams;
            if (file.FileName != "")
            {
                this.Text = string.Format("{0} ({1})", this.Name, file.FileName);
                File.WriteAllText(file.FileName, JsonConvert.SerializeObject(fileteam, Formatting.Indented));
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileteam = new FileStructure<Team>();
            fileteam.Type = "Team";
            fileteam.Object = teams;
            savefile = new SaveFileDialog();
            savefile.Filter = "Json|*.json";
            savefile.FileName = "Team";
            savefile.ShowDialog();
            try
            {
                if (savefile.FileName != "")
                {
                    file.FileName = savefile.FileName;
                    File.WriteAllText(savefile.FileName, JsonConvert.SerializeObject(fileteam, Formatting.Indented));
                    this.Text = string.Format("{0} ({1})", this.Name, file.FileName);
                    this.Text.Replace(" *", "");
                    saveToolStripMenuItem.Enabled = true;
                }
            }
            catch
            {
                return;
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile = new OpenFileDialog();
            openfile.Filter = "Json|*.json";
            openfile.FileName = "Team";
            openfile.ShowDialog();
            try
            {
                if (openfile.FileName != "")
                {
                    try
                    {
                        file.FileName = openfile.FileName;
                        FileStructure<Team> data = JsonConvert.DeserializeObject<FileStructure<Team>>(File.ReadAllText(openfile.FileName));
                        if(data.Type == "Team")
                        {
                            teams = data.Object;
                            ReloadTeamGrid();
                        }
                        else
                        {
                            MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ [ข้อมูลอาจเสียหายหรือข้อมูลไม่ถูกต้อง]");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("ไม่สามารถโหลดข้อมูลได้ [ข้อมูลอาจเสียหายหรือข้อมูลไม่ถูกต้อง]");
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;
        }
    }
}
