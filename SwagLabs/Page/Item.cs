using OpenQA.Selenium;

namespace SwagLabs.Page
{
    public class Item :CommonAction
    {
        public static readonly By ProductName = By.XPath("//div[@class='inventory_details_name large_size']");
        public static readonly By ProducDescription = By.XPath("//div[@class='inventory_details_desc large_size']");
        public static readonly By ProducPrice = By.XPath("//div[@class='inventory_details_price']");
        public static readonly By ButtonAdd = By.XPath("//button[@class='btn btn_primary btn_small btn_inventory']");
        public static readonly By ButtonRemove = By.XPath("//button[@class='btn btn_secondary btn_small btn_inventory']");

        public static By ProductItem(string item) => By.XPath
            ("//div[@class='inventory_item_name'][contains(text(),'"+item+"')]");
    }
}
