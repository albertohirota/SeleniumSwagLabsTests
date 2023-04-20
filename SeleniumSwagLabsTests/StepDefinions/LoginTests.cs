using SwagLabs;
using SwagLabs.Page;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace SeleniumSwagLabsTests.StepDefinions
{
    [Binding]
    public sealed class LoginTests:Login
    {
        [Given(@"Enter user '([^']*)' and password")]
        public void GivenEnterUserAndPassword(string userName)
        {
            CommonAction.SendKey(Login.UserName,userName);
            CommonAction.SendKey(Login.Password, Login.pw);
        }


        [When(@"click button Login")]
        public void WhenClickButtonLogin()
        {
            CommonAction.Click(Login.ButtonLogin);
        }

        [Then(@"user should be logged")]
        public void ThenUserShouldBeLogged()
        {
            Assert.True(CommonAction.DoesElementExist(Login.UserGood));
        }

        [Then(@"user locked error")]
        public void ThenUserLockedError()
        {
            Assert.True(CommonAction.DoesElementExist(Login.UserLocked));
        }

        [Then(@"user problem error")]
        public void ThenUserProblemError()
        {
            Assert.True(CommonAction.DoesElementExist(Login.UserProblem));
        }

        [Then(@"valid logo")]
        public void ThenValidLogo()
        {
            Assert.True(CommonAction.DoesElementExist(Login.SwagLogo));
        }

        [When(@"click logout")]
        public void WhenClickLogout()
        {
            CommonAction.Click(Login.PageMenu);
            CommonAction.Click(Login.LogoutMenuButton);
        }

        [Then(@"user should be not logged")]
        public void ThenUserShouldBeNotLogged()
        {
            Assert.True(CommonAction.WaitElementBePresent(Login.ButtonLogin));
        }

        [Given(@"Enter password with '([^']*)'")]
        public void GivenEnterPasswordWith(string userNames)
        {
            CommonAction.SendKey(Login.UserName, userNames);
            CommonAction.SendKey(Login.Password, Login.pw);
        }

        [When(@"And StartTimer")]
        public void WhenAndStartTimer()
        {
            
        }

        [When(@"user performance login page should be less than (.*) seconds")]
        public void WhenUserPerformanceLoginPageShouldBeLessThanSeconds(int expected)
        {
            DateTime clickTime = DateTime.Now;
            CommonAction.Click(Login.ButtonLogin);
            WaitElementBePresent(Login.UserGood, 20);
            DateTime pageLoadTime = DateTime.Now;
            int intResult = pageLoadTime.Second - clickTime.Second;
            Assert.Less(intResult, expected);
        }


    }
}
