using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class ChangelogArticle
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public ChangeLogItem[] ChangeLogs { get; set; }

        public ChangelogArticle(string title, string date, string desc, ChangeLogItem[] changeLogs)
        {
            Title = title;
            Date = date;
            Description = desc;
            ChangeLogs = changeLogs;
        }
    }
}
