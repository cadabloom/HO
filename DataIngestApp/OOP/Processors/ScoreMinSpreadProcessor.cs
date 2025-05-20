using DataIngestApp.OOP;
using DataIngestApp.OOP.Base;
using DataIngestApp.OOP.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIngestApp.OOP.Processors
{
    internal class ScoreMinSpreadProcessor : BaseSpreadProcessor, IProcessor<ScoreData>
    {
        public BaseResult Process(DataContainer<ScoreData> container)
        {
            foreach (var row in container.Data)
                ProcessInput(row.Key, row.ForScore, row.AgainstScore);

            return spreadResult;
        }
    }
}
