using System.IO;
using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProProofFileData : IShuftiProProofFileData
    {
        public Stream Proof { get; set; }

        public string ContentType { get; set; }
    }
}
