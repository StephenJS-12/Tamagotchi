using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INF_164_Tamagotchi_Group_27
{
    [Serializable]
    public class Tamagotchi
    {
        //Data Members
        private string mName;
        private string mType;
        private int mHappinessIndex;
        private int mSleep;
        private int mAttention;
        private int mHunger;
        private int mCurrency;
        private int mFood;
        private int mCoffee;
        private int mChocolate;

        //Constructors
        public Tamagotchi()
        {
            mName = "";
            mHappinessIndex = 100;
            mSleep = 100;
            mAttention = 100;
            mHunger = 100;
            mType = "";
            mCurrency = 0;
            mFood = 0;
            mCoffee = 0;
            mChocolate = 0;
        }

        public Tamagotchi(string name, int happiness, int sleep, int attention, int hunger, string type, int currency, int food, int coffee, int chocolate)
        {
            mName = name;
            mHappinessIndex = happiness;
            mSleep = sleep;
            mHunger = hunger;
            mAttention = attention;
            mType = type;
            mCurrency = currency;
            //maybe delete
            mFood = food;
            mCoffee = coffee;
            mChocolate= chocolate;
        }

        //Get/Set Methods
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public int Happiness
        {
            get { return mHappinessIndex; }
            set { mHappinessIndex = value; }
        }

        public int Sleep
        {
            get { return mSleep; }
            set { mSleep = value; }
        }

        public int Hunger
        {
            get { return mHunger; }
            set { mHunger = value; }
        }

        public int Attention
        {
            get { return mAttention; }
            set { mAttention = value; }
        }

        public string Type 
        { 
            get { return mType; } 
            set { mType = value; }
        }

        public int Currency
        {
            get { return mCurrency; }
            set { mCurrency = value; }
        }

        public int Food
        {
            get { return mFood; }
            set { mFood = value;}
        }

        public int Coffee
        {
            get { return mCoffee; }
            set { mCoffee = value; }
        }

        public int Chocolate
        {
            get { return mChocolate; }
            set { mChocolate = value; }
        }

        //Methods and events

        public void SaveState()
        {
            StreamWriter save = new StreamWriter("PetData.txt");
            save.WriteLine( mName + "," +
                            mHappinessIndex + "," + 
                            mSleep + "," + 
                            mHunger + "," + 
                            mAttention + "," + 
                            mType + "," +
                            mFood + "," + 
                            mCoffee + "," + 
                            mChocolate + "," +
                            mCurrency);

            save.Close(); 
        }

        public void Load_Pet()
        {
            StreamReader reader = new StreamReader("PetData.txt");
            string line = reader.ReadLine();
            string name = "";
            string happiness = "";
            string sleep = "";
            string hunger = "";
            string attention = "";
            string type = "";
            string currency = "";
            string food = "";
            string coffee = "";
            string chocolate = "";
            bool name_done = false;
            bool happiness_done = false;
            bool sleep_done = false;
            bool food_done = false;
            bool attention_done = false;
            bool type_done = false;
            bool foodInv_done = false;
            bool coffeeInv_done = false;
            bool chocolateInv_done = false;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].ToString() != "," && name_done == false)
                {
                    name += line[i];
                }
                else if (line[i].ToString() == "," && name_done == false)
                {
                    name_done = true;
                }
                else if (line[i].ToString() != "," && name_done == true && happiness_done == false)
                {
                    happiness += line[i];
                }
                else if (line[i].ToString() == "," && name_done == true && happiness_done == false)
                {
                    happiness_done = true;
                }
                else if (line[i].ToString() != "," && happiness_done == true && sleep_done == false)
                {
                    sleep += line[i];
                }
                else if (line[i].ToString() == "," && happiness_done == true && sleep_done == false)
                {
                    sleep_done = true;
                }
                else if (line[i].ToString() != "," && sleep_done == true && food_done == false)
                {
                    hunger += line[i];
                }
                else if (line[i].ToString() == "," && sleep_done == true && food_done == false)
                {
                    food_done = true;
                }
                else if (line[i].ToString() != "," && food_done == true && attention_done == false)
                {
                    attention += line[i];
                }
                else if (line[i].ToString() == "," && food_done == true && attention_done == false)
                {
                    attention_done = true;
                }
                else if (line[i].ToString() != "," && attention_done == true && type_done == false)
                {
                    type += line[i];
                }
                else if (line[i].ToString() == "," && attention_done == true && type_done == false)
                {
                    type_done = true;
                }
                //
                else if (line[i].ToString() != "," && type_done == true && foodInv_done == false)
                {
                    food += line[i];
                }
                else if (line[i].ToString() == "," && type_done == true && foodInv_done == false)
                {
                    foodInv_done = true;
                }
                else if (line[i].ToString() != "," && foodInv_done == true && coffeeInv_done == false)
                {
                    coffee += line[i];
                }
                else if (line[i].ToString() == "," && foodInv_done == true && coffeeInv_done == false)
                {
                    coffeeInv_done = true;
                }
                else if (line[i].ToString() != "," && coffeeInv_done == true && chocolateInv_done == false)
                {
                    chocolate += line[i];
                }
                else if (line[i].ToString() == "," && coffeeInv_done == true && chocolateInv_done == false)
                {
                    chocolateInv_done = true;
                }
                else
                {
                    currency += line[i];
                }

            }

            mName = name;
            mHappinessIndex = Convert.ToInt32(happiness);
            mSleep = Convert.ToInt32(sleep);
            mHunger = Convert.ToInt32(hunger);
            mAttention = Convert.ToInt32(attention);
            mType = type;
            mCurrency = Convert.ToInt32(currency);
            mFood = Convert.ToInt32(food);
            mCoffee = Convert.ToInt32(coffee);
            mChocolate = Convert.ToInt32(chocolate);  

            reader.Close();
        }

        public void ResetPet()
        {
            mHappinessIndex = 0;
            mSleep = 0;
            mAttention = 0;
            mHunger = 0;
        }
    }
}
