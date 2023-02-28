using KKU_ESport.Class;
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
    public partial class team_form_reg : Form
    {
        private Team team;
        private List<Player> players = new List<Player>();
        public team_form_reg()
        {
            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                players.Add(new Player("","","","","","","",0));
            }
        }

        private void btn_team_addmember(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            team_form_players tfp;
            switch (btn.Name)
            {
                case "button_team_member1":
                    FindMembers(textBox_team_member1, 1);
                    break;
                case "button_team_member2":
                    FindMembers(textBox_team_member2, 2);
                    break;
                case "button_team_member3":
                    FindMembers(textBox_team_member3, 3);
                    break;
                case "button_team_member4":
                    FindMembers(textBox_team_member4, 4);
                    break;
                case "button_team_member5":
                    FindMembers(textBox_team_member5, 5);
                    break;
            }
        }
        public void FindMembers(TextBox textbox, int index)
        {
            team_form_players tfp = new team_form_players();
            tfp.ShowDialog();
            if (tfp.DialogResult == DialogResult.OK)
            {
                textbox.Text = tfp.getPlayer().Name;
                players[index-1] = tfp.getPlayer();
            }
        }

        private void button_team_reg_submit_Click(object sender, EventArgs e)
        {
            team = new Team(textBox_team_name.Text, players);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        public Team getTeam()
        {
            return team;
        }
    }
}
