using MadnathRepairGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Data
{
    public class NpcData
    {
        public enum NpcID { }
        public enum NpcCatagories {
            Townsfolk = 0,
            Tradesmen = 1,
            Adventurers = 2,
            Military = 3,
            Clergy = 4,
            Nobles = 5,
            Royalty = 6,
            Special = 7
        }
        
        public static Npc[] Npcs = {
            new Npc("Youngster", NpcCatagories.Townsfolk, 10,30,0,0.5,new ItemData.ItemID[1],new int[]{10,10,1,0,0,0,0,1 },20,80),
            new Npc("Young Adult", NpcCatagories.Townsfolk, 10,50,10,0.75,new ItemData.ItemID[1],new int[]{10,10,10,3,3,0,1,0 },30,50),
            new Npc("Adult", NpcCatagories.Townsfolk, 30,50,15,1,new ItemData.ItemID[1],new int[]{10,10,10,0,0,1,3,1 },40,75),
            new Npc("Aged Adult", NpcCatagories.Townsfolk, 30,50,15,1,new ItemData.ItemID[1],new int[]{10,10,10,0,0,2,1,2 },40,75),
            new Npc("Elder", NpcCatagories.Townsfolk, 10,75,20,1.5,new ItemData.ItemID[1],new int[]{10,10,5,2,2,5,2,5 },30,50),

            new Npc("Local Merchant", NpcCatagories.Tradesmen, 30,50,20,2,new ItemData.ItemID[1],new int[]{0,5,5,0,0,0,10,0 },30,50),
            new Npc("Traveling Merchant", NpcCatagories.Tradesmen, 30,50,20,2,new ItemData.ItemID[1],new int[]{0,5,5,0,0,0,10,0 },30,50),
            new Npc("Stallkeep", NpcCatagories.Tradesmen, 30,50,20,2,new ItemData.ItemID[1],new int[]{0,5,5,0,0,0,10,0 },30,50),
            new Npc("Trades 1", NpcCatagories.Tradesmen, 30,50,20,2,new ItemData.ItemID[1],new int[]{0,5,5,0,0,0,10,0 },30,50),
            new Npc("Trades 2", NpcCatagories.Tradesmen, 30,50,20,2,new ItemData.ItemID[1],new int[]{0,5,5,0,0,0,10,0 },30,50),

            new Npc("Adventurer 1", NpcCatagories.Adventurers, 30,60,30,1,new ItemData.ItemID[1],new int[]{0,5,2,10,10,0,0,0 },50,75),
            new Npc("Adventurer 2", NpcCatagories.Adventurers, 30,60,30,1,new ItemData.ItemID[1],new int[]{0,5,2,10,10,0,0,0 },50,75),
            new Npc("Adventurer 3", NpcCatagories.Adventurers, 30,60,30,1,new ItemData.ItemID[1],new int[]{0,5,2,10,10,0,0,0 },50,75),
            new Npc("Adventurer 4", NpcCatagories.Adventurers, 30,60,30,1,new ItemData.ItemID[1],new int[]{0,5,2,10,10,0,0,0 },50,75),
            new Npc("Adventurer 5", NpcCatagories.Adventurers, 30,60,30,1,new ItemData.ItemID[1],new int[]{0,5,2,10,10,0,0,0 },50,75),

            new Npc("Guard", NpcCatagories.Military, 50,75,40,1,new ItemData.ItemID[1],new int[]{0,2,0,10,10,0,0,0 },50,80),
            new Npc("Captian", NpcCatagories.Military, 50,75,40,1,new ItemData.ItemID[1],new int[]{0,2,0,10,10,0,0,0 },50,80),
            new Npc("Knight", NpcCatagories.Military, 50,75,40,1,new ItemData.ItemID[1],new int[]{0,2,0,10,10,0,0,0 },50,80),
            new Npc("Lady", NpcCatagories.Military, 50,75,40,1,new ItemData.ItemID[1],new int[]{0,2,0,10,10,0,0,0 },50,80),
            new Npc("Lord", NpcCatagories.Military, 50,75,40,1,new ItemData.ItemID[1],new int[]{0,2,0,10,10,0,0,0 },50,80),

            new Npc("Deacon", NpcCatagories.Clergy, 10,75,50,.75,new ItemData.ItemID[1],new int[]{5,10,0,0,0,0,0,1 },50,90),
            new Npc("Priest", NpcCatagories.Clergy, 10,75,50,1,new ItemData.ItemID[1],new int[]{5,10,0,0,0,0,0,2 },50,90),
            new Npc("Bishop", NpcCatagories.Clergy, 10,75,50,1.25,new ItemData.ItemID[1],new int[]{5,10,0,0,0,0,0,3 },50,90),
            new Npc("Archbishop", NpcCatagories.Clergy, 10,75,50,1.5,new ItemData.ItemID[1],new int[]{5,10,0,0,0,0,0,4 },50,90),
            new Npc("Cardinal", NpcCatagories.Clergy, 10,75,50,1.75,new ItemData.ItemID[1],new int[]{5,10,0,0,0,0,0,5 },50,90),

            new Npc("Baron", NpcCatagories.Nobles, 50,75,60,2,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Viscount", NpcCatagories.Nobles, 50,75,60,2.2,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Count", NpcCatagories.Nobles, 50,75,60,2.4,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Marquis", NpcCatagories.Nobles, 50,75,60,2.6,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Duke", NpcCatagories.Nobles, 50,75,60,2.8,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Baroness", NpcCatagories.Nobles, 50,75,60,2,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Viscountess", NpcCatagories.Nobles, 50,75,60,2.2,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Countess", NpcCatagories.Nobles, 50,75,60,2.4,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Marquise", NpcCatagories.Nobles, 50,75,60,2.6,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),
            new Npc("Duchess", NpcCatagories.Nobles, 50,75,60,2.8,new ItemData.ItemID[1],new int[]{5,5,0,5,5,5,0,5 },50,75),


            new Npc("Royal Ambassador", NpcCatagories.Royalty, 50,90,70,3,new ItemData.ItemID[1],new int[]{10,10,0,0,0,0,0,5 },50,95),
            new Npc("Prince", NpcCatagories.Royalty, 50,90,70,3,new ItemData.ItemID[1],new int[]{0,1,0,5,5,5,0,5 },50,95),
            new Npc("Princess", NpcCatagories.Royalty, 50,90,70,3,new ItemData.ItemID[1],new int[]{0,1,0,5,5,7,0,5 },50,95),
            new Npc("King", NpcCatagories.Royalty, 50,90,70,3,new ItemData.ItemID[1],new int[]{0,1,0,5,5,2,0,10 },50,95),
            new Npc("Queen", NpcCatagories.Royalty, 50,90,70,3,new ItemData.ItemID[1],new int[]{0,1,0,5,5,7,0,10 },50,95),
        };
    }
}
