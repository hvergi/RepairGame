using MadnathRepairGame.Data;
using MadnathRepairGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Factories
{
    public class NpcFactory
    {
        public static int[,] CatagoryChances =
        {
            { 0, 50},
            { 25, 60},
            { 40, 70},
            { 60, 80},
            { 70, 90},
            { 80, 100},
            { 90, 110},
        };

        
        public static int GetNewNpc(double repairLvl)
        {
            //Make a list of chances for the catagories, then pick one and grab a random npc from that catagory.
            //Chances for catagories are as follows, 10 in range, 5 above range, 2 1.5x above range
            List<int> CChances = new List<int>();
            Random rnd = new Random();
            for(int i=0; i < 7; i++)
            {
                if (repairLvl > (CatagoryChances[i, 1]*1.5))
                {
                    CChances.Add(i);
                    CChances.Add(i);
                }else if (repairLvl > (CatagoryChances[i, 1]))
                {
                    for(int j=0; j<5; j++)
                    {
                        CChances.Add(i);
                    }
                }else if((repairLvl > (CatagoryChances[i, 0]))){
                    for (int j = 0; j < 10; j++)
                    {
                        CChances.Add(i);
                    }
                }
            }
            int cataroll = rnd.Next(0, CChances.Count);
            List<int> npcs = new List<int>();
            for (int i = 0; i < NpcData.Npcs.Length; i++)
            {
                if ((int)NpcData.Npcs[i].NpcCatagory == CChances[cataroll])
                    npcs.Add(i);
            }

            int npcRoll = rnd.Next(0, npcs.Count);

            return npcs[npcRoll];
        }
    }
}
