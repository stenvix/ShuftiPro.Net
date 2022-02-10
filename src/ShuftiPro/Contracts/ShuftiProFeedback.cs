using ShuftiPro.Contracts.Abstractions;
using ShuftiPro.Enums;

namespace ShuftiPro.Contracts
{
    public class ShuftiProFeedback : IShuftiProFeedback
    {
        public string Reference { get; set; }

        public ShuftiProEvent Event { get; set; }

        public string Email { get; set; }

        public string Country { get; set; }

        public string VerificationUrl { get; set; }

        public string DeclinedReason { get; set; }

        public string[] DeclinedCodes { get; set; }

        public ShuftiProServiceDeclinedCodes ServiceDeclinedCodes { get; set; }

        public ShuftiProFeedbackError Error { get; set; }

        public ShuftiProFeedbackResult Result { get; set; }

        public ShuftiProFeedbackData Data { get; set; }

        public ShuftiProUserInfo Info { get; set; }

        public ShuftiProAddress Address { get; set; }
    }
}
