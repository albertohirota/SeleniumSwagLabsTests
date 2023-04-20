using SwagLabs;
using SwagLabs.Page;

namespace SeleniumSwagLabsTests.StepDefinions
{
    [Binding]
    public sealed class CartTests
    {
        [Then(@"Cart Icon Show (.*)")]
        public void ThenCartIconShow(int items)
        {
            var itemsFound = CommonAction.GetTextOfElement(Cart.CartIcon);
            Assert.That(itemsFound, Is.EqualTo(items.ToString()));
        }

        [When(@"Click Shopping Cart")]
        public void WhenClickShoppingCart()
        {
            CommonAction.Click(Cart.CartIcon);
        }

        [When(@"Remove item '([^']*)'")]
        public void WhenRemoveItem(string item)
        {
            var element = Shopping.GetElementOfItem(item, Cart.ButtonRemoveOfItem);
            element.Click();
        }

        [Then(@"Cart show price '([^']*)' of item '([^']*)'")]
        public void ThenCartShowPriceOfItem(string expectedPrice, string item)
        {
            var itemPrice = Shopping.GetElementOfItem(item, Cart.ItemPrice).Text;
            Assert.That(itemPrice, Is.EqualTo(expectedPrice));
        }

        [Then(@"Cart show description '([^']*)' of item '([^']*)'")]
        public void ThenCartShowDescriptionOfItem(string expectedDescription, string item)
        {
            var itemDescription = Shopping.GetElementOfItem(item, Cart.ItemDescription).Text;
            StringAssert.Contains(expectedDescription, itemDescription);
        }

        [Then(@"The button back text is '([^']*)'")]
        public void ThenTheButtonBackTextIs(string expectedDescription)
        {
            var itemDescription = CommonAction.FindElement(Cart.ButtonBack).Text;
            StringAssert.Contains(expectedDescription, itemDescription);
        }

        [Then(@"The button checkout text is '([^']*)'")]
        public void ThenTheButtonCheckoutTextIs(string expectedDescription)
        {
            var itemDescription = CommonAction.FindElement(Cart.ButtonCheckout).Text;
            StringAssert.Contains(expectedDescription, itemDescription);
        }

    }
}
