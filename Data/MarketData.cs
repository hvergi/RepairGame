using MadnathRepairGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Data
{
    public class MarketData
    {
        public enum MarketBuyable {
            WorkstationUnlock1 = 0,
            WorkstationUnlock2 = 1,
            WorkstationUnlock3 = 2,
            WorkstationUnlock4 = 3,
            WorkstationUnlock5 = 4,
            WorkstationUnlock6 = 5,
            WorkstationUnlock7 = 6,
            WorkstationUnlock8 = 7,
        }

        public static ShopItem[] shopItems =
        {
            new ShopItem("Workstation 1 Unlock",1,0,"Unlocks a workstation for repairing items."),
            new ShopItem("Workstation 2 Unlock",1,1000,"Unlocks a workstation for repairing items."),
            new ShopItem("Workstation 3 Unlock",1,4500,"Unlocks a workstation for repairing items."),
            new ShopItem("Workstation 4 Unlock",1,9000,"Unlocks a workstation for repairing items."),
            new ShopItem("Workstation 5 Unlock",1,15000,"Unlocks a workstation for repairing items."),
            new ShopItem("Workstation 6 Unlock",1,30000,"Unlocks a workstation for repairing items."),
            new ShopItem("Workstation 7 Unlock",1,90000,"Unlocks a workstation for repairing items."),
            new ShopItem("Workstation 8 Unlock",1,150000,"Unlocks a workstation for repairing items."),
        };
    }
}
