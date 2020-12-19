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
            new Models.ChangelogArticle("Beta 0.1.0","Dec 18th 2020",
                "First beta release of MRG",
                new Models.ChangeLogItem[] {
                new Models.ChangeLogItem("Game moved from javascript to blazor wasm",Models.ChangeLogItem.ChangeTypes.Change),
            }),
        };
    }
}
