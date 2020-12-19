using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class Account
    {
        public bool isSaveLoaded { get; set; } = false;
        public string LastGameVersion { get; set; }
        public DateTime LastSaveDate { get; set; }

        public bool IsSaveValid { get; set; } = false;
    }
}
