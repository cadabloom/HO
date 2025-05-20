using DataIngestApp.OOP.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataIngestApp.OOP.Results;
using System.ComponentModel;

namespace DataIngestApp.OOP.Processors
{
    public abstract class BaseSpreadProcessor
    {
        public SpreadResult spreadResult { get; set; } = new SpreadResult();
        
        protected void ProcessInput(string key, int minuend, int subtrahend) 
        {
            int spread = Math.Abs(minuend - subtrahend);
            if (spread < spreadResult.Spread)
            {
                spreadResult.Spread = spread;
                spreadResult.Key = key;
            }
        }
    }
}
