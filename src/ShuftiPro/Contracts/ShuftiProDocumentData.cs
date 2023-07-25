using System;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProDocumentData : IShuftiProDocumentData
    {
        public ShuftiProNameData Name { get; set; }

        public ShuftiProGenderType? Gender { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public int? Age { get; set; }

        public string DocumentNumber { get; set; }

        public string Country { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public ShuftiProDocumentType[] SelectedTypes { get; set; }

        public ShuftiProDocumentType[] SupportedTypes { get; set; }
    }
}
