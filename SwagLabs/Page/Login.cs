using OpenQA.Selenium;

namespace SwagLabs.Page
{
    public class Login: CommonAction
    {
        public static readonly string pw = "secret_sauce";
        public static readonly By UserName = By.Id("user-name");
        public static readonly By Password = By.Id("password");
        public static readonly By ButtonLogin = By.XPath("//input[@id='login-button']");
        public static readonly By SwagLogo = By.XPath("//div[@class='login_logo'][contains(text(),'Swag Labs')]"); 
        public static readonly By UserLocked = By.XPath("//*[contains(text(),'Sorry, this user has been locked out')]");
        public static readonly By UserProblem = By.XPath("//img[@src='/static/media/sl-404.168b1cce.jpg']");
        public static readonly By UserGood = By.XPath("//img[@src='/static/media/sauce-backpack-1200x1500.0a0b85a3.jpg']");
        public static readonly By ShoppingCart = By.XPath("//div[@id='shopping_cart_container']");
        public static readonly By PageMenu = By.XPath("//button[@id='react-burger-menu-btn']");
        public static readonly By LogoutMenuButton = By.XPath("//*[@id='logout_sidebar_link']");
        public static readonly By ResetAppStateMenu = By.XPath("//*[contains(text(),'Reset App State')]");

        /// <summary>
        /// Method to Reset App State
        /// </summary>
        public static void ResetAppState()
        {
            CommonAction.SendKey(Login.UserName, "standard_user");
            CommonAction.SendKey(Login.Password, Login.pw);
            CommonAction.Click(Login.ButtonLogin);
            CommonAction.Click(Login.PageMenu);
            CommonAction.Click(Login.ResetAppStateMenu);
        }
    }
}
