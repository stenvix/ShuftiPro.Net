using System;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProAddressData : IShuftiProAddressData
    {
        public ShuftiProNameData Name { get; set; }

        public string FullAddress { get; set; }

        public string TaxIdentityNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        public ShuftiProAddressType[] SelectedTypes { get; set; }

        public ShuftiProAddressType[] SupportedTypes { get; set; }
    }
}
