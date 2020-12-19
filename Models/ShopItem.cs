using MadnathRepairGame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class ShopItem
    {
        public string Name { get; set; }
        public int BuyLimit { get; set; }
        public double Price { get; set; }

        public string Description { get; set; }
        public ShopData.Currency Currency { get; set; }
        public ShopData.Shop Shop { get; set; }


        public ShopItem(string name, int buyLimit, int price, string description)
        {
            Name = name;
            BuyLimit = buyLimit;
            Price = price;
            Currency = ShopData.Currency.Coins;
            Shop = ShopData.Shop.Market;
            Description = description;
        }
        public ShopItem(string name, int buyLimit, int price, string description, ShopData.Currency currency, ShopData.Shop shop)
        {
            Name = name;
            BuyLimit = buyLimit;
            Price = price;
            Currency = currency;
            Shop = shop;
            Description = description;
        }

        public string GetItemKey()
        {
            return Shop.ToString() + Name;
        }

        public bool CanBuyAnother(int bought)
        {
            if (BuyLimit == -1)
                return true;
            else
                return bought < BuyLimit;
        }

        public double GetPrice(double numBought)
        {
            if (BuyLimit == 1)
                return Price;
            if (BuyLimit == -1)
                return Price;
            return Math.Floor(Price * Math.Pow(1.1,numBought));
        }

        public Dictionary<string, double> GetStats(double numBought)
        {
            Dictionary<string, double> val = new Dictionary<string, double>();
            val.Add("Shop Purchase", 1);
            val.Add(Shop.ToString()+" Purchase", 1);
            val.Add("Purchased " + Name, 1);
            return val;
        }
    }
}
