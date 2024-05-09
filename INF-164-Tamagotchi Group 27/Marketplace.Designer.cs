namespace INF_164_Tamagotchi_Group_27
{
    partial class Marketplace
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
            this.dgvMarketlist = new System.Windows.Forms.DataGridView();
            this.itemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOwnedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudQuant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.coffee = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.food = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chocolate = new System.Windows.Forms.Label();
            this.cbxFoodItem = new System.Windows.Forms.ComboBox();
            this.btnBuy = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.customeButtonReturnToPet = new INF_164_Tamagotchi_Group_27.CustomButton();
            this.lblMarketCurrency = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarketlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarketlist
            // 
            this.dgvMarketlist.AllowUserToDeleteRows = false;
            this.dgvMarketlist.AutoGenerateColumns = false;
            this.dgvMarketlist.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvMarketlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMarketlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarketlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.amountOwnedDataGridViewTextBoxColumn});
            this.dgvMarketlist.DataSource = this.marketBindingSource;
            this.dgvMarketlist.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMarketlist.Location = new System.Drawing.Point(12, 12);
            this.dgvMarketlist.Name = "dgvMarketlist";
            this.dgvMarketlist.ReadOnly = true;
            this.dgvMarketlist.Size = new System.Drawing.Size(501, 302);
            this.dgvMarketlist.TabIndex = 0;
            // 
            // itemDataGridViewTextBoxColumn
            // 
            this.itemDataGridViewTextBoxColumn.DataPropertyName = "Item";
            this.itemDataGridViewTextBoxColumn.HeaderText = "Item";
            this.itemDataGridViewTextBoxColumn.Name = "itemDataGridViewTextBoxColumn";
            this.itemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountOwnedDataGridViewTextBoxColumn
            // 
            this.amountOwnedDataGridViewTextBoxColumn.DataPropertyName = "Amount_Owned";
            this.amountOwnedDataGridViewTextBoxColumn.HeaderText = "Amount_Owned";
            this.amountOwnedDataGridViewTextBoxColumn.Name = "amountOwnedDataGridViewTextBoxColumn";
            this.amountOwnedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marketBindingSource
            // 
            this.marketBindingSource.DataSource = typeof(INF_164_Tamagotchi_Group_27.Market);
            // 
            // nudQuant
            // 
            this.nudQuant.Location = new System.Drawing.Point(225, 164);
            this.nudQuant.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudQuant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuant.Name = "nudQuant";
            this.nudQuant.Size = new System.Drawing.Size(120, 20);
            this.nudQuant.TabIndex = 2;
            this.nudQuant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantity of item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item to purchase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // coffee
            // 
            this.coffee.AutoSize = true;
            this.coffee.Location = new System.Drawing.Point(182, 327);
            this.coffee.Name = "coffee";
            this.coffee.Size = new System.Drawing.Size(0, 13);
            this.coffee.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // food
            // 
            this.food.AutoSize = true;
            this.food.Location = new System.Drawing.Point(80, 327);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(0, 13);
            this.food.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 11;
            // 
            // chocolate
            // 
            this.chocolate.AutoSize = true;
            this.chocolate.Location = new System.Drawing.Point(303, 327);
            this.chocolate.Name = "chocolate";
            this.chocolate.Size = new System.Drawing.Size(0, 13);
            this.chocolate.TabIndex = 12;
            // 
            // cbxFoodItem
            // 
            this.cbxFoodItem.FormattingEnabled = true;
            this.cbxFoodItem.Items.AddRange(new object[] {
            "Food",
            "Coffee ",
            "Chocolate"});
            this.cbxFoodItem.Location = new System.Drawing.Point(28, 164);
            this.cbxFoodItem.Name = "cbxFoodItem";
            this.cbxFoodItem.Size = new System.Drawing.Size(120, 21);
            this.cbxFoodItem.TabIndex = 13;
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBuy.BackgroundColor = System.Drawing.Color.DarkOrchid;
            this.btnBuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBuy.BorderRadius = 10;
            this.btnBuy.BorderSize = 0;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.ForeColor = System.Drawing.Color.White;
            this.btnBuy.Location = new System.Drawing.Point(28, 208);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(317, 27);
            this.btnBuy.TabIndex = 1;
            this.btnBuy.Text = "Buy";
            this.btnBuy.TextColor = System.Drawing.Color.White;
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // customeButtonReturnToPet
            // 
            this.customeButtonReturnToPet.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customeButtonReturnToPet.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customeButtonReturnToPet.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customeButtonReturnToPet.BorderRadius = 20;
            this.customeButtonReturnToPet.BorderSize = 0;
            this.customeButtonReturnToPet.FlatAppearance.BorderSize = 0;
            this.customeButtonReturnToPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customeButtonReturnToPet.ForeColor = System.Drawing.Color.White;
            this.customeButtonReturnToPet.Location = new System.Drawing.Point(366, 208);
            this.customeButtonReturnToPet.Name = "customeButtonReturnToPet";
            this.customeButtonReturnToPet.Size = new System.Drawing.Size(141, 27);
            this.customeButtonReturnToPet.TabIndex = 14;
            this.customeButtonReturnToPet.Text = "Return";
            this.customeButtonReturnToPet.TextColor = System.Drawing.Color.White;
            this.customeButtonReturnToPet.UseVisualStyleBackColor = false;
            this.customeButtonReturnToPet.Click += new System.EventHandler(this.customeButtonReturnToPet_Click);
            // 
            // lblMarketCurrency
            // 
            this.lblMarketCurrency.AutoSize = true;
            this.lblMarketCurrency.Location = new System.Drawing.Point(363, 147);
            this.lblMarketCurrency.Name = "lblMarketCurrency";
            this.lblMarketCurrency.Size = new System.Drawing.Size(58, 13);
            this.lblMarketCurrency.TabIndex = 15;
            this.lblMarketCurrency.Text = "Currency : ";
            // 
            // Marketplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(519, 257);
            this.Controls.Add(this.lblMarketCurrency);
            this.Controls.Add(this.customeButtonReturnToPet);
            this.Controls.Add(this.cbxFoodItem);
            this.Controls.Add(this.chocolate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.food);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.coffee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudQuant);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.dgvMarketlist);
            this.Name = "Marketplace";
            this.Text = "Market";
            this.Load += new System.EventHandler(this.Marketplace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarketlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarketlist;
        private CustomButton btnBuy;
        private System.Windows.Forms.NumericUpDown nudQuant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label coffee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label food;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label chocolate;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOwnedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource marketBindingSource;
        private System.Windows.Forms.ComboBox cbxFoodItem;
        private CustomButton customeButtonReturnToPet;
        private System.Windows.Forms.Label lblMarketCurrency;
    }
}