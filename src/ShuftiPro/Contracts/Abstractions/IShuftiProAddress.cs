using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProAddress : IShuftiProAddressBase, IShuftiProProof
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProName Name { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("address_fuzzy_match", NullValueHandling = NullValueHandling.Ignore)]
        bool? AddressFuzzyMatch { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("backside_proof_required", NullValueHandling = NullValueHandling.Ignore)]
        bool? BacksideProofRequired { get; set; }

        [JsonConverter(typeof(ShuftiProBoolToIntConverter))]
        [JsonProperty("allow_offline", NullValueHandling = NullValueHandling.Ignore)]
        bool? AllowOffline { get; set; }

        [JsonProperty("verification_instructions", NullValueHandling = NullValueHandling.Ignore)]
        ShuftiProVerificationInstruction Instruction { get; set; }
    }
}
