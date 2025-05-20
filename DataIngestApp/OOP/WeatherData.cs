using DataIngestApp.OOP.Base;
using System.Text.Json.Serialization;

namespace DataIngestApp.OOP
{
    public class WeatherData : BaseData
    {
        [JsonPropertyName("Dy")]
        public int Day { get; set; }
        
        [JsonPropertyName("MxT")]
        public int MaxTemp { get; set; }
        
        [JsonPropertyName("MnT")]
        public int MinTemp { get; set; }

        public override string Key => Day.ToString();
    }
}
