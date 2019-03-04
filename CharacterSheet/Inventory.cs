using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Inventory
    {
        public List<Item> mItems;

        public Inventory()
        {
            mItems = new List<Item>();
        }

        public int GetTotalValue()
        {
            int total = 0;
            foreach (Item item in mItems)
            {
                total += item.mValue;
            }
            return total;
        }

        public float GetTotalWeight()
        {
            float total = 0;
            foreach (Item item in mItems)
            {
                total += item.GetTotalWeight();
            }
            return total;
        }

        
    }

    public class Item
    {
        //Name of the item.
        public string   mName;
        //Value in gold.
        public int      mValue;
        //Weight of item.
        public float    mWeight;
        //URL for reference of the item, optional
        public string   mURL;
        //The items contained by this item.
        public List<Item> mItems;

        //Item constructor.
        public Item(string name, int value, float weight, string url = null)
        {
            mName   = name;
            mValue  = value;
            mWeight = weight;
            mURL = url;

            mItems = new List<Item>();
        }

        internal float GetTotalWeight()
        {
            float total = mWeight;
            foreach (Item item in mItems)
            {
                total += item.mWeight;
            }
            return total;
        }

        internal int GetTotalValue()
        {
            int total = mValue;
            foreach (Item item in mItems)
            {
                total += item.mValue;
            }
            return total;
        }
    }
}
