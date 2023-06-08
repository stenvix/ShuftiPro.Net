using ShuftiPro.Contracts.Abstractions;

namespace ShuftiPro.Contracts
{
    public class ShuftiProProofData : IShuftiProProofData
    {
        public ShuftiProProof Face { get; set; }

        public ShuftiProDocumentProof Document { get; set; }

        public ShuftiProAddressProof Address { get; set; }

        public ShuftiProProof Consent { get; set; }

        public string AccessToken { get; set; }
    }
}
