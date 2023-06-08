using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProProofData : IShuftiProProofAccess
    {
        [JsonProperty("face")]
        ShuftiProProof Face { get; set; }

        [JsonProperty("document")]
        ShuftiProDocumentProof Document { get; set; }

        [JsonProperty("address")]
        ShuftiProAddressProof Address { get; set; }

        [JsonProperty("consent")]
        ShuftiProProof Consent { get; set; }
    }
}
