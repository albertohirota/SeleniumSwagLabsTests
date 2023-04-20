using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SwagLabs.Page
{
    public class Cart: CommonAction
    {
        public static readonly By CartIcon = By.XPath("//span[@class='shopping_cart_badge']");
        public static readonly By ButtonRemoveOfItem = By.XPath("//button[@class='btn btn_secondary btn_small cart_button']");
        public static readonly By ItemDescription = By.XPath("//div[@class='inventory_item_name']");
        public static readonly By ItemPrice = By.XPath("//div[@class='inventory_item_price']");
        public static readonly By ButtonBack = By.XPath("//button[@class='btn btn_secondary back btn_medium']");
        public static readonly By ButtonCheckout = By.XPath("//button[@class='btn btn_action btn_medium checkout_button']");
    }
}
