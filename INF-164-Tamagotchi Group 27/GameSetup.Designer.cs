namespace INF_164_Tamagotchi_Group_27
{
    partial class GameSetup
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
            this.cbxSelectCharacter = new System.Windows.Forms.ComboBox();
            this.btnPlay = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbtnClose = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnMainMenu = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.btnLoad = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.SuspendLayout();
            // 
            // cbxSelectCharacter
            // 
            this.cbxSelectCharacter.BackColor = System.Drawing.SystemColors.Window;
            this.cbxSelectCharacter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSelectCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSelectCharacter.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectCharacter.ForeColor = System.Drawing.Color.Teal;
            this.cbxSelectCharacter.FormattingEnabled = true;
            this.cbxSelectCharacter.ItemHeight = 15;
            this.cbxSelectCharacter.Items.AddRange(new object[] {
            "Square",
            "Triangle"});
            this.cbxSelectCharacter.Location = new System.Drawing.Point(532, 177);
            this.cbxSelectCharacter.Name = "cbxSelectCharacter";
            this.cbxSelectCharacter.Size = new System.Drawing.Size(153, 23);
            this.cbxSelectCharacter.Sorted = true;
            this.cbxSelectCharacter.TabIndex = 2;
            this.cbxSelectCharacter.Text = "Select Character";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPlay.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPlay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPlay.BorderRadius = 8;
            this.btnPlay.BorderSize = 0;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(93, 249);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(139, 39);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.TextColor = System.Drawing.Color.White;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 177);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pet Name";
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
            this.cbtnClose.Location = new System.Drawing.Point(535, 381);
            this.cbtnClose.Name = "cbtnClose";
            this.cbtnClose.Size = new System.Drawing.Size(150, 40);
            this.cbtnClose.TabIndex = 6;
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
            this.btnMainMenu.Location = new System.Drawing.Point(363, 381);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(150, 40);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "MAIN MENU";
            this.btnMainMenu.TextColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLoad.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLoad.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLoad.BorderRadius = 8;
            this.btnLoad.BorderSize = 0;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(93, 306);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(139, 39);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.TextColor = System.Drawing.Color.White;
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // GameSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF_164_Tamagotchi_Group_27.Properties.Resources.Back1Resized1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.cbtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.cbxSelectCharacter);
            this.DoubleBuffered = true;
            this.Name = "GameSetup";
            this.Text = "GameSetup";
            this.Load += new System.EventHandler(this.GameSetup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSelectCharacter;
        private CustomButton btnPlay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private CustomButton cbtnClose;
        private CustomButton btnMainMenu;
        private CustomButton btnLoad;
    }
}