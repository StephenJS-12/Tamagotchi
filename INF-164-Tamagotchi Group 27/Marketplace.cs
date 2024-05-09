using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;
using System.Reflection.Emit;

namespace INF_164_Tamagotchi_Group_27
{
    [Serializable]
    public partial class Marketplace : Form
    {
        public Marketplace()
        {
            InitializeComponent();
            
        }

        public Tamagotchi Pet;
        public BindingList<Market> myMarket = new BindingList<Market>();

        private void Marketplace_Load(object sender, EventArgs e)
        {
            Pet = new Tamagotchi();
            Pet.Load_Pet();
            myMarket.Add(new Market("Food", 15, 3, Pet.Food));
            myMarket.Add(new Market("Coffee", 15, 25, Pet.Coffee));
            myMarket.Add(new Market("Chocolate", 15, 7, Pet.Chocolate));

            dgvMarketlist.DataSource = myMarket;

            lblMarketCurrency.Text = "Currency : " + Convert.ToString(Pet.Currency);
        }
       
        private void btnBuy_Click(object sender, EventArgs e)
        {
            int amountBought = Convert.ToInt32(dgvMarketlist[3, 0].Value);
            int amountBought1 = Convert.ToInt32(dgvMarketlist[3, 1].Value);
            int amountBought2 = Convert.ToInt32(dgvMarketlist[3, 2].Value);

            int amount = Convert.ToInt32(dgvMarketlist[1,0].Value);
            int amount1 = Convert.ToInt32(dgvMarketlist[1,1].Value);
            int amount2 = Convert.ToInt32(dgvMarketlist[1,2].Value);

            int quant = Convert.ToInt32(nudQuant.Value);
            int price;

            if (cbxFoodItem.SelectedIndex == 0 && amount > 0 && Pet.Currency > 0)
            {
                price = quant * 3;
             
                if (quant <= amount)
                {
                    if (price <= Pet.Currency)
                    {
                        dgvMarketlist[1, 0].Value = amount - quant;
                        dgvMarketlist[3, 0].Value = amountBought + quant;
                        dgvMarketlist.Refresh();

                        Pet.Currency -= price;
                        Pet.Food += (1 * quant);
                        Pet.SaveState();
                        MessageBox.Show("You bought " + quant + " food");
                        lblMarketCurrency.Text = Convert.ToString("Currency : " + Pet.Currency);
                    }
                    else
                    {
                        MessageBox.Show("Not enough money to buy the required item");
                    }
                }
                else
                {
                    MessageBox.Show("We do not have that much food available");
                }
            }
            else if (cbxFoodItem.SelectedIndex == 1 && amount1 > 0 && Pet.Currency > 0)
            {
                price = quant * 25;

                if (quant <= amount)
                {
                    if (price <= Pet.Currency)
                    {
                        dgvMarketlist[1, 1].Value = amount1 - quant;
                        dgvMarketlist[3, 1].Value = amountBought1 + quant;
                        dgvMarketlist.Refresh();

                        Pet.Currency -= price;
                        Pet.Coffee += (1 * quant);
                        Pet.SaveState();
                        MessageBox.Show("You bought " + quant + " coffee");
                        lblMarketCurrency.Text = Convert.ToString("Currency : " + Pet.Currency);
                    }
                    else
                    {
                        MessageBox.Show("Not enough money to buy the required item");
                    }
                }
                else
                {
                    MessageBox.Show("We do not have that much coffee available");
                }
            }
            else if (cbxFoodItem.SelectedIndex == 2 && amount2 > 0 && Pet.Currency > 0)
            {
                price = quant * 7;

                if (quant <= amount)
                {
                    if (price <= Pet.Currency)
                    {
                        dgvMarketlist[1, 2].Value = amount2 - quant;
                        dgvMarketlist[3, 2].Value = amountBought2 + quant;
                        dgvMarketlist.Refresh();

                        Pet.Currency -= price;
                        Pet.Chocolate += (1 * quant);
                        Pet.SaveState();
                        MessageBox.Show("You bought " + quant + " chocolate");
                        lblMarketCurrency.Text = Convert.ToString("Currency : " + Pet.Currency);
                    }
                    else
                    {
                        MessageBox.Show("Not enough money to buy the required item");
                    }
                }
                else
                {
                    MessageBox.Show("We do not have that much chocolate available");
                }
            }
            else
            {
                MessageBox.Show("The item you selected is out of stock. We will refill soon");
            }

        }

        private void customeButtonReturnToPet_Click(object sender, EventArgs e)
        {
            Pet.SaveState();
            Gameplay form = new Gameplay();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
