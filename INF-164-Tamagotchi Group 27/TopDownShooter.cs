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
    public partial class TopDownShooter : Form
    {
        public System.Media.SoundPlayer shot = new System.Media.SoundPlayer();

        //public variables needed for our functions
        //controls player position on screen
        bool keyup;
        bool keydown;
        bool keyleft;
        bool keyright;
        string playerDirection = "right";

        //state of game at game start
        bool gameOver = false;

        //player stats at game start
        double health = 100;
        int movementSpeed = 8;
        int ammoLevel = 7;
        int robotSpeed = 3;
        int annihilations = 0;
        Random random = new Random();

        public TopDownShooter()
        {
            InitializeComponent();

            this.BackgroundImage = Properties.Resources.background;
        }

        //Pet instance created and current pet loaded
        public Tamagotchi Pet;

        //timer event on game start
        private void gameStartEvent(object sender, EventArgs e)
        {
            Pet = new Tamagotchi();
            Pet.Load_Pet();
            shot.SoundLocation = "Gun.wav";

            //if the player has enough health left, the progressbar will be shown
            if (health > 1)
            {
                pbprogressHealth.Value = Convert.ToInt32(health);
                pbprogressHealth.ForeColor = Color.Orange;
            }
            //else the player will be killed and game over is called
            else
            {
                int previous_currency = Pet.Currency;
                pbxplayerController.Image = Properties.Resources.death;
                if ((Pet.Happiness + annihilations) > 100)
                {
                    Pet.Happiness = 100;
                }
                else
                {
                    Pet.Happiness += annihilations;
                }
                if (annihilations % 2 == 0)
                {
                    Pet.Currency += annihilations / 2;
                }
                else
                {
                    Pet.Currency += Convert.ToInt32(annihilations / 2 + 0.5);
                }
                
                Pet.SaveState();
                gameStart.Stop();
                gameOver = true;
                MessageBox.Show("You earned: " + (Pet.Currency - previous_currency) + " Currency" +
                              "\nYou earned: " + annihilations + " Fullfilment");
                Gameplay form = new Gameplay();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }

            //if health is less than 20% make bar red as warning
            if (health < 20)
            {
                pbprogressHealth.ForeColor = Color.Red;
            }

            //displays our player stats value on the form
            lblAmmo.Text = ammoLevel.ToString();
            lblKills.Text = annihilations.ToString();

            //affect speed of payer according to their direction
            if (keyleft && pbxplayerController.Left > 0)
            {
                pbxplayerController.Left -= movementSpeed;
            }

            if (keyright && pbxplayerController.Left + pbxplayerController.Width < 1190)
            {
                pbxplayerController.Left += movementSpeed;
            }

            if (keyup && pbxplayerController.Top > 20)
            {
                pbxplayerController.Top -= movementSpeed;
            }

            if (keydown && pbxplayerController.Top + pbxplayerController.Height < 750)
            {
                pbxplayerController.Top += movementSpeed;
            }

            foreach (Control x in this.Controls)
            {
                //if the player runs over the ammo picture, they will pick it up (and the picture will dissapear), and their ammo level will increase
                if (x is PictureBox && x.Tag.ToString() == "ammo")
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(pbxplayerController.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x)); // remove the ammo picture box
                        ((PictureBox)x).Dispose();
                        ammoLevel += 7;
                    }
                }

                //if our players bullet hits the frame of the form, the bullet will "dissapear"
                if (x is PictureBox && x.Tag.ToString() == "bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 1260 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 750)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }
                }

                //player-robot interaction
                if (x is PictureBox && x.Tag.ToString() == "robot")
                {

                    //if the robot runs into the player, our health goes down and we get a red background to show injury
                    if (((PictureBox)x).Bounds.IntersectsWith(pbxplayerController.Bounds) && gameOver == false)
                    {
                        health -= 1;
                        pbxplayerController.BackColor = Color.Red;
                    }
                    else
                    {
                        pbxplayerController.BackColor = Color.Transparent;
                    }

                    //will allow the robots to move towards the player (just like the player keys above, it will change the robots direction and image)
                    if (((PictureBox)x).Left > pbxplayerController.Left)
                    {
                        ((PictureBox)x).Left -= robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rl;
                    }

                    if (((PictureBox)x).Top > pbxplayerController.Top)
                    {
                        ((PictureBox)x).Top -= robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ru;
                    }

                    if (((PictureBox)x).Left < pbxplayerController.Left)
                    {
                        ((PictureBox)x).Left += robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rr;
                    }

                    if (((PictureBox)x).Top < pbxplayerController.Top)
                    {
                        ((PictureBox)x).Top += robotSpeed;
                        ((PictureBox)x).Image = Properties.Resources.rd;
                    }
                }


                //if our player hits the robot with our bullets, then the robots is killed and more are spawned
                foreach (Control j in this.Controls)
                {
                    if ((j is PictureBox && j.Tag.ToString() == "bullet") && (x is PictureBox && x.Tag.ToString() == "robot"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            //up our kill streak 
                            annihilations++;
                            //removes the robot(x) and the ammo(j)
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            //spawns more robots
                            spawnRobots();
                        }
                    }
                }
            }

        }

        //moves player when keys are pressed down
        private void keyDown(object sender, KeyEventArgs e)
        {
            //player won't be able to move if game is over
            if (gameOver)
            {
                return;
            }

            //moves player left with left arrow key and sets image as "man-left"
            if (e.KeyCode == Keys.Left)
            {
                keyleft = true;
                playerDirection = "left";
                pbxplayerController.Image = Properties.Resources.ml;
            }

            //moves player right with right arrow key and sets image as "man-right"
            if (e.KeyCode == Keys.Right)
            {
                keyright = true;
                playerDirection = "right";
                pbxplayerController.Image = Properties.Resources.mr;
            }

            //moves player down with right down key and sets image as "man-down"
            if (e.KeyCode == Keys.Down)
            {
                keydown = true;
                playerDirection = "down";
                pbxplayerController.Image = Properties.Resources.md;
            }

            //moves player up with right up key and sets image as "man-up"
            if (e.KeyCode == Keys.Up)
            {
                keyup = true;
                playerDirection = "up";
                pbxplayerController.Image = Properties.Resources.mu;
            }
        }

        //stops player movement when keys arent pressed
        private void keyUp(object sender, KeyEventArgs e)
        {
            //player won't be able to move if game is over
            if (gameOver)
            {
                return;
            }

            //disables keys when not pressed
            if (e.KeyCode == Keys.Left)
            {
                keyleft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                keyright = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                keydown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                keyup = false;
            }

            //if the space bar is pressed down - it's here to prevent spamming of key
            if (e.KeyCode == Keys.Space && ammoLevel > 0)
            {
                shot.Play();
                //reduce ammo and shoots in the direction the  player faces
                ammoLevel--;
                shootMain(playerDirection);

                //spawn ammo boxes if ammo is low (defined later)
                if (ammoLevel < 3)
                {
                    spawnAmmo();
                }
            }
            else if (e.KeyCode == Keys.Space && ammoLevel == 0)
            {
                shot.SoundLocation = "Empty Gun.wav";
                shot.Play();
            }
        }

        //function needed to spawn more ammo during game
        private void spawnAmmo()
        {
            //creates new PictureBox for ammo that will spawn randomly across screen
            PictureBox ammo = new PictureBox();
            ammo.BringToFront();
            ammo.Image = Properties.Resources.ammo;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.BackColor = Color.Transparent;
            ammo.Left = random.Next(10, 890);
            ammo.Top = random.Next(50, 600);
            ammo.Tag = "ammo";

            //adds the controls needed to pick it up and dispose of it above
            this.Controls.Add(ammo);
            pbxplayerController.BringToFront();
        }

        //allows the player to shoot the robots in the direction it faces
        private void shootMain(string direction)
        {
            bullet shoot = new bullet();
            shoot.direction = direction;
            shoot.bulletLeft = pbxplayerController.Left + (pbxplayerController.Width / 2);
            shoot.bulletTop = pbxplayerController.Top + (pbxplayerController.Height / 2);
            shoot.spawnBullets(this);
        }

        //spawns robots
        private void spawnRobots()
        {
            PictureBox robots = new PictureBox();
            robots.Tag = "robot";
            robots.Image = Properties.Resources.rl;
            robots.Left = random.Next(0, 900);
            robots.Top = random.Next(0, 800);
            robots.SizeMode = PictureBoxSizeMode.AutoSize;
            robots.BackColor = Color.Transparent;
            this.Controls.Add(robots);
            pbxplayerController.BringToFront();
            robots.BringToFront();
        }

        private void TopDownShooter_Load(object sender, EventArgs e)
        {

        }

        private void pbxplayerController_Click(object sender, EventArgs e)
        {

        }
    }
}
