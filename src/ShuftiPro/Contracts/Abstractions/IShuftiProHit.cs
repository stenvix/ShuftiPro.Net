using System.Collections.Generic;
using Newtonsoft.Json;
using ShuftiPro.Converters;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProHit
    {
        [JsonProperty("name")]
        string Name { get; set; }

        [JsonProperty("entity_type")]
        string EntityType { get; set; }

        [JsonProperty("score")]
        float Score { get; set; }

        [JsonProperty("match_types")]
        string[] MatchTypes { get; set; }

        [JsonProperty("alternative_names")]
        string[] AlternativeNames { get; set; }

        [JsonProperty("assets")]
        ShuftiProAsset[] Assets { get; set; }

        [JsonProperty("associates")]
        ShuftiProAssociate[] Associates { get; set; }

        [JsonProperty("fields"), JsonConverter(typeof(ShuftiProEmptyArrayToObjectConverter))]
        Dictionary<string, ShuftiProField[]> Fields { get; set; }

        [JsonProperty("media")]
        ShuftiProMedia[] Media { get; set; }

        [JsonProperty("source_notes")]
        Dictionary<string, ShuftiProSourceNote> SourceNotes { get; set; }

        [JsonProperty("sources")]
        string[] Sources { get; set; }

        [JsonProperty("types")]
        ShuftiProAmlType[] Types { get; set; }
    }
}
