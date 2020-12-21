using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class Player
    {
        //public double Coins { get; set; } = 0;
        public double[] Wallet { get; set; } = { 0, 0, 0 };
        public double RepairLevel { get; set; } = 1f;
        public string Name { get; set; } = "Insubordinate";
        public int Affinties { get; set; } = 0;
        public Stats Stats { get; set; } = new Stats();
        public int Acensions { get; set; } = 0;

        public RepairableItem[] Items { get; set; } = { 
            new RepairableItem(),
            new RepairableItem(),
            new RepairableItem(),
            new RepairableItem(),
            new RepairableItem(),
            new RepairableItem(),
            new RepairableItem(),
            new RepairableItem(),
        };

        public bool[] WorkstationUnlocked { get; set; } = { false, false, false, false, false, false, false, false };

        public Dictionary<string, int> BoughtItems { get; set; } = new Dictionary<string, int>();

        //public Dictionary<string, double> AchivementProgress { get; set; } = new Dictionary<string, double>();

        private Random rng = new Random();

        public void AddCurrency(Data.ShopData.Currency currency, double amount)
        {
            Wallet[(int)currency] += amount;
            Dictionary<string, double> currencyStat = new Dictionary<string, double>();
            currencyStat.Add(currency.ToString() + " Earned", amount);
            Stats.AwardStat(currencyStat);
        }
        public void SpendCurrency(Data.ShopData.Currency currency, double amount)
        {
            Wallet[(int)currency] -= amount;
            Dictionary<string, double> currencyStat = new Dictionary<string, double>();
            currencyStat.Add(currency.ToString() + " Spent", amount);
            Stats.AwardStat(currencyStat);
        }

        public void AwardEXP(double amount)
        {
            RepairLevel +=amount;
        }

        public double GetAffintyBonus()
        {
            double bonusEXP = 1;
            if (Affinties > 0)
            {
                bonusEXP += (Affinties * 10) / 100;
            }
            return bonusEXP;
        }

        public bool CanBuy(Data.ShopData.Currency currency, double amount)
        {
            return Wallet[(int)currency] >= amount;
        }

        public int GetNumberBought(string key)
        {
            if (BoughtItems.ContainsKey(key))
                return BoughtItems[key];
            else return 0;
        }

        public double GetCurrency(Data.ShopData.Currency currency)
        {
            return Wallet[(int)currency];
        }

        public bool BuyItem(ShopItem shopItem)
        {
            int numBought = GetNumberBought(shopItem.GetItemKey());
            if (shopItem.CanBuyAnother(numBought))
                if (CanBuy(shopItem.Currency, shopItem.GetPrice(numBought)))
                {
                    SpendCurrency(shopItem.Currency, shopItem.GetPrice(numBought));
                    Stats.AwardStat(shopItem.GetStats(numBought));
                    numBought++;
                    BoughtItems[shopItem.GetItemKey()] = numBought;
                    return true;
                }
            return false;
        }

        public double GetAchivementProgress(string key)
        {
            return Stats.GetAllStatCount(key);
        }

        public bool IsAchivementUnlocked(AchivementItem item)
        {
            if (item.IsAchivementHidden)
            {
                double progress = GetAchivementProgress(item.StatKey);
                if (progress >= item.AchivementTiers[0])
                    return true;
                return false;
            }
            return true;
        }


        public Radzen.NotificationMessage RareCurrencyRoll()
        {
            int roll = rng.Next(0, 10000);
            if(roll == 0)
            {
                AddCurrency(Data.ShopData.Currency.RareCoins, 1);
                Radzen.NotificationMessage message = new Radzen.NotificationMessage()
                {
                    Severity = Radzen.NotificationSeverity.Success,
                    Summary = "Rare Roll",
                    Detail = "While repairing you found a " + Data.ShopData.Currencies[(int)Data.ShopData.Currency.RareCoins],
                    Duration = 5000
                };
                return message;
            }
            return null;
        }
        public Radzen.NotificationMessage AffintyRoll()
        {
            int roll = rng.Next(0, 3600000);
            if (roll == 0)
            {
                Affinties++;
                Radzen.NotificationMessage message = new Radzen.NotificationMessage()
                {
                    Severity = Radzen.NotificationSeverity.Success,
                    Summary = "Event",
                    Detail = "While repairing you learned something new, that will increase your rate of knowedge gain",
                    Duration = 5000
                };
                return message;
            }
            return null;
        }


    }
}
