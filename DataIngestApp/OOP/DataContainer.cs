using DataIngestApp.OOP.Base;
using DataIngestApp.OOP.Processors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataIngestApp.OOP
{
    public class DataContainer<T> where T : BaseData
    {
        public IEnumerable<T> Data { get; set; }

        public DataContainer(string jsonPath)
        {
            using StreamReader r = new StreamReader(jsonPath);
            string json = r.ReadToEnd();
            Data = JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public BaseResult Process(IProcessor<T> processor)
        {
            return processor.Process(this);
        }

    }
}
