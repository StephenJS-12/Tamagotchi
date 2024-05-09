namespace INF_164_Tamagotchi_Group_27
{
    partial class Gameplay
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.tmrSleepDegeneration = new System.Windows.Forms.Timer(this.components);
            this.barSleep = new System.Windows.Forms.ProgressBar();
            this.barHunger = new System.Windows.Forms.ProgressBar();
            this.barFulfillment = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrSleeping = new System.Windows.Forms.Timer(this.components);
            this.PetImg = new System.Windows.Forms.ImageList(this.components);
            this.tmrHunger = new System.Windows.Forms.Timer(this.components);
            this.tmrHappiness = new System.Windows.Forms.Timer(this.components);
            this.tmrCheckState = new System.Windows.Forms.Timer(this.components);
            this.lblCurrency = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblChocolate = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.btnChocolate = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnCoffee = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnFeed = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.cbtnClose = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnMainMenu = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnSave = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnPlay = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnShop = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnSleep = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.barHealth = new System.Windows.Forms.ProgressBar();
            this.cbxMusic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlayer
            // 
            this.pnlPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPlayer.Location = new System.Drawing.Point(335, 138);
            this.pnlPlayer.Name = "pnlPlayer";
            this.pnlPlayer.Size = new System.Drawing.Size(300, 300);
            this.pnlPlayer.TabIndex = 0;
            // 
            // tmrSleepDegeneration
            // 
            this.tmrSleepDegeneration.Interval = 5000;
            this.tmrSleepDegeneration.Tick += new System.EventHandler(this.tmrSleepDegeneration_Tick);
            // 
            // barSleep
            // 
            this.barSleep.BackColor = System.Drawing.SystemColors.Control;
            this.barSleep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barSleep.Location = new System.Drawing.Point(26, 34);
            this.barSleep.Name = "barSleep";
            this.barSleep.Size = new System.Drawing.Size(186, 23);
            this.barSleep.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barSleep.TabIndex = 7;
            // 
            // barHunger
            // 
            this.barHunger.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barHunger.Location = new System.Drawing.Point(266, 34);
            this.barHunger.Name = "barHunger";
            this.barHunger.Size = new System.Drawing.Size(186, 23);
            this.barHunger.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHunger.TabIndex = 10;
            // 
            // barFulfillment
            // 
            this.barFulfillment.Cursor = System.Windows.Forms.Cursors.Default;
            this.barFulfillment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barFulfillment.Location = new System.Drawing.Point(518, 34);
            this.barFulfillment.Name = "barFulfillment";
            this.barFulfillment.Size = new System.Drawing.Size(186, 23);
            this.barFulfillment.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barFulfillment.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sleepiness";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(266, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hunger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(514, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fulfillment";
            // 
            // tmrSleeping
            // 
            this.tmrSleeping.Interval = 1000;
            this.tmrSleeping.Tick += new System.EventHandler(this.tmrSleeping_Tick);
            // 
            // PetImg
            // 
            this.PetImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("PetImg.ImageStream")));
            this.PetImg.TransparentColor = System.Drawing.Color.Transparent;
            this.PetImg.Images.SetKeyName(0, "Square Dead");
            this.PetImg.Images.SetKeyName(1, "Square Eyes-Closed");
            this.PetImg.Images.SetKeyName(2, "Square Sick");
            this.PetImg.Images.SetKeyName(3, "Square Sleeping");
            this.PetImg.Images.SetKeyName(4, "Square Start");
            this.PetImg.Images.SetKeyName(5, "Triangle Eyes-Closed");
            this.PetImg.Images.SetKeyName(6, "Triangle Sick");
            this.PetImg.Images.SetKeyName(7, "Triangle Sleeping");
            this.PetImg.Images.SetKeyName(8, "Triangle Start");
            this.PetImg.Images.SetKeyName(9, "Triangle Dead");
            // 
            // tmrHunger
            // 
            this.tmrHunger.Interval = 3000;
            this.tmrHunger.Tick += new System.EventHandler(this.tmrHunger_Tick);
            // 
            // tmrHappiness
            // 
            this.tmrHappiness.Interval = 2000;
            this.tmrHappiness.Tick += new System.EventHandler(this.tmrHappiness_Tick);
            // 
            // tmrCheckState
            // 
            this.tmrCheckState.Interval = 1000;
            this.tmrCheckState.Tick += new System.EventHandler(this.tmrCheckState_Tick);
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrency.Location = new System.Drawing.Point(411, 88);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(141, 28);
            this.lblCurrency.TabIndex = 17;
            this.lblCurrency.Text = "Currency =  ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(793, 145);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 21;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.BackColor = System.Drawing.Color.Transparent;
            this.lblFood.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.ForeColor = System.Drawing.Color.Yellow;
            this.lblFood.Location = new System.Drawing.Point(757, 148);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(17, 19);
            this.lblFood.TabIndex = 22;
            this.lblFood.Text = "0";
            // 
            // lblChocolate
            // 
            this.lblChocolate.AutoSize = true;
            this.lblChocolate.BackColor = System.Drawing.Color.Transparent;
            this.lblChocolate.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChocolate.ForeColor = System.Drawing.Color.Yellow;
            this.lblChocolate.Location = new System.Drawing.Point(757, 207);
            this.lblChocolate.Name = "lblChocolate";
            this.lblChocolate.Size = new System.Drawing.Size(17, 19);
            this.lblChocolate.TabIndex = 23;
            this.lblChocolate.Text = "0";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.BackColor = System.Drawing.Color.Transparent;
            this.lblCoffee.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffee.ForeColor = System.Drawing.Color.Yellow;
            this.lblCoffee.Location = new System.Drawing.Point(757, 267);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(17, 19);
            this.lblCoffee.TabIndex = 24;
            this.lblCoffee.Text = "0";
            // 
            // btnChocolate
            // 
            this.btnChocolate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChocolate.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChocolate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnChocolate.BorderRadius = 20;
            this.btnChocolate.BorderSize = 0;
            this.btnChocolate.FlatAppearance.BorderSize = 0;
            this.btnChocolate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChocolate.ForeColor = System.Drawing.Color.White;
            this.btnChocolate.Location = new System.Drawing.Point(780, 197);
            this.btnChocolate.Name = "btnChocolate";
            this.btnChocolate.Size = new System.Drawing.Size(150, 40);
            this.btnChocolate.TabIndex = 20;
            this.btnChocolate.Text = "Chocolate";
            this.btnChocolate.TextColor = System.Drawing.Color.White;
            this.btnChocolate.UseVisualStyleBackColor = false;
            this.btnChocolate.Click += new System.EventHandler(this.btnChocolate_Click);
            // 
            // btnCoffee
            // 
            this.btnCoffee.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCoffee.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCoffee.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCoffee.BorderRadius = 20;
            this.btnCoffee.BorderSize = 0;
            this.btnCoffee.FlatAppearance.BorderSize = 0;
            this.btnCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoffee.ForeColor = System.Drawing.Color.White;
            this.btnCoffee.Location = new System.Drawing.Point(780, 257);
            this.btnCoffee.Name = "btnCoffee";
            this.btnCoffee.Size = new System.Drawing.Size(150, 40);
            this.btnCoffee.TabIndex = 19;
            this.btnCoffee.Text = "Coffee";
            this.btnCoffee.TextColor = System.Drawing.Color.White;
            this.btnCoffee.UseVisualStyleBackColor = false;
            this.btnCoffee.Click += new System.EventHandler(this.btnCoffee_Click);
            // 
            // btnFeed
            // 
            this.btnFeed.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFeed.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFeed.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFeed.BorderRadius = 20;
            this.btnFeed.BorderSize = 0;
            this.btnFeed.FlatAppearance.BorderSize = 0;
            this.btnFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeed.ForeColor = System.Drawing.Color.White;
            this.btnFeed.Location = new System.Drawing.Point(780, 138);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(150, 40);
            this.btnFeed.TabIndex = 18;
            this.btnFeed.Text = "Food";
            this.btnFeed.TextColor = System.Drawing.Color.White;
            this.btnFeed.UseVisualStyleBackColor = false;
            this.btnFeed.Click += new System.EventHandler(this.btnFeed_Click_1);
            // 
            // cbtnClose
            // 
            this.cbtnClose.BackColor = System.Drawing.Color.Teal;
            this.cbtnClose.BackgroundColor = System.Drawing.Color.Teal;
            this.cbtnClose.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnClose.BorderRadius = 20;
            this.cbtnClose.BorderSize = 3;
            this.cbtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnClose.FlatAppearance.BorderSize = 0;
            this.cbtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnClose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtnClose.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnClose.Location = new System.Drawing.Point(750, 384);
            this.cbtnClose.Name = "cbtnClose";
            this.cbtnClose.Size = new System.Drawing.Size(150, 40);
            this.cbtnClose.TabIndex = 15;
            this.cbtnClose.Text = "CLOSE";
            this.cbtnClose.TextColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnClose.UseVisualStyleBackColor = false;
            this.cbtnClose.Click += new System.EventHandler(this.cbtnClose_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.Teal;
            this.btnMainMenu.BackgroundColor = System.Drawing.Color.Teal;
            this.btnMainMenu.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMainMenu.BorderRadius = 20;
            this.btnMainMenu.BorderSize = 3;
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.FlatAppearance.BorderSize = 0;
            this.btnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainMenu.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMainMenu.Location = new System.Drawing.Point(50, 384);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(150, 40);
            this.btnMainMenu.TabIndex = 16;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.TextColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 20;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(780, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPlay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPlay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlay.BorderRadius = 20;
            this.btnPlay.BorderSize = 0;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(26, 299);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 40);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play minigame with";
            this.btnPlay.TextColor = System.Drawing.Color.White;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShop.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnShop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnShop.BorderRadius = 20;
            this.btnShop.BorderSize = 0;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.Location = new System.Drawing.Point(26, 218);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(150, 40);
            this.btnShop.TabIndex = 2;
            this.btnShop.Text = "Item / Food Shop";
            this.btnShop.TextColor = System.Drawing.Color.White;
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSleep.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnSleep.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSleep.BorderRadius = 20;
            this.btnSleep.BorderSize = 0;
            this.btnSleep.FlatAppearance.BorderSize = 0;
            this.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSleep.ForeColor = System.Drawing.Color.White;
            this.btnSleep.Location = new System.Drawing.Point(26, 138);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(150, 40);
            this.btnSleep.TabIndex = 1;
            this.btnSleep.Text = "Sleep/Wake Up";
            this.btnSleep.TextColor = System.Drawing.Color.White;
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(757, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Health";
            // 
            // barHealth
            // 
            this.barHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.barHealth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.barHealth.Location = new System.Drawing.Point(761, 34);
            this.barHealth.Name = "barHealth";
            this.barHealth.Size = new System.Drawing.Size(186, 23);
            this.barHealth.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.barHealth.TabIndex = 25;
            // 
            // cbxMusic
            // 
            this.cbxMusic.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxMusic.AutoSize = true;
            this.cbxMusic.BackColor = System.Drawing.Color.Transparent;
            this.cbxMusic.Checked = true;
            this.cbxMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMusic.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbxMusic.Location = new System.Drawing.Point(670, 393);
            this.cbxMusic.Name = "cbxMusic";
            this.cbxMusic.Size = new System.Drawing.Size(45, 23);
            this.cbxMusic.TabIndex = 27;
            this.cbxMusic.Text = "Music";
            this.cbxMusic.UseVisualStyleBackColor = false;
            this.cbxMusic.CheckedChanged += new System.EventHandler(this.cbxMusic_CheckedChanged);
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF_164_Tamagotchi_Group_27.Properties.Resources.room1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 450);
            this.Controls.Add(this.cbxMusic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barHealth);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.btnChocolate);
            this.Controls.Add(this.lblChocolate);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.btnCoffee);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.cbtnClose);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barFulfillment);
            this.Controls.Add(this.barHunger);
            this.Controls.Add(this.barSleep);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnShop);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Gameplay";
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.Gameplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Timer tmrSleepDegeneration;
        private CustomButton btnSleep;
        private CustomButton btnShop;
        private CustomButton btnPlay;
        private CustomButton btnSave;
        private System.Windows.Forms.ProgressBar barSleep;
        private System.Windows.Forms.ProgressBar barHunger;
        private System.Windows.Forms.ProgressBar barFulfillment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrSleeping;
        private System.Windows.Forms.ImageList PetImg;
        private CustomButton btnMainMenu;
        private CustomButton cbtnClose;
        private System.Windows.Forms.Timer tmrHunger;
        private System.Windows.Forms.Timer tmrHappiness;
        private System.Windows.Forms.Timer tmrCheckState;
        private System.Windows.Forms.Label lblCurrency;
        private CustomButton btnFeed;
        private CustomButton btnCoffee;
        private CustomButton btnChocolate;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblChocolate;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar barHealth;
        private System.Windows.Forms.CheckBox cbxMusic;
    }
}