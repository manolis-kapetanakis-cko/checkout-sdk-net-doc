using System.Threading.Tasks;
using Checkout.Payments;
using Shouldly;
using Xunit;

namespace Checkout.Tests.Payments
{
    public class CardVerificationTests : ApiTestFixture
    {
        [Fact]
        public async Task CanVerifyCard()
        {
            var paymentRequest = TestHelper.CreateCardPaymentRequest(amount: null);
            var paymentResponse = await Api.Payments.RequestAsync(paymentRequest);

            paymentResponse.Payment.Status.ShouldBe(PaymentStatus.CardVerified);
        }
    }
}