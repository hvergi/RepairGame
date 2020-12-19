using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MadnathRepairGame.Data.ItemData;

namespace MadnathRepairGame.Models
{
    public class Item
    {
        public string Name { get; set; }
        public ItemCatagories ItemCatagory { get; set; }
        public int Diffculty { get; set; }
        public int Chance { get; set; }
        public float Value { get; set; }

        public Item(string name, ItemCatagories itemCatagory, int diffculty, int chance, float value)
        {
            Name = name;
            ItemCatagory = itemCatagory;
            Diffculty = diffculty;
            Chance = chance;
            Value = value;
        }
    }
}
