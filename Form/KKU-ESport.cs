using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using KKU_ESport.Class;
using Newtonsoft.Json;

namespace KKU_ESport
{
    public partial class KKUESport : Form
    {
        public static KKUESport Instance;
        List<Player> listplayer = new();
        private FileStructure<Player> FSP;
        public SaveFileDialog savefile;
        public OpenFileDialog openfile;
        public FileDialog file;
        public KKUESport()
        {
            InitializeComponent();
            saveFileToolStripMenuItem.Enabled = false;
            saveAsToolStripMenuItem.Enabled = false;
            file = new OpenFileDialog();
            Instance = this;
        }

        private void addPlayerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            player_form_reg U_interface = new player_form_reg();
            U_interface.MdiParent = this.ParentForm;
            U_interface.ShowDialog();
            if (U_interface.DialogResult == DialogResult.OK)
            {
                listplayer.Add(U_interface.getPlayer());
                ReloadDatagrid();
                this.Text += " *";
                saveAsToolStripMenuItem.Enabled = true;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (file.FileName != "")
            {
                FSP = new FileStructure<Player>();
                FSP.Type = "Players";
                FSP.Object = listplayer;
                this.Text = string.Format("{0} ({1})", this.Name, file.FileName);
                File.WriteAllText(file.FileName, JsonConvert.SerializeObject(FSP, Formatting.Indented));
            }
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savefile = new SaveFileDialog();
            savefile.Filter = "Json|*.json";
            savefile.FileName = "Data";
            savefile.ShowDialog();
            try
            {
                if (savefile.FileName != "")
                {
                    FSP = new FileStructure<Player>();
                    FSP.Type = "Players";
                    FSP.Object = listplayer;
                    file.FileName = savefile.FileName;
                    File.WriteAllText(savefile.FileName, JsonConvert.SerializeObject(FSP, Formatting.Indented));
                    this.Text = string.Format("{0} ({1})", this.Name, file.FileName);
                    this.Text.Replace(" *", "");
                    saveFileToolStripMenuItem.Enabled = true;
                }
            }
            catch
            {
                return;
            }
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openfile = new OpenFileDialog();
            openfile.Filter = "Json|*.json";
            openfile.FileName = "Data";
            openfile.ShowDialog();
            try
            {
                if (openfile.FileName != "")
                {
                    try
                    {
                        FileStructure<Player> data = JsonConvert.DeserializeObject<FileStructure<Player>>(File.ReadAllText(openfile.FileName));
                        if(data.Type == "Players")
                        {
                            file.FileName = openfile.FileName;
                            listplayer = data.Object;
                            ReloadDatagrid();
                            this.Text = string.Format("{0} ({1})", this.Name, file.FileName);
                            saveFileToolStripMenuItem.Enabled = true;
                            saveAsToolStripMenuItem.Enabled = true;
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
        }
        public List<Player> getlistPlayer()
        {
            return listplayer;
        }
        public void ReloadDatagrid()
        {
            GridView.Rows.Clear();
            foreach (Player P_player in listplayer)
            {
                GridView.Rows.Add(P_player.getName(), P_player.getLastName(), P_player.getStudentID(), P_player.getMajor(), P_player.getGameName(), P_player.getEmail(), P_player.getTell(), P_player.getAge());
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReloadDatagrid();
        }

        private void EventKeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            team_form teamform = new team_form();
            teamform.ShowDialog();
        }
    }
}
