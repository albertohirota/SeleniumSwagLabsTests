using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SwagLabs.Page
{
    public class Shopping: CommonAction
    {
        public static readonly By ProductSelector = By.XPath("//select[@class='product_sort_container']");
        public static readonly By ItemNames = By.XPath("//div[@class='inventory_item_name']");
        public static readonly By ItemPrices = By.XPath("..//div[@class='inventory_item_price']");
        public static readonly By ItemDescription = By.XPath("..//div[@class='inventory_item_desc']");
        public static readonly By ItemButtonText = By.XPath("..//*[@class='btn btn_primary btn_small btn_inventory']");
        public static readonly By ItemRemoveButtonText = By.XPath("..//*[@class='btn btn_secondary btn_small btn_inventory']");

        public static IWebElement FindItem(string item) => FindElement
            (By.XPath("//div[@class='inventory_item_name'][contains(text(),'" + item+"')]"));

        public static By ItemPicture(string picture, string item) => By.XPath
            ("//img[@alt='" + item + "' and @src='" + picture + "']");

        /// <summary>
        /// Add string for the filter: az, za, lohi and hilo
        /// </summary>
        /// <param name="filter"></param>
        public static void Select_Filter(string filter)
        {
            SelectElement se = new(Driver.Instance!.FindElement(ProductSelector));
            se.SelectByValue(filter);
        }

        /// <summary>
        /// Get element of a specific item
        /// </summary>
        /// <param name="item">Need item name</param>
        /// <returns></returns>
        public static IWebElement GetElementOfItem(string item, By by)
        {
            var product = FindItem(item);
            IWebElement parent = product.FindElement(By.XPath("../.."));
            IWebElement itemPrice = parent.FindElement(by);
            return itemPrice;
        }

        /// <summary>
        /// Click Add on a specific item
        /// </summary>
        /// <param name="item">Need item name</param>
        /// <returns></returns>
        public static void ClickAddOnItem(string item)
        {
            var product = FindItem(item);
            IWebElement parent = product.FindElement(By.XPath("../.."));
            IWebElement itemToBeClicked = parent.FindElement(ItemButtonText);
            itemToBeClicked.Click();
        }
    }
}
