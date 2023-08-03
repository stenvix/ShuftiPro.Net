using System;
using System.ComponentModel.DataAnnotations;
using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProDocument : IShuftiProDocument
    {
        public string Proof { get; set; }

        public string AdditionalProof { get; set; }

        public ShuftiProName Name { get; set; }

        public ShuftiProGenderType? Gender { get; set; }

        public DateTime? DayOfBirth { get; set; }

        public int? Age { get; set; }

        public string DocumentNumber { get; set; }

        public DateTime? IssueDate { get; set; }

        public DateTime? ExpiryDate { get; set; }

        [Required]
        public ShuftiProDocumentType[] SupportedTypes { get; set; }

        public bool? FetchEnhancedData { get; set; }

        public bool? BacksideProofRequired { get; set; }

        public bool? AllowOffline { get; set; }

        public bool? AllowOnline { get; set; }

        public bool? ShowOcrForm { get; set; }

        public ShuftiProVerificationInstruction Instruction { get; set; }
    }
}
