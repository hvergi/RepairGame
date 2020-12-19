using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class Settings
    {
        public int SaveFiles {get; } = 3;
        private string SaveKey = "MRGA";
        public int TickSpeed { get; } = 100;

        public static string GameVersion { get; } = "0.0.1";


        public string GetSaveKey(int slot)
        {
            return SaveKey + slot.ToString();
        }
    }
}
