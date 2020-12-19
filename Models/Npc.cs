using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MadnathRepairGame.Data.ItemData;
using static MadnathRepairGame.Data.NpcData;

namespace MadnathRepairGame.Models
{
    public class Npc
    {
        public string Name { get; set; }
        public NpcCatagories NpcCatagory { get; set; }
        public int MinQL { get; set; }
        public int MaxQL { get; set; }
        public int MinDmg { get; set; }
        public int MaxDmg { get; set; }
        public int MinDiffculty { get; set; }
        public double PriceMulti { get; set; }
        public ItemID[] SpecialItems { get; set; }
        public int[] ItemChances { get; set; }

        public Npc(string name, NpcCatagories npcCatagory, int minQl, int maxQl, int minDif, double priceMulti, ItemID[] specialItems, int[] itemchances, int minDmg, int maxDmg)
        {
            Name = name;
            NpcCatagory = npcCatagory;
            MinQL = minQl;
            MaxQL = maxQl;
            MinDmg = minDmg;
            MaxDmg = maxDmg;
            MinDiffculty = minDif;
            PriceMulti = priceMulti;
            SpecialItems = specialItems;
            ItemChances = itemchances;
        }
    }
}
