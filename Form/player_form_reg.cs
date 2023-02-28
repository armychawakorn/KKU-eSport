using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KKU_ESport.Class;

namespace KKU_ESport
{
    public partial class player_form_reg : Form
    {
        private Player player;
        public player_form_reg()
        {
            InitializeComponent();
        }

        private void reg_submit_Click(object sender, EventArgs e)
        {
            string Name = textBox_Name.Text;
            string LastName = textBox_Lastname.Text;
            string StudentID = textBox_StudentID.Text;
            string Major = textBox_Major.Text;
            string GameName = textBox_GameName.Text;
            string Email = textBox_Email.Text;
            string Tell = textBox_Tell.Text;
            int Age = 0;
            try
            {
                Age = int.Parse(textBox_Age.Text);
                this.DialogResult = DialogResult.OK;
            }catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            player = new Player(Name, LastName, StudentID, Major, GameName, Email, Tell, Age);
        }
        public Player getPlayer()
        {
            return player;
        }
    }
}
