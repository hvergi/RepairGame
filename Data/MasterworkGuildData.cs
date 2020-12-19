using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Data
{
    public class MasterworkGuildData
    {

        public static Models.ShopItem[] shopItems =
        {
            new Models.ShopItem("Demo",-1,1,"Demo Item",ShopData.Currency.MasterMarks,ShopData.Shop.MasterworkGuild)
        };
    }
}
