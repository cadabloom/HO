using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataIngestApp.OOP.Base;

namespace DataIngestApp.OOP.Results
{
    public class SpreadResult : BaseResult
    {
        public int Spread { get; set; } = int.MaxValue;

        public override void PrintOutput()
        {
            Console.WriteLine($"{Key}: Spread = {Spread}");
        }
    }
}
