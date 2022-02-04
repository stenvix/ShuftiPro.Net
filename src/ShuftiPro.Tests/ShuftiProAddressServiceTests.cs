using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;
using ShuftiPro.Contracts;
using ShuftiPro.Enums;

namespace ShuftiPro.Tests
{
    public class ShuftiProAddressServiceTests : ShuftiProTestBase
    {
        [Test]
        public async Task VerifyOnSiteWithOcr_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Reference,
                Address = new ShuftiProAddress
                {
                    SupportedTypes = new[]
                    {
                       ShuftiProAddressType.IdCard,
                       ShuftiProAddressType.BankStatement,
                       ShuftiProAddressType.DrivingLicense,
                       ShuftiProAddressType.EmployerLetter,
                       ShuftiProAddressType.InsuranceAgreement,
                       ShuftiProAddressType.Passport,
                       ShuftiProAddressType.RentAgreement,
                       ShuftiProAddressType.TaxBill,
                       ShuftiProAddressType.UtilityBill
                    },
                    AddressFuzzyMatch = true,
                    BacksideProofRequired = "0"
                }
            };

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeNull();
            feedback.Event.Should().NotBeNull().And.BeEquivalentTo(ShuftiProEvent.RequestPending);
            feedback.VerificationUrl.Should().NotBeNull();
        }

        [Test]
        public async Task VerifyOnSiteWithoutOcr_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Reference,
                Address = new ShuftiProAddress
                {
                    Name = new ShuftiProName
                    {
                        FirstName = "John",
                        LastName = "Livone"
                    },
                    FullAddress = "10 DOWNING ST, WESTMINSTER, LONDON SW1A 2AA, UK",
                    SupportedTypes = new[]
                    {
                        ShuftiProAddressType.IdCard,
                        ShuftiProAddressType.BankStatement,
                        ShuftiProAddressType.DrivingLicense,
                        ShuftiProAddressType.EmployerLetter,
                        ShuftiProAddressType.InsuranceAgreement,
                        ShuftiProAddressType.Passport,
                        ShuftiProAddressType.RentAgreement,
                        ShuftiProAddressType.TaxBill,
                        ShuftiProAddressType.UtilityBill
                    },
                    AddressFuzzyMatch = true,
                    BacksideProofRequired = "0"
                }
            };

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeNull();
            feedback.Event.Should().NotBeNull().And.BeEquivalentTo(ShuftiProEvent.RequestPending);
            feedback.VerificationUrl.Should().NotBeNull();
        }

        [Test]
        public async Task VerifyOffSiteWithOcr_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Reference,
                Address = new ShuftiProAddress
                {
                    Proof = await this.GetBase64Image(TestConstants.Images.RealId),
                    SupportedTypes = new[]
                    {
                        ShuftiProAddressType.IdCard,
                        ShuftiProAddressType.BankStatement,
                        ShuftiProAddressType.DrivingLicense,
                        ShuftiProAddressType.EmployerLetter,
                        ShuftiProAddressType.InsuranceAgreement,
                        ShuftiProAddressType.Passport,
                        ShuftiProAddressType.RentAgreement,
                        ShuftiProAddressType.TaxBill,
                        ShuftiProAddressType.UtilityBill
                    },
                    AddressFuzzyMatch = true,
                    BacksideProofRequired = "0"
                }
            };

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeNull();
            feedback.Event.Should().NotBeNull().And.BeEquivalentTo(ShuftiProEvent.VerificationAccepted);
            feedback.Data.Should().NotBeNull();
            feedback.Data.Address.Should().NotBeNull();
            feedback.Data.Address.FullAddress.Should().NotBeEmpty();
        }

        [Test]
        public async Task VerifyOffSiteWithoutOcr_ValidVerification_ReturnsFeedback()
        {
            var verification = new ShuftiProVerification
            {
                CallbackUrl = CallbackUrl,
                Reference = Reference,
                Address = new ShuftiProAddress
                {
                    Proof = await this.GetBase64Image(TestConstants.Images.RealId),
                    Name = new ShuftiProName
                    {
                        FirstName = "John",
                        LastName = "Livone"
                    },
                    FullAddress = "10 DOWNING ST, WESTMINSTER, LONDON SW1A 2AA, UK",
                    SupportedTypes = new[]
                    {
                        ShuftiProAddressType.IdCard,
                        ShuftiProAddressType.BankStatement,
                        ShuftiProAddressType.DrivingLicense,
                        ShuftiProAddressType.EmployerLetter,
                        ShuftiProAddressType.InsuranceAgreement,
                        ShuftiProAddressType.Passport,
                        ShuftiProAddressType.RentAgreement,
                        ShuftiProAddressType.TaxBill,
                        ShuftiProAddressType.UtilityBill
                    },
                    AddressFuzzyMatch = true,
                    BacksideProofRequired = "0"
                }
            };

            var feedback = await this.ShuftiPro.VerifyAsync(verification);
            feedback.Should().NotBeNull();
            feedback.Reference.Should().NotBeNull();
            feedback.Event.Should().NotBeNull().And.BeEquivalentTo(ShuftiProEvent.VerificationAccepted);
            feedback.Data.Should().NotBeNull();
            feedback.Data.Address.Should().NotBeNull();
            feedback.Data.Address.FullAddress.Should().NotBeEmpty();
        }
    }
}
