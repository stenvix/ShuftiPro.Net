using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShuftiProAddressType
    {
        [EnumMember(Value = "")]
        Undefined,

        [EnumMember(Value = "id_card")]
        IdCard,

        [EnumMember(Value = "passport")]
        Passport,

        [EnumMember(Value = "driving_license")]
        DrivingLicense,

        [EnumMember(Value = "utility_bill")]
        UtilityBill,

        [EnumMember(Value = "bank_statement")]
        BankStatement,

        [EnumMember(Value = "rent_agreement")]
        RentAgreement,

        [EnumMember(Value = "employer_letter")]
        EmployerLetter,

        [EnumMember(Value = "insurance_agreement")]
        InsuranceAgreement,

        [EnumMember(Value = "tax_bill")]
        TaxBill,

        [EnumMember(Value = "envelope")]
        Envelope,

        [EnumMember(Value = "cpr_smart_card_reader_copy")]
        CprSmartCardReaderCopy,
        
        [EnumMember(Value = "property_tax")]
        PropertyTax,
                
        [EnumMember(Value = "lease_agreement")]
        LeaseAgreement,
                
        [EnumMember(Value = "insurance_card")]
        InsuranceCard,
                
        [EnumMember(Value = "permanent_residence_permit")]
        PermanentResidencePermit,
                
        [EnumMember(Value = "credit_card_statement")]
        CreditCardStatement,
                
        [EnumMember(Value = "insurance_policy")]
        InsurancePolicy,
                
        [EnumMember(Value = "e_commerce_receipt")]
        ECommerceReceipt,
                
        [EnumMember(Value = "bank_letter_receipt")]
        BankLetterReceipt,
                
        [EnumMember(Value = "birth_certificate")]
        BirthCertificate,
                
        [EnumMember(Value = "salary_slip")]
        SalarySlip,
                
        [EnumMember(Value = "any")]
        Any,
    }
}
