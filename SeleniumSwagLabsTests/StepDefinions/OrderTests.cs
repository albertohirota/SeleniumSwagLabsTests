using AventStack.ExtentReports.Gherkin.Model;
using SwagLabs;
using SwagLabs.Page;

namespace SeleniumSwagLabsTests.StepDefinions
{
    [Binding]
    public sealed class OrderTests
    {
        [Then(@"ValidateSucessOrderIcon")]
        public void ThenValidateSucessOrderIcon()
        {
            var exists= CommonAction.DoesElementExist(Order.SuccessIcon);
            Assert.IsTrue(exists);
        }

        [When(@"Click checkout")]
        public void WhenClickCheckout()
        {
            CommonAction.Click(Cart.ButtonCheckout);
        }

        [When(@"Fillup user fields")]
        public void WhenFillupUserFields()
        {
            CommonAction.SendKey(Order.FirstName, "Alberto");
            CommonAction.SendKey(Order.LastName, "Hirota");
            CommonAction.SendKey(Order.ZipCode, "12345");
        }

        [When(@"Click Continue")]
        public void WhenClickContinue()
        {
            CommonAction.Click(Order.ButtonContinue);
        }

        [When(@"Click Finish Order")]
        public void WhenClickFinishOrder()
        {
            CommonAction.Click(Order.ButtonFinish);
        }

        [Then(@"Total Price should be '([^']*)'")]
        public void ThenTotalPriceShouldBe(string expectedPrice)
        {
            var itemDescription = CommonAction.FindElement(Order.SummaryTotal).Text;
            StringAssert.Contains(expectedPrice, itemDescription);
        }

        [Then(@"Shipping Information should be '([^']*)'")]
        public void ThenShippingInformationShouldBe(string shippingInfo)
        {
            var exists = CommonAction.DoesElementExist(Order.ElementByText(shippingInfo));
            Assert.IsTrue(exists);
        }

        [Then(@"Payment Information should be '([^']*)'")]
        public void ThenPaymentInformationShouldBe(string paymentInfo)
        {
            var exists = CommonAction.DoesElementExist(Order.ElementByText(paymentInfo));
            Assert.IsTrue(exists);
        }

    }
}
