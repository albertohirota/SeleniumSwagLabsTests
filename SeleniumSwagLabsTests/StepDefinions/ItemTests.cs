using SwagLabs;
using SwagLabs.Page;

namespace SeleniumSwagLabsTests.StepDefinions
{
    [Binding]
    public sealed class ItemTests
    {
        [When(@"Click product '([^']*)'")]
        public void WhenClickProduct(string item)
        {
            CommonAction.Click(Item.ProductItem(item));
        }

        [Then(@"product expected '([^']*)'")]
        public void ThenProductExpected(string item)
        {
            var elementName = CommonAction.GetTextOfElement(Item.ProductName);
            Assert.That(elementName, Is.EqualTo(item));
        }

        [Then(@"price expected '([^']*)'")]
        public void ThenPriceExpected(string price)
        {
            var elementName = CommonAction.GetTextOfElement(Item.ProducPrice);
            Assert.That(elementName, Is.EqualTo(price));
        }

        [Then(@"description expected '([^']*)'")]
        public void ThenDescriptionExpected(string description)
        {
            var elementName = CommonAction.GetTextOfElement(Item.ProducDescription);
            StringAssert.Contains(description, elementName);
        }

        [When(@"Click Add Button in Items Details")]
        public void WhenClickAddButtonInItemsDetails()
        {
            CommonAction.Click(Item.ButtonAdd);
        }

        [Then(@"Button description '([^']*)'")]
        public void ThenButtonDescription(string removeButton)
        {
            var elementName = CommonAction.GetTextOfElement(Item.ButtonRemove);
            Assert.That(elementName, Is.EqualTo(removeButton));
        }

    }
}
