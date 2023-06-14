    using System.IO;
using Newtonsoft.Json;

namespace ShuftiPro.Contracts.Abstractions
{
    interface IShuftiProProofFileData
    {
        [JsonIgnore]
        Stream Proof { get; set; }

        [JsonIgnore]
        string ContentType { get; set; }
    }
}
