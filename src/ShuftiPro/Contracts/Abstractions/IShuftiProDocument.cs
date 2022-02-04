using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProDocument : IShuftiProDocumentProof, IShuftiProDocumentBase
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProName Name { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("fetch_enhanced_data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        bool? FetchEnhancedData { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("backside_proof_required", NullValueHandling = NullValueHandling.Ignore)]
        string BacksideProofRequired { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOffline { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_online", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOnline { get; set; }

        [JsonProperty("verification_instructions", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProVerificationInstruction Instruction { get; set; }
    }
}