using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class AchivementItem
    {
        public string Title { get; set; }
        public string StatKey { get; set; }
        public int AchivementCount { get; set; }
        public double[] AchivementTiers { get; set; }
        public bool IsAchivementHidden { get; set; }

        public AchivementItem(string title, string statkey, double[] achivementTiers, bool isHidden = false)
        {
            Title = title;
            StatKey = statkey;
            AchivementTiers = achivementTiers;
            AchivementCount = achivementTiers.Length;
            IsAchivementHidden = isHidden;
        }
    }
}
