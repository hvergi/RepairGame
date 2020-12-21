using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Data
{
    public class ChangelogData
    {
        public static Models.ChangelogArticle[] Changelog =
        {
             new Models.ChangelogArticle("Beta 0.1.1","Dec 20th 2020",
                "Balance Changes",
                new Models.ChangeLogItem[] {
                new Models.ChangeLogItem("Added popup for when a player loads an old save.",Models.ChangeLogItem.ChangeTypes.New),
                new Models.ChangeLogItem("Achivements reenabled, Just 1 for now.",Models.ChangeLogItem.ChangeTypes.New),

                new Models.ChangeLogItem("More ql is lost during repairs, making level more important.",Models.ChangeLogItem.ChangeTypes.Change),
                new Models.ChangeLogItem("Prices of workstations adjusted to match new coin rates.",Models.ChangeLogItem.ChangeTypes.Change),
                new Models.ChangeLogItem("Affinty chance lowered by a factor of 100.",Models.ChangeLogItem.ChangeTypes.Change),
                new Models.ChangeLogItem("Rare Coins chance lowered by a factor of 3.",Models.ChangeLogItem.ChangeTypes.Change),
                new Models.ChangeLogItem("Exp rate nerfed to account for 8 workstations instead of one.",Models.ChangeLogItem.ChangeTypes.Change),

                new Models.ChangeLogItem("Fixed overwriting saveslot 1 if you refreshed the page.",Models.ChangeLogItem.ChangeTypes.Fix),

            }),
            new Models.ChangelogArticle("Beta 0.1.0","Dec 18th 2020",
                "First beta release of MRG",
                new Models.ChangeLogItem[] {
                new Models.ChangeLogItem("Game moved from javascript to blazor wasm",Models.ChangeLogItem.ChangeTypes.Change),
            }),
        };
    }
}
