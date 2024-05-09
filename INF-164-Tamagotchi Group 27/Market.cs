using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.ComponentModel;

namespace INF_164_Tamagotchi_Group_27
{
    public class Market
    {
        //DM
        private int mPrice;
        private int mQuantity;
        private string mItem;
        private int mOwned;


        //ctor
        public Market()
        {
           mPrice = 0;
           mQuantity = 0;
           mItem = "";
           mOwned = 0;


        }
        //ctor
        public Market (string Item, int Quantity, int Price, int Amount_Owned)
        {
            mItem = Item;
            mQuantity = Quantity;
            mPrice = Price;
            mOwned = Amount_Owned;
        }
        //getset
        public string Item
        {
            get
            {
                return mItem;
            }
            set
            {
                mItem = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public int Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public int Amount_Owned
        {
            get
            {
                return mOwned;
            }
            set
            {
                mOwned = value;
            }
        }



    }
}
