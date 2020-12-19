using MadnathRepairGame.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Factories
{
    public class ItemFactory
    {
        public static int GetNewItem(int npcID)
        {
            Random rng = new Random();
            int[] typechances = NpcData.Npcs[npcID].ItemChances;
            List<int> ItemCataRollTable = new List<int>();
            for(int i=0; i<typechances.Length; i++)
            {
                if (typechances[i] == 0)
                    continue;
                for(int j=0; j<typechances[i]; j++)
                {
                    ItemCataRollTable.Add(i);
                }
            }
            int cataRoll = rng.Next(0, ItemCataRollTable.Count);
            List<int> ItemRollTable = new List<int>();
            for(int i=0; i<ItemData.Items.Length; i++)
            {
                if((int)ItemData.Items[i].ItemCatagory == ItemCataRollTable[cataRoll])
                {
                    for(int j=0; j<ItemData.Items[i].Chance; j++)
                    {
                        ItemRollTable.Add(i);
                    }
                }
            }
            int itemRoll = rng.Next(0, ItemRollTable.Count);
            return ItemRollTable[itemRoll];
        }
    }
}
