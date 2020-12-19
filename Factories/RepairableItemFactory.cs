using MadnathRepairGame.Data;
using MadnathRepairGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Factories
{
    public class RepairableItemFactory
    {

        public static RepairableItem GetNewRepairableItem(double repairLvl)
        {
            Random rng = new Random();
            RepairableItem ri = new RepairableItem();
            ri.NpcID = NpcFactory.GetNewNpc(repairLvl);
            ri.ItemID = ItemFactory.GetNewItem(ri.NpcID);
            ri.isEmpty = false;
            ri.DmgStarting = rng.Next(NpcData.Npcs[ri.NpcID].MinDmg, NpcData.Npcs[ri.NpcID].MaxDmg);
            ri.DmgCurrent = ri.DmgStarting;
            ri.QLStarting = rng.Next(NpcData.Npcs[ri.NpcID].MinQL, NpcData.Npcs[ri.NpcID].MaxQL);
            ri.QLCurrent = ri.QLStarting;
            if (ItemData.Items[ri.ItemID].Diffculty > NpcData.Npcs[ri.NpcID].MinDiffculty)
            {
                ri.Diffculty = ItemData.Items[ri.ItemID].Diffculty;
            }
            else
            {
                ri.Diffculty = NpcData.Npcs[ri.NpcID].MinDiffculty;
            }

            int rarity = 0;
            int rarityRoll = rng.Next(0, 10);
            if(rarityRoll == 0)
            {
                rarity++;
                rarityRoll = rng.Next(0, 10);
                if (rarityRoll == 0)
                {
                    rarity++;
                    rarityRoll = rng.Next(0, 10);
                    if (rarityRoll == 0)
                    {
                        rarity++;
                        rarityRoll = rng.Next(0, 10);
                        if (rarityRoll == 0)
                        {
                            rarity++;
                            rarityRoll = rng.Next(0, 10);
                            if (rarityRoll == 0)
                            {
                                rarity++;
                            }
                        }
                    }
                }
            }
            ri.Diffculty += (int)ItemData.RARITYBONUS[rarity, 1];
            ri.SetRarity(rarity);
            return ri;
        }
    }
}
