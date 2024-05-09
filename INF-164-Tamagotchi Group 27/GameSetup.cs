using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace INF_164_Tamagotchi_Group_27
{
    public partial class GameSetup : Form
    {
        public GameSetup()
        {
            InitializeComponent();
        }

        public Tamagotchi Pet;

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cbxSelectCharacter.Text != "Select Character")
            {
                Pet = new Tamagotchi(txtName.Text, 100, 100, 100, 100, cbxSelectCharacter.Text, 0,/*the numbers to the right are food items*/ 0, 0, 0);
                Pet.SaveState();

                Gameplay form = new Gameplay();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please fill in all the fields.");
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu form = new frmMainMenu();
            this.Hide();
            form.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Pet = new Tamagotchi();
            Pet.Load_Pet();

            Gameplay form = new Gameplay();
            this.Hide();
            form.ShowDialog();
        }

        private void cbtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameSetup_Load(object sender, EventArgs e)
        {

        }
    }
}
