using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class SaveModel
    {
        public Account Account { get; set; }
        public Player Player { get; set; }

        public SaveModel(Account account, Player player)
        {
            Account = account;
            Player = player;
        }
        public SaveModel() { }
    }
}
