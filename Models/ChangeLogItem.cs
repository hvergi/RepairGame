using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadnathRepairGame.Models
{
    public class ChangeLogItem
    {
        
        public string Title { get; set; }
        public ChangeTypes ChangeType { get; set; }

        public ChangeLogItem(string title, ChangeTypes changeType)
        {
            Title = title;
            ChangeType = changeType;
        }
        
        
        public enum ChangeTypes
        {
            New,
            Change,
            Fix,
            Removed
        }

        public static string[] ChangeCss =
        {
            "badge badge-pill badge-success",
            "badge badge-pill badge-primary",
            "badge badge-pill badge-warning",
            "badge badge-pill badge-danger"
        };

        public static string[] ChangeText =
        {
            "NEW",
            "CHANGE",
            "FIXED",
            "REMOVED",
        };
    }

}
