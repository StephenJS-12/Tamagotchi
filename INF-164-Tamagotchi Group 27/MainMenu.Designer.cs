namespace INF_164_Tamagotchi_Group_27
{
    partial class frmMainMenu
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
            this.lblGameName = new System.Windows.Forms.Label();
            this.pbxMainMeu = new System.Windows.Forms.PictureBox();
            this.cbtnClose = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.cbtnInstructions = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.cbtnPlay = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.cbxMusic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainMeu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.lblGameName.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(273, 77);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(286, 32);
            this.lblGameName.TabIndex = 5;
            this.lblGameName.Text = "TAMAGOTCHI DELUXE";
            // 
            // pbxMainMeu
            // 
            this.pbxMainMeu.Image = global::INF_164_Tamagotchi_Group_27.Properties.Resources.Back1Resized1;
            this.pbxMainMeu.Location = new System.Drawing.Point(-13, -11);
            this.pbxMainMeu.Name = "pbxMainMeu";
            this.pbxMainMeu.Size = new System.Drawing.Size(825, 550);
            this.pbxMainMeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxMainMeu.TabIndex = 0;
            this.pbxMainMeu.TabStop = false;
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
            this.cbtnClose.Location = new System.Drawing.Point(329, 369);
            this.cbtnClose.Name = "cbtnClose";
            this.cbtnClose.Size = new System.Drawing.Size(150, 40);
            this.cbtnClose.TabIndex = 4;
            this.cbtnClose.Text = "CLOSE";
            this.cbtnClose.TextColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnClose.UseVisualStyleBackColor = false;
            this.cbtnClose.Click += new System.EventHandler(this.cbtnClose_Click);
            // 
            // cbtnInstructions
            // 
            this.cbtnInstructions.BackColor = System.Drawing.Color.Teal;
            this.cbtnInstructions.BackgroundColor = System.Drawing.Color.Teal;
            this.cbtnInstructions.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnInstructions.BorderRadius = 20;
            this.cbtnInstructions.BorderSize = 3;
            this.cbtnInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnInstructions.FlatAppearance.BorderSize = 0;
            this.cbtnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnInstructions.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtnInstructions.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnInstructions.Location = new System.Drawing.Point(329, 262);
            this.cbtnInstructions.Name = "cbtnInstructions";
            this.cbtnInstructions.Size = new System.Drawing.Size(150, 40);
            this.cbtnInstructions.TabIndex = 3;
            this.cbtnInstructions.Text = "INSTRUCTIONS";
            this.cbtnInstructions.TextColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnInstructions.UseVisualStyleBackColor = false;
            this.cbtnInstructions.Click += new System.EventHandler(this.cbtnInstructions_Click);
            // 
            // cbtnPlay
            // 
            this.cbtnPlay.BackColor = System.Drawing.Color.Teal;
            this.cbtnPlay.BackgroundColor = System.Drawing.Color.Teal;
            this.cbtnPlay.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnPlay.BorderRadius = 20;
            this.cbtnPlay.BorderSize = 3;
            this.cbtnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnPlay.FlatAppearance.BorderSize = 0;
            this.cbtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtnPlay.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtnPlay.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnPlay.Location = new System.Drawing.Point(329, 160);
            this.cbtnPlay.Name = "cbtnPlay";
            this.cbtnPlay.Size = new System.Drawing.Size(150, 40);
            this.cbtnPlay.TabIndex = 2;
            this.cbtnPlay.Text = "PLAY";
            this.cbtnPlay.TextColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbtnPlay.UseVisualStyleBackColor = false;
            this.cbtnPlay.Click += new System.EventHandler(this.cbtnPlay_Click);
            // 
            // cbxMusic
            // 
            this.cbxMusic.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbxMusic.AutoSize = true;
            this.cbxMusic.BackColor = System.Drawing.Color.Transparent;
            this.cbxMusic.Checked = true;
            this.cbxMusic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMusic.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbxMusic.Location = new System.Drawing.Point(708, 470);
            this.cbxMusic.Name = "cbxMusic";
            this.cbxMusic.Size = new System.Drawing.Size(45, 23);
            this.cbxMusic.TabIndex = 6;
            this.cbxMusic.Text = "Music";
            this.cbxMusic.UseVisualStyleBackColor = false;
            this.cbxMusic.CheckedChanged += new System.EventHandler(this.cbxMusic_CheckedChanged);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 511);
            this.Controls.Add(this.cbxMusic);
            this.Controls.Add(this.lblGameName);
            this.Controls.Add(this.cbtnClose);
            this.Controls.Add(this.cbtnInstructions);
            this.Controls.Add(this.cbtnPlay);
            this.Controls.Add(this.pbxMainMeu);
            this.Name = "frmMainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMainMeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMainMeu;
        private CustomButton cbtnPlay;
        private CustomButton cbtnInstructions;
        private CustomButton cbtnClose;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.CheckBox cbxMusic;
    }
}

