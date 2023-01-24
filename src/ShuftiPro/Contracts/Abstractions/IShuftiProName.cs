using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProName : IShuftiProNameBase
    {
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        string FullName { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("fuzzy_match", DefaultValueHandling = DefaultValueHandling.Ignore)]
        bool FuzzyMatch { get; set; }
    }
}
