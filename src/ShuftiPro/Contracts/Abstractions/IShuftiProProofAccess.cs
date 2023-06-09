using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProProofAccess
    {
        [JsonProperty("access_token")]
        string AccessToken { get; set; }
    }
}
