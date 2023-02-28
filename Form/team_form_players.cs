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
    public partial class team_form_players : Form
    {
        List<Player> listplayer;
        Player player;
        public team_form_players()
        {
            InitializeComponent();
            LoadFormMainForm();
        }

        
        public Player getPlayer()
        {
            return player;
        }

        private void team_form_player_submit_Click(object sender, EventArgs e)
        {
            player = listplayer[GridView_Team.CurrentCell.RowIndex];
            this.Close();
            this.DialogResult = DialogResult.OK;
        }


        ///Load Players
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Json|*.json";
            openfile.FileName = "Data";
            openfile.ShowDialog();
            try
            {
                if (openfile.FileName != "")
                {
                    try
                    {
                        listplayer = JsonConvert.DeserializeObject<List<Player>>(File.ReadAllText(openfile.FileName));
                        ReloadDatagrid();
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void LoadFormMainForm()
        {
            OpenFileDialog openfile = KKUESport.Instance.openfile;
            try
            {
                if (openfile.FileName != "")
                {
                    try
                    {
                        listplayer = JsonConvert.DeserializeObject<FileStructure<Player>>(File.ReadAllText(openfile.FileName)).Object;
                        ReloadDatagrid();
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            catch
            {
                return;
            }
        }
        private void ReloadDatagrid()
        {
            GridView_Team.Rows.Clear();
            foreach (Player P_player in listplayer)
            {
                GridView_Team.Rows.Add(P_player.getName(), P_player.getLastName(), P_player.getStudentID(), P_player.getMajor(), P_player.getGameName(), P_player.getEmail(), P_player.getTell(), P_player.getAge());
            }
        }
    }
}
