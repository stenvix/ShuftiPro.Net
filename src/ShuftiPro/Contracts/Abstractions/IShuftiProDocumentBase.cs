using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using ShuftiPro.Converters;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    internal interface IShuftiProDocumentBase
    {
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProGenderType? Gender { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? DayOfBirth { get; set; }

        [JsonProperty("age", NullValueHandling = NullValueHandling.Ignore)]
        int? Age { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [JsonProperty("document_number", NullValueHandling = NullValueHandling.Ignore)]
        string DocumentNumber { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        string Country { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("issue_date", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? IssueDate { get; set; }

        [JsonConverter(typeof(ShuftiProDateTimeConverter))]
        [JsonProperty("expiry_date", NullValueHandling = NullValueHandling.Ignore)]
        DateTime? ExpiryDate { get; set; }

        [JsonProperty("supported_types", Required = Required.Always)]
        ShuftiProDocumentType[] SupportedTypes { get; set; }
    }
}