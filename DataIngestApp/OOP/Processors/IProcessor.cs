using DataIngestApp.OOP;
using DataIngestApp.OOP.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataIngestApp.OOP.Processors
{
    public interface IProcessor<T> where T : BaseData
    {
        BaseResult Process(DataContainer<T> data);
    }
}
