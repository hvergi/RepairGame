using MadnathRepairGame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MadnathRepairGame.Data.ItemData;
using static MadnathRepairGame.Data.NpcData;

namespace MadnathRepairGame.Models
{
    public class RepairableItem
    {

        const double BASEQLLOSS = 5;
        const double BASEDMG = 10;
        const double MAXLEVEL = 100;
        const double MINQLLOSS = .0001;
        const double BASEEXPGAIN = .0005;
        const double MINEXP = 0.00000000000001;
        const double MAXEXPMULTI = 1.2;

        const double NEWPLAYEREXPBONUS = 1.5;
        const double NEWPLAYERLIMIT = 15;


        public int ItemID { get; set; }
        public int Diffculty { get; set; }
        public double QLCurrent { get; set; }
        public double QLStarting { get; set; }
        public double DmgCurrent { get; set; }
        public double DmgStarting { get; set; }
        public ItemRarity ItemRarity { get; set; }
        public int NpcID { get; set; }

        public bool isEmpty { get; set; } = false;

        public double GetPrice()
        {
            double price = 10 * (QLStarting/10);
            price = price * NpcData.Npcs[NpcID].PriceMulti * ItemData.Items[ItemID].Value * ItemData.RARITYBONUS[(int)ItemRarity, 0];
            double multi = QLCurrent / QLStarting;
            return Math.Floor(price*multi);
        }

        public RepairableItem()
        {
            isEmpty = true;
        }

        public void SetRarity(int rarity)
        {
            ItemRarity = (ItemData.ItemRarity)rarity;
        }


        public string GetRepairPercent()
        {
            double percent = DmgCurrent / DmgStarting;
            return (int)Math.Floor(percent * 100) + "%";
        }

        public string GetTimeRemaining(int tickSpeed)
        {
            double amount = DmgLossTick();
            return "Time Remaining: " + ((Math.Ceiling(DmgCurrent / amount) * tickSpeed)/1000).ToString("0.0") + " secs";
        }

        public string GetItemName()
        {
            string name = "";
            name += ItemData.Items[ItemID].Name;
            return name;
        }


        public double RepairItem(double RepairLevel, double bonusexp = 1)
        {
            double dmgRepaired = DmgLossTick();
            if (dmgRepaired > DmgCurrent)
            {
                dmgRepaired = DmgCurrent;
            }
            double qlLoss = QlLossTick(dmgRepaired, RepairLevel);

            DmgCurrent -= dmgRepaired;
            QLCurrent -= qlLoss;
            if(QLCurrent < 1)
            {
                QLCurrent = 1;
            }
            return GetExpTick(RepairLevel, bonusexp);

        }

        public double DmgLossTick()
        {
            double dmgRepaired = .15 * (1 - (Diffculty / 156.25));
            return dmgRepaired;
        }

        public double QlLossTick(double dmgRepaired, double RepairLevel)
        {
            double qlLoss = (dmgRepaired * BASEQLLOSS) / BASEDMG;
            qlLoss = qlLoss * (1 - (RepairLevel / (MAXLEVEL + 25)));
            if (qlLoss < MINQLLOSS)
            {
                qlLoss = MINQLLOSS;
            }
            return qlLoss;
        }

        public double GetExpTick(double RepairLevel, double bonusexp)
        {
            if (RepairLevel >= MAXLEVEL)
            {
                return 0;
            }
            double val = 0;
            double lvlMulti = (1 - RepairLevel / MAXLEVEL);
            double adjusted = AdjustDif(RepairLevel);
            if (adjusted > MAXEXPMULTI)
            {
                val = (BASEEXPGAIN / adjusted) * lvlMulti;
            }
            else
            {
                val = (adjusted * BASEEXPGAIN) * lvlMulti;
            }
            val *= bonusexp;
            if (val < MINEXP)
                val = MINEXP;

            if(RepairLevel < NEWPLAYERLIMIT)
            {
                val *= NEWPLAYEREXPBONUS;
            }
            return val;
        }

        public double AdjustDif(double RepairLevel)
        {
            return Diffculty / GetMaxDiff(RepairLevel);
        }

        public double GetMaxDiff(double RepairLevel)
        {
            return RepairLevel * .77 + 23;
        }

        public Dictionary<string,double> GetStatList()
        {
            Dictionary<string, double> val = new Dictionary<string, double>();
            val.Add("Repair Item", 1);
            val.Add("Repair Item " + GetItemName(), 1);
            val.Add("Repair " + ItemRarity.ToString() + " Item", 1);
            val.Add("Repair Item Catagory " + Data.ItemData.Items[ItemID].ItemCatagory.ToString(), 1);
            val.Add("Repair NPC Catagory " + Data.NpcData.Npcs[NpcID].NpcCatagory.ToString(), 1);
            return val;
        }

    }

}
