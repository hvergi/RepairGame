using MadnathRepairGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Data
{
    public class ItemData
    {
        public enum ItemID { }
        public enum ItemRarity
        {
            Common = 0,
            Uncommon,
            Rare,
            Phenomenal,
            Heirloom,
            Empyrean
        }

        public enum ItemCatagories
        {
            Household = 0,
            Clothes = 1,
            Tools = 2,
            Weapons = 3,
            Armour = 4,
            Jewelry = 5,
            Trades = 6,
            Antiques = 7,
            Special = 8
        }

        public static double[,] RARITYBONUS =
        {
            { 1,   0},
            { 1.5, 5},
            { 2,   10},
            { 3,   15},
            { 4,   20},
            { 5,   25},
        };

        public static Item[] Items =
        {
            new Item("Spoon",ItemCatagories.Household,10,12,1),
            new Item("Plate",ItemCatagories.Household,10,12,1),
            new Item("Knife",ItemCatagories.Household,15,10,1),
            new Item("Fork",ItemCatagories.Household,15,10,1),
            new Item("Chair",ItemCatagories.Household,20,8,1),
            new Item("Table",ItemCatagories.Household,25,6,1),
            new Item("Rug",ItemCatagories.Household,25,6,1),
            new Item("Candle",ItemCatagories.Household,30,3,1.1f),
            new Item("Cup",ItemCatagories.Household,30,3,1.1f),
            new Item("Clock",ItemCatagories.Household,40,1,1.2f),

            new Item("Socks",ItemCatagories.Clothes,15,12,1),
            new Item("Scarf",ItemCatagories.Clothes,15,12,1),
            new Item("Pants",ItemCatagories.Clothes,20,10,1),
            new Item("Shirt",ItemCatagories.Clothes,20,10,1),
            new Item("Tie",ItemCatagories.Clothes,25,8,1),
            new Item("Left Shoe",ItemCatagories.Clothes,30,6,1),
            new Item("Right Shoe",ItemCatagories.Clothes,30,6,1),
            new Item("Cloak",ItemCatagories.Clothes,35,3,1.2f),
            new Item("Hat",ItemCatagories.Clothes,35,3,1.2f),
            new Item("Undergarmets",ItemCatagories.Clothes,45,1,1.5f),

            new Item("Needle",ItemCatagories.Tools,20,12,1),
            new Item("Awl",ItemCatagories.Tools,20,12,1),
            new Item("Hammer",ItemCatagories.Tools,25,10,1),
            new Item("Mallet",ItemCatagories.Tools,25,10,1),
            new Item("Scissors",ItemCatagories.Tools,30,8,1),
            new Item("Pickaxe",ItemCatagories.Tools,35,6,1),
            new Item("Hatchet",ItemCatagories.Tools,35,6,1),
            new Item("Saw",ItemCatagories.Tools,40,3,1.2f),
            new Item("Pliers",ItemCatagories.Tools,40,3,1.2f),
            new Item("Tweezers",ItemCatagories.Tools,50,1,1.5f),

            new Item("Club",ItemCatagories.Weapons,30,12,1.2f),
            new Item("Dagger",ItemCatagories.Weapons,30,12,1.2f),
            new Item("Shortsword",ItemCatagories.Weapons,35,10,1.2f),
            new Item("Maul",ItemCatagories.Weapons,35,10,1.2f),
            new Item("Staff",ItemCatagories.Weapons,40,8,1.2f),
            new Item("Longsword",ItemCatagories.Weapons,45,6,1.2f),
            new Item("Scimitar",ItemCatagories.Weapons,45,6,1.2f),
            new Item("Pike",ItemCatagories.Weapons,50,3,1.5f),
            new Item("Broadsword",ItemCatagories.Weapons,50,3,1.5f),
            new Item("Crossbow",ItemCatagories.Weapons,60,1,1.75f),

            new Item("Cloth Armour",ItemCatagories.Armour,30,12,1.2f),
            new Item("Cloth Horse Armour",ItemCatagories.Armour,30,12,1.2f),
            new Item("Leather Armour",ItemCatagories.Armour,35,10,1.2f),
            new Item("Leather Horse Armour",ItemCatagories.Armour,35,10,1.2f),
            new Item("Shield",ItemCatagories.Armour,40,8,1.2f),
            new Item("Chain Armour",ItemCatagories.Armour,45,6,1.2f),
            new Item("Chain Horse Armour",ItemCatagories.Armour,45,6,1.2f),
            new Item("Plate Armour",ItemCatagories.Armour,50,3,1.5f),
            new Item("Plate Hourse Armour",ItemCatagories.Armour,50,3,1.5f),
            new Item("Dragon Armour",ItemCatagories.Armour,60,1,1.75f),

            new Item("Sliver Ring",ItemCatagories.Jewelry,50,12,2),
            new Item("Chain Necklace",ItemCatagories.Jewelry,50,12,2),
            new Item("Earing",ItemCatagories.Jewelry,55,10,2),
            new Item("Gold Ring",ItemCatagories.Jewelry,55,10,2),
            new Item("Cufflinks",ItemCatagories.Jewelry,60,8,2),
            new Item("Ornate Necklace",ItemCatagories.Jewelry,65,6,2),
            new Item("Ornate Earings",ItemCatagories.Jewelry,65,6,2),
            new Item("Pearl Necklace",ItemCatagories.Jewelry,70,3,2),
            new Item("Diamond Ring",ItemCatagories.Jewelry,70,3,2),
            new Item("Pocketwatch",ItemCatagories.Jewelry,80,1,3),

            new Item("Sign",ItemCatagories.Trades,40,12,1.5f),
            new Item("Door Bell",ItemCatagories.Trades,40,12,1.5f),
            new Item("Small Cart",ItemCatagories.Trades,45,10,1.5f),
            new Item("Banner",ItemCatagories.Trades,45,10,1.5f),
            new Item("Flag",ItemCatagories.Trades,50,8,1.5f),
            new Item("Saddlebag",ItemCatagories.Trades,55,6,1.5f),
            new Item("Large Cart",ItemCatagories.Trades,55,6,1.5f),
            new Item("Toolbelt",ItemCatagories.Trades,60,3,1.75f),
            new Item("Til",ItemCatagories.Trades,60,3,1.75f),
            new Item("Wagon",ItemCatagories.Trades,70,1,2),

            new Item("Ornate Vase",ItemCatagories.Antiques,60,12,2.5f),
            new Item("Ornate Bowl",ItemCatagories.Antiques,60,12,2.5f),
            new Item("Ornate Rug",ItemCatagories.Antiques,65,10,2.6f),
            new Item("Ornate Chest",ItemCatagories.Antiques,65,10,2.6f),
            new Item("Black Pearl Neacklace",ItemCatagories.Antiques,70,8,2.7f),
            new Item("Map",ItemCatagories.Antiques,75,6,2.8f),
            new Item("Old Book",ItemCatagories.Antiques,75,6,2.8f),
            new Item("Ornate Clock",ItemCatagories.Antiques,80,3,3),
            new Item("Ornate Jewerly",ItemCatagories.Antiques,80,3,3),
            new Item("Ornate Armour",ItemCatagories.Antiques,90,1,4),
        };
    }
}
