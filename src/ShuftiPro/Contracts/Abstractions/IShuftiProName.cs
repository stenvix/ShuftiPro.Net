﻿using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProName : IShuftiProNameBase
    {
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        string FullName { get; set; }

        [JsonProperty("fuzzy_match", DefaultValueHandling = DefaultValueHandling.Ignore)]
        bool FuzzyMatch { get; set; }
    }
}
