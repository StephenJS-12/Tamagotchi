using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF_164_Tamagotchi_Group_27
{
    public partial class frmMainMenu : Form
    {
        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public frmMainMenu()
        {
            InitializeComponent();

            //Make label backgrounds transpaant
            lblGameName.Parent = pbxMainMeu;
            lblGameName.BackColor = Color.Transparent;
        }

        private void cbtnPlay_Click(object sender, EventArgs e)
        {
            GameSetup form = new GameSetup();
            this.Hide();
            form.ShowDialog();
        }

        private void cbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbtnInstructions_Click(object sender, EventArgs e)
        {
            
            Instructions frm = new Instructions();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {

        }

        private void btnMiniGame_Click(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            player.SoundLocation = "Menu.wav";
            player.Play();
        }

        private void cbxMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxMusic.Checked)
            {
                player.Play();
            }
            else if (!cbxMusic.Checked)
            {
                player.Stop();
            }
        }
    }
}
