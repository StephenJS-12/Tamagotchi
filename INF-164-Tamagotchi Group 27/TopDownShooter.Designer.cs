namespace INF_164_Tamagotchi_Group_27
{
    partial class TopDownShooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopDownShooter));
            this.pbprogressHealth = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gameStart = new System.Windows.Forms.Timer(this.components);
            this.pbxplayerController = new System.Windows.Forms.PictureBox();
            this.pbxrobotController = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxplayerController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxrobotController)).BeginInit();
            this.SuspendLayout();
            // 
            // pbprogressHealth
            // 
            this.pbprogressHealth.Location = new System.Drawing.Point(910, 765);
            this.pbprogressHealth.Name = "pbprogressHealth";
            this.pbprogressHealth.Size = new System.Drawing.Size(254, 23);
            this.pbprogressHealth.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(124, 757);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ammo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(470, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Annihilations:";
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmmo.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.Color.Cyan;
            this.lblAmmo.Location = new System.Drawing.Point(220, 757);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(29, 34);
            this.lblAmmo.TabIndex = 3;
            this.lblAmmo.Text = "0";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.BackColor = System.Drawing.Color.Transparent;
            this.lblKills.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKills.ForeColor = System.Drawing.Color.Cyan;
            this.lblKills.Location = new System.Drawing.Point(643, 757);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(29, 34);
            this.lblKills.TabIndex = 4;
            this.lblKills.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(812, 757);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 34);
            this.label5.TabIndex = 5;
            this.label5.Text = "Health:";
            // 
            // gameStart
            // 
            this.gameStart.Enabled = true;
            this.gameStart.Interval = 10;
            this.gameStart.Tick += new System.EventHandler(this.gameStartEvent);
            // 
            // pbxplayerController
            // 
            this.pbxplayerController.BackColor = System.Drawing.Color.Transparent;
            this.pbxplayerController.Image = ((System.Drawing.Image)(resources.GetObject("pbxplayerController.Image")));
            this.pbxplayerController.Location = new System.Drawing.Point(12, 625);
            this.pbxplayerController.Name = "pbxplayerController";
            this.pbxplayerController.Size = new System.Drawing.Size(49, 43);
            this.pbxplayerController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxplayerController.TabIndex = 7;
            this.pbxplayerController.TabStop = false;
            this.pbxplayerController.Tag = "player";
            this.pbxplayerController.Click += new System.EventHandler(this.pbxplayerController_Click);
            // 
            // pbxrobotController
            // 
            this.pbxrobotController.BackColor = System.Drawing.Color.Transparent;
            this.pbxrobotController.Image = ((System.Drawing.Image)(resources.GetObject("pbxrobotController.Image")));
            this.pbxrobotController.Location = new System.Drawing.Point(709, 12);
            this.pbxrobotController.Name = "pbxrobotController";
            this.pbxrobotController.Size = new System.Drawing.Size(49, 43);
            this.pbxrobotController.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxrobotController.TabIndex = 6;
            this.pbxrobotController.TabStop = false;
            this.pbxrobotController.Tag = "robot";
            // 
            // TopDownShooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 795);
            this.Controls.Add(this.pbxplayerController);
            this.Controls.Add(this.pbxrobotController);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbprogressHealth);
            this.DoubleBuffered = true;
            this.Name = "TopDownShooter";
            this.Text = "TopDownShooter";
            this.Load += new System.EventHandler(this.TopDownShooter_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxplayerController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxrobotController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbprogressHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbxrobotController;
        private System.Windows.Forms.PictureBox pbxplayerController;
        private System.Windows.Forms.Timer gameStart;
    }
}