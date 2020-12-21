using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Data
{
    public class AchivementData
    {
        public static Models.AchivementItem[] Achivements = {
            new Models.AchivementItem("Repair Items",Data.StatData.RepairItem,new double[]{1,10,100,1000,10000,50000,100000,250000,500000,1000000}),
        };
    }
}
