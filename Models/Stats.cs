using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadnathRepairGame.Data;

namespace MadnathRepairGame.Models
{
    public class Stats
    {
        public Dictionary<string, double> Statistics { get; set; } = new Dictionary<string, double>();
        public Dictionary<string, double> PastStatistics { get; set; } = new Dictionary<string, double>();

        private void AddStat(string key, double amount) {
            if (Statistics.ContainsKey(key))
            {
                Statistics[key] += amount;
            }
            else
            {
                Statistics.Add(key, amount);
            }
        }

        public double GetStatCount(string key)
        {
            if (Statistics.ContainsKey(key))
                return Statistics[key];
            return 0;
        }

        public double GetAllStatCount(string key)
        {
            double val = 0;
            if (Statistics.ContainsKey(key))
                val+= Statistics[key];
            if (PastStatistics.ContainsKey(key))
                val += PastStatistics[key];
            return val;
        }

        public void AwardStat(Dictionary<string, double> value)
        {
            foreach(string key in value.Keys)
            {
                AddStat(key, value[key]);
            }
        }
    }
}
