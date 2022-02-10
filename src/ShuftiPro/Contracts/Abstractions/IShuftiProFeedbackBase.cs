using Newtonsoft.Json;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProFeedbackBase : IShuftiProReference
    {
        [JsonProperty("event")]
        ShuftiProEvent Event { get; set; }

        [JsonProperty("country")]
        string Country { get; set; }

        [JsonProperty("declined_reason", NullValueHandling = NullValueHandling.Ignore)]
        string DeclinedReason { get; set; }

        [JsonProperty("declined_codes", NullValueHandling = NullValueHandling.Ignore)]
        string[] DeclinedCodes { get; set; }

        [JsonProperty("services_declined_codes", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProServiceDeclinedCodes ServiceDeclinedCodes { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProFeedbackError Error { get; set; }

        [JsonProperty("verification_result", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProFeedbackResult Result { get; set; }

        [JsonProperty("verification_data", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProFeedbackData Data { get; set; }

        [JsonProperty("info", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProUserInfo Info { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProAddress Address { get; set; }
    }
}
