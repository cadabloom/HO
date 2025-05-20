using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIngestApp.OOP.Base
{
    public abstract class BaseResult
    {
        public string Key { get; set; } = string.Empty;

        public abstract void PrintOutput();
    }
}
