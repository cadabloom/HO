using DataIngestApp.OOP;
using DataIngestApp.OOP.Base;
using DataIngestApp.OOP.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataIngestApp.OOP.Processors
{
    public class WeatherMinSpreadProcessor : BaseSpreadProcessor, IProcessor<WeatherData>
    {
        public BaseResult Process(DataContainer<WeatherData> container)
        {
            foreach (var row in container.Data)
                ProcessInput(row.Key, row.MaxTemp, row.MinTemp);

            return spreadResult;
        }
    }
}
