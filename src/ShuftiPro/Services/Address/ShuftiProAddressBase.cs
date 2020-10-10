﻿using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Services
{
    public class ShuftiProAddressBase
    {
        [Required]
        [JsonProperty("supported_types", Required = Required.Always)]
        public ShuftiProAddressType[] SupportedTypes { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public ShuftiProName Name { get; set; }

        [JsonProperty("full_address", NullValueHandling = NullValueHandling.Ignore)]
        [StringLength(250, MinimumLength = 2)]
        public string FullAddress { get; set; }
    }
}