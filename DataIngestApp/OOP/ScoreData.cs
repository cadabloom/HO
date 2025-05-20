using DataIngestApp.OOP.Base;
using System.Text.Json.Serialization;

namespace DataIngestApp.OOP
{
    public class ScoreData : BaseData
    {
        [JsonPropertyName("team")]
        public string Team { get; set; } = string.Empty;

        [JsonPropertyName("F")]
        public int ForScore { get; set; }

        [JsonPropertyName("A")]
        public int AgainstScore { get; set; }

        public override string Key => Team;
    }
}
