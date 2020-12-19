using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Data
{
    public class ShopData
    {
        public enum Currency
        {
            Coins,
            RareCoins,
            MasterMarks
        }

        public enum Shop
        {
            Market,
            BackAlley,
            MasterworkGuild
        }

        public static string[] Currencies =
        {
            "Coins",
            "Rare Coins",
            "Masterwork Marks"
        };

        public static string[] Shops =
        {
            "Market",
            "BackAlley",
            "Masterwork Guild"
        };
    }
}
