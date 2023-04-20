using OpenQA.Selenium;

namespace SwagLabs.Page
{
    public class Order:CommonAction
    {
        public static readonly By FirstName = By.XPath("//input[@id='first-name']");
        public static readonly By LastName = By.XPath("//input[@id='last-name']");
        public static readonly By ZipCode = By.XPath("//input[@id='postal-code']");
        public static readonly By ButtonContinue = By.XPath("//input[@type='submit']");
        public static readonly By ButtonFinish = By.XPath("//button[@id='finish']");
        public static readonly By SuccessIcon = By.XPath("//img[@class='pony_express']");
        public static readonly By SummaryTotal = By.XPath("//div[@class='summary_info_label summary_total_label']");

        public static By ElementByText(string item) => By.XPath
            ("//div[contains(text(),'" + item + "')]");
    }
}
