using SwagLabs;
using SwagLabs.Page;

namespace SeleniumSwagLabsTests.StepDefinions
{
    [Binding]
    public sealed class ShoppingTests
    {
        [Given(@"Logged with user '([^']*)'")]
        public void GivenLoggedWithUser(string userName)
        {
            CommonAction.SendKey(Login.UserName, userName);
            CommonAction.SendKey(Login.Password, Login.pw);
            CommonAction.Click(Login.ButtonLogin);
        }

        [When(@"Select filter '([^']*)'")]
        public void WhenSelectFilter(string filter)
        {
            CommonAction.Click(Shopping.ProductSelector);
            Shopping.Select_Filter(filter);
        }

        [Then(@"products should be in descendant name")]
        public void ThenProductsShouldBeInDescendantName()
        {
            var elements = CommonAction.FindElements(Shopping.ItemNames);
            string firstElement= elements[0].Text;
            string lastElement= elements[elements.Count - 1].Text;
            Assert.That(firstElement, Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
            Assert.That(lastElement, Is.EqualTo("Sauce Labs Backpack"));
        }

        [Then(@"products should be in ascendant name")]
        public void ThenProductsShouldBeInAscendantName()
        {
            var elements = CommonAction.FindElements(Shopping.ItemNames);
            string firstElement = elements[0].Text;
            string lastElement = elements[elements.Count - 1].Text;
            Assert.That(firstElement, Is.EqualTo("Sauce Labs Backpack"));
            Assert.That(lastElement, Is.EqualTo("Test.allTheThings() T-Shirt (Red)"));
        }

        [Then(@"products should be in ascendant price")]
        public void ThenProductsShouldBeInAscendantPrice()
        {
            var elements = CommonAction.FindElements(Shopping.ItemNames);
            int count = elements.Count;
            string firstElement = elements[0].Text;
            string lastElement = elements[elements.Count - 1].Text;
            Assert.That(firstElement, Is.EqualTo("Sauce Labs Onesie"));
            Assert.That(lastElement, Is.EqualTo("Sauce Labs Fleece Jacket"));
        }

        [Then(@"products should be in descendant price")]
        public void ThenProductsShouldBeInDescendantPrice()
        {
            var elements = CommonAction.FindElements(Shopping.ItemNames);
            int count = elements.Count;
            string firstElement = elements[0].Text;
            string lastElement = elements[elements.Count - 1].Text;
            Assert.That(firstElement, Is.EqualTo("Sauce Labs Fleece Jacket"));
            Assert.That(lastElement, Is.EqualTo("Sauce Labs Onesie"));
        }

        [Then(@"price '([^']*)' of product '([^']*)'")]
        public void ThenPriceOfProduct(string expectedPrice, string item)
        {
            var itemPrice = Shopping.GetElementOfItem(item, Shopping.ItemPrices).Text;
            Assert.That(itemPrice, Is.EqualTo(expectedPrice));
        }

        [Then(@"part of text '([^']*)' of product '([^']*)'")]
        public void ThenPartOfTextOfProduct(string expectedDescription, string item)
        {
            var itemDescription = Shopping.GetElementOfItem(item, Shopping.ItemDescription).Text;
            StringAssert.Contains(expectedDescription, itemDescription);
        }

        [Then(@"Button text '([^']*)' of product '([^']*)'")]
        public void ThenButtonTextOfProduct(string buttonText, string item)
        {
            var itemButtonText = Shopping.GetElementOfItem(item, Shopping.ItemButtonText).Text; 
            Assert.That(itemButtonText, Is.EqualTo(buttonText));
        }

        [When(@"Click Add to cart button of product '([^']*)'")]
        public void WhenClickAddToCartButtonOfProduct(string item)
        {
            Shopping.ClickAddOnItem(item);
        }

        [Then(@"Remove Button text '([^']*)' of product '([^']*)'")]
        public void ThenRemoveButtonTextOfProduct(string removeButtonText, string item)
        {
            var itemButtonText = Shopping.GetElementOfItem(item, Shopping.ItemRemoveButtonText).Text; 
            Assert.That(itemButtonText, Is.EqualTo(removeButtonText));
        }

        [Then(@"Picture '([^']*)' of '([^']*)'")]
        public void ThenPictureOf(string image, string item)
        {
            bool exist = CommonAction.WaitElementBePresent(Shopping.ItemPicture(image, item));
            Assert.That(exist, Is.True);
        }
    }
}
