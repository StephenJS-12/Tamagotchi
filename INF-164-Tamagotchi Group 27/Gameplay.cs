using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace INF_164_Tamagotchi_Group_27
{
    public partial class Gameplay : Form
    {
        public Gameplay()
        {
            InitializeComponent();
          
        }

        bool sleepState = false;
        bool sickState = false;
        string previous_state = "";
        //Maybe delete//GameSetup gameSetup = new GameSetup();

        public Tamagotchi Pet = new Tamagotchi();
        //Marketplace market = new 

        public System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        private void Gameplay_Load(object sender, EventArgs e)
        {
            Pet.Load_Pet();
            player.SoundLocation = "Game.wav";
            player.Play();

            btnSleep.Text = "Let " + Pet.Name + " sleep";

            if (Pet.Type == "Square")
            {
                pnlPlayer.BackgroundImage = PetImg.Images["Square Start"];
                previous_state = "Square Start";
            }
            else if (Pet.Type == "Triangle")
            {
                pnlPlayer.BackgroundImage = PetImg.Images["Triangle Start"];
                previous_state = "Triangle Start";
            }

            lblCurrency.Text = "Currency = " + Convert.ToString(Pet.Currency);
            btnFeed.Text = "Feed " + Pet.Name;
            btnPlay.Text = "Play minigame with " + Pet.Name;
            if (Pet.Sleep >= 100)
            {
                Pet.Sleep = 100;
            }
            barSleep.Value = Pet.Sleep;

            if (Pet.Hunger >= 100)
            {
                Pet.Hunger = 100;
            }
            barHunger.Value = Pet.Hunger;

            if (Pet.Happiness >= 100)
            {
                Pet.Happiness = 100;
            }
            barFulfillment.Value = Pet.Happiness;

            barHealth.Value = (barFulfillment.Value + barHunger.Value + barSleep.Value) / 3;

            tmrSleepDegeneration.Enabled = true;
            tmrHunger.Enabled = true;
            tmrHappiness.Enabled = true;
            tmrCheckState.Enabled = true;

            lblFood.Text = Convert.ToString(Pet.Food);
            lblCoffee.Text = Convert.ToString(Pet.Coffee);
            lblChocolate.Text = Convert.ToString(Pet.Chocolate);

            barSleep.Value = Pet.Sleep;
            barHunger.Value = Pet.Hunger;
            barFulfillment.Value = Pet.Happiness;
            barHealth.Value = (barFulfillment.Value + barHunger.Value + barSleep.Value) / 3;
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            Pet.SaveState();
            TopDownShooter frm = new TopDownShooter();
            tmrCheckState.Enabled = false;
            tmrHappiness.Enabled = false;
            tmrHunger.Enabled = false;
            tmrSleepDegeneration.Enabled = false;
            tmrSleeping.Enabled = false;
            player.Stop();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            sleepState = !sleepState;

            if (sleepState == true)
            {
                btnSleep.Text = "Wake " + Pet.Name;
                btnPlay.Enabled = false;
                btnShop.Enabled = false;
                btnChocolate.Enabled = false;
                btnCoffee.Enabled = false;
                btnFeed.Enabled = false;
                tmrSleepDegeneration.Enabled = false;
                tmrSleeping.Enabled = true;
            }
            else
            {
                btnSleep.Text = "Let " + Pet.Name + " sleep";
                btnPlay.Enabled = true;
                btnShop.Enabled = true;
                btnFeed.Enabled = true;
                btnCoffee.Enabled = true;
                btnChocolate.Enabled = true;
                tmrSleepDegeneration.Enabled = true;
                tmrSleeping.Enabled = false;
            }

            if (Pet.Type == "Square" && sleepState == true)
            {
                pnlPlayer.BackgroundImage = PetImg.Images["Square Sleeping"];
            }
            else if (Pet.Type == "Square" && sleepState == false)
            {
                pnlPlayer.BackgroundImage = PetImg.Images[previous_state];
            }
            else if (Pet.Type == "Triangle" && sleepState == true)
            {
                pnlPlayer.BackgroundImage = PetImg.Images["Triangle Sleeping"];
            }
            else if (Pet.Type == "Triangle" && sleepState == false)
            {
                pnlPlayer.BackgroundImage = PetImg.Images[previous_state];
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Pet.SaveState();
        }

        private void cbtnClose_Click(object sender, EventArgs e)
        {
            Pet.SaveState();
            Application.Exit();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            Pet.SaveState();
            frmMainMenu form = new frmMainMenu();
            this.Hide();
            form.ShowDialog();
        }

        private void tmrSleepDegeneration_Tick(object sender, EventArgs e)
        {
            if (Pet.Sleep == 0)
            {
                barSleep.Value = 0;
            }
            else
            {
                Pet.Sleep--;
                barSleep.Value = Pet.Sleep;
            }

            if (Pet.Sleep < 70 && Pet.Sleep >= 30)
            {
                barSleep.ForeColor = Color.Orange;
            }
            else if (Pet.Sleep < 30 && Pet.Sleep > 0)
            {
                barSleep.ForeColor = Color.Red;
            }
            else if (Pet.Sleep > 70 && Pet.Sleep <= 100)
            {
                barSleep.ForeColor = Color.Green;
            }
        }

        private void tmrHunger_Tick(object sender, EventArgs e)
        {
            if (Pet.Hunger >= 100)
            {
                Pet.Hunger = 100;
            }

            if (Pet.Hunger == 0)
            {
                barHunger.Value = 0;
            }
            else
            {
                Pet.Hunger--;
                barHunger.Value = Pet.Hunger;
            }

            if (Pet.Hunger < 70 && Pet.Hunger >= 30)
            {
                barHunger.ForeColor = Color.Orange;
            }
            else if (Pet.Hunger < 30 && Pet.Hunger > 0)
            {
                barHunger.ForeColor = Color.Red;
            }
            else if (Pet.Hunger > 70 && Pet.Hunger <= 100)
            {
                barHunger.ForeColor = Color.Green;
            }

            if (Pet.Hunger >= 100)
            {
                Pet.Hunger = 100;
            }
        }

        private void tmrHappiness_Tick(object sender, EventArgs e)
        {
            if (Pet.Happiness == 0)
            {
                barFulfillment.Value = 0;
            }
            else
            {
                Pet.Happiness--;
                barFulfillment.Value = Pet.Happiness;
            }

            if (Pet.Happiness < 70 && Pet.Happiness >= 30)
            {
                barFulfillment.ForeColor = Color.Orange;
            }
            else if (Pet.Happiness < 30 && Pet.Happiness > 0)
            {
                barFulfillment.ForeColor = Color.Red;
            }
            else if (Pet.Happiness > 70 && Pet.Happiness <= 100)
            {
                barFulfillment.ForeColor = Color.Green;
            }
        }

        private void tmrSleeping_Tick(object sender, EventArgs e)
        {
            if (Pet.Sleep < 100)
            {
                Pet.Sleep++;
            }
            
            barSleep.Value = Pet.Sleep;
        }

        bool PreviousState = false;

        private void tmrCheckState_Tick(object sender, EventArgs e)
        {
            barHealth.Value = (barFulfillment.Value + barHunger.Value + barSleep.Value) / 3;

            if (Pet.Type == "Square" && _PreviousImageState)
            {
                pnlPlayer.BackgroundImage = PetImg.Images["Square Start"];
                _PreviousImageState = false;
            }
            else if (Pet.Type == "Triangle" && _PreviousImageState)
            {
                pnlPlayer.BackgroundImage = PetImg.Images["Triangle Start"];
                _PreviousImageState = false;
            }

            if (barHealth.Value > 70)
            {
                barHealth.ForeColor = Color.Green;
                sickState = false;
            }
            else if (barHealth.Value > 30)
            {
                barHealth.ForeColor = Color.Orange;
                sickState = false;
            }
            else if (barHealth.Value > 0)
            {
                barHealth.ForeColor = Color.Red;
                sickState = true;
            }

            if (sickState && !PreviousState)
            {
                PreviousState = true;
                if (Pet.Type == "Square")
                {
                    pnlPlayer.BackgroundImage = PetImg.Images["Square Sick"];
                }
                else if (Pet.Type == "Triangle")
                {
                    pnlPlayer.BackgroundImage = PetImg.Images["Triangle Sick"];
                }
            }
            else if (!sickState && PreviousState)
            {
                PreviousState = false;
                if (Pet.Type == "Square")
                {
                    pnlPlayer.BackgroundImage = PetImg.Images["Square Start"];
                }
                else if (Pet.Type == "Triangle")
                {
                    pnlPlayer.BackgroundImage = PetImg.Images["Triangle Start"];
                }
            }

            if (Pet.Sleep == 0 || Pet.Hunger == 0 || Pet.Happiness == 0)
            {
                if (Pet.Type == "Square")
                {
                    pnlPlayer.BackgroundImage = PetImg.Images["Square Dead"];
                }
                else if (Pet.Type == "Triangle")
                {
                    pnlPlayer.BackgroundImage = PetImg.Images["Triangle Dead"];
                }
                tmrSleepDegeneration.Enabled = false;
                tmrHunger.Enabled = false;
                tmrHappiness.Enabled = false;
                tmrCheckState.Enabled = false;
                MessageBox.Show("Your tamagotchi pet has died. GAME OVER.");
                Pet.ResetPet();
                Pet.SaveState();

                frmMainMenu form = new frmMainMenu();
                this.Hide();
                form.ShowDialog();
            }

            lblCurrency.Text = "Currency = " + Pet.Currency;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            Pet.SaveState();
            Marketplace frmMarket = new Marketplace();
            tmrCheckState.Enabled = false;
            tmrHappiness.Enabled = false;
            tmrHunger.Enabled = false;
            tmrSleepDegeneration.Enabled = false;
            tmrSleeping.Enabled = false;
            this.Hide();
            frmMarket.Show();
            this.Close();
        }

        bool _PreviousImageState = false;

        private void btnFeed_Click_1(object sender, EventArgs e)
        {
            //Connor
            //I was working on these but didnt get them working yet

            int food;
            food = Convert.ToInt32(Pet.Food);

            if ( food != 0)
            {
                if ((Pet.Hunger + 5) <= 100)
                {
                    Pet.Hunger += 5;
                    barHunger.Value = Pet.Hunger;
                    food--;
                    Pet.Food = food;
                    if (Pet.Type == "Square" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Square Eyes-Closed"];
                        _PreviousImageState = true;

                    }
                    else if (Pet.Type == "Triangle" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Triangle Eyes-Closed"];
                        _PreviousImageState = true;
                    }
                    Pet.SaveState();
                }
                else if ((Pet.Hunger + 5) > 100)
                {
                    Pet.Hunger = 100;
                    barHunger.Value = Pet.Hunger;
                    food--;
                    Pet.Food = food;
                    if (Pet.Type == "Square" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Square Eyes-Closed"];
                        _PreviousImageState = true;

                    }
                    else if (Pet.Type == "Triangle" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Triangle Eyes-Closed"];
                        _PreviousImageState = true;
                    }
                    Pet.SaveState();
                }
                //Pet.SaveState();
            }
            else
            {
                MessageBox.Show("No More Food");
            }

            lblFood.Text = Convert.ToString(Pet.Food);
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            int coffee = Convert.ToInt32(Pet.Coffee);

            if (coffee != 0)
            {
                if ((Pet.Sleep + 25) <= 100)
                {
                    Pet.Sleep += 25;
                    barSleep.Value = Pet.Sleep;
                    coffee--;
                    Pet.Coffee = coffee;
                    if (Pet.Type == "Square" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Square Eyes-Closed"];
                        _PreviousImageState = true;

                    }
                    else if (Pet.Type == "Triangle" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Triangle Eyes-Closed"];
                        _PreviousImageState = true;
                    }
                    Pet.SaveState();
                }
                else if ((Pet.Sleep + 25) > 100)
                {
                    Pet.Sleep = 100;
                    barSleep.Value = Pet.Sleep;
                    coffee--;
                    Pet.Coffee = coffee;
                    if (Pet.Type == "Square" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Square Eyes-Closed"];
                        _PreviousImageState = true;

                    }
                    else if (Pet.Type == "Triangle" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Triangle Eyes-Closed"];
                        _PreviousImageState = true;
                    }
                    Pet.SaveState();
                }
                //Pet.SaveState();
            }
            else
            {
                MessageBox.Show("No More Coffee");
            }

            lblCoffee.Text = Convert.ToString(Pet.Coffee);
        }

        private void btnChocolate_Click(object sender, EventArgs e)
        {
            int chocolate;
            chocolate = Convert.ToInt32(Pet.Chocolate);

            if(chocolate != 0)
            {
                if ((Pet.Happiness + 15) <= 100)
                {
                    Pet.Happiness += 15;
                    barFulfillment.Value = Pet.Happiness;
                    chocolate--;
                    Pet.Chocolate = chocolate;
                    if (Pet.Type == "Square" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Square Eyes-Closed"];
                        _PreviousImageState = true;

                    }
                    else if (Pet.Type == "Triangle" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Triangle Eyes-Closed"];
                        _PreviousImageState = true;
                    }
                    Pet.SaveState();
                }
                else if ((Pet.Happiness + 15) > 100)
                {
                    Pet.Happiness = 100;
                    barFulfillment.Value = Pet.Happiness;
                    chocolate--;
                    Pet.Chocolate = chocolate;
                    if (Pet.Type == "Square" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Square Eyes-Closed"];
                        _PreviousImageState = true;

                    }
                    else if (Pet.Type == "Triangle" && !_PreviousImageState)
                    {
                        pnlPlayer.BackgroundImage = PetImg.Images["Triangle Eyes-Closed"];
                        _PreviousImageState = true;
                    }
                    Pet.SaveState();
                }
                //Pet.SaveState();
            }
            else
            {
                MessageBox.Show("No More Chocolate");
            }

            lblChocolate.Text = Convert.ToString(Pet.Chocolate);
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
