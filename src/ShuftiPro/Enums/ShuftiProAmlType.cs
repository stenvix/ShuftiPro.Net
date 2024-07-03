using System.Runtime.Serialization;
using Newtonsoft.Json;
using ShuftiPro.Converters;

namespace ShuftiPro.Enums
{
    [JsonConverter(typeof(ShuftiProSafeStringEnumConverter<ShuftiProAmlType>))]
    public enum ShuftiProAmlType
    {
        None,

        [EnumMember(Value = "warning")]
        Warning,

        [EnumMember(Value = "sanction")]
        Sanction,

        [EnumMember(Value = "pep")]
        Pep,

        [EnumMember(Value = "pep-class-1")]
        PepClass1,

        [EnumMember(Value = "pep-class-2")]
        PepClass2,

        [EnumMember(Value = "pep-class-3")]
        PepClass3,

        [EnumMember(Value = "pep-class-4")]
        PepClass4,

        [EnumMember(Value = "adverse-media")]
        AdverseMedia,

        [EnumMember(Value = "adverse-media-financial-crime")]
        AdverseMediaFinancialCrime,

        [EnumMember(Value = "adverse-media-fraud")]
        AdverseMediaFraud,

        [EnumMember(Value = "adverse-media-general")]
        AdverseMediaGeneral,

        [EnumMember(Value = "adverse-media-narcotics")]
        AdverseMediaNarcotics,

        [EnumMember(Value = "adverse-media-sexual-crime")]
        AdverseMediaSexualCrime,

        [EnumMember(Value = "adverse-media-terrorism")]
        AdverseMediaTerrorism,

        [EnumMember(Value = "adverse-media-violent-crime")]
        AdverseMediaViolentCrime,

        [EnumMember(Value = "fitness-probity")]
        FitnessProbity,

        [EnumMember(Value = "adverse-media-v2-property")]
        AdverseMediaV2Property,

        [EnumMember(Value = "adverse-media-v2-financial-aml-cft")]
        AdverseMediaV2FinancialAmlCft,

        [EnumMember(Value = "adverse-media-v2-fraud-linked")]
        AdverseMediaV2FraudLinked,

        [EnumMember(Value = "adverse-media-v2-narcotics-aml-cft")]
        AdverseMediaV2NarcoticsAmlCft,

        [EnumMember(Value = "adverse-media-v2-violence-aml-cft")]
        AdverseMediaV2ViolenceAmlCft,

        [EnumMember(Value = "adverse-media-v2-terrorism")]
        AdverseMediaV2Terrorism,

        [EnumMember(Value = "adverse-media-v2-cybercrime")]
        AdverseMediaV2Cybercrime,

        [EnumMember(Value = "adverse-media-v2-general-aml-cft")]
        AdverseMediaV2GeneralAmlCft,

        [EnumMember(Value = "adverse-media-v2-regulatory")]
        AdverseMediaV2Regulatory,

        [EnumMember(Value = "adverse-media-v2-financial-difficulty")]
        AdverseMediaV2FinancialDifficulty,

        [EnumMember(Value = "adverse-media-v2-violence-non-aml-cft")]
        AdverseMediaV2ViolenceNonAmlCft,

        [EnumMember(Value = "adverse-media-v2-other-financial")]
        AdverseMediaV2OtherFinancial,

        [EnumMember(Value = "adverse-media-v2-other-serious")]
        AdverseMediaV2OtherSerious,

        [EnumMember(Value = "adverse-media-v2-other-minor")]
        AdverseMediaV2OtherMinor,

        [EnumMember(Value = "SIP")]
        SIP,

        [EnumMember(Value = "SIE")]
        SIE,

        [EnumMember(Value = "RCA")]
        RCA,

        [EnumMember(Value = "Businessperson")]
        Businessperson,

        [EnumMember(Value = "Notice")]
        Notice,
    }
}
