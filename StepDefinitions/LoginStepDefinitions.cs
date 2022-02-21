using BigHealth.Config;
using BigHealth.Helper;
using BigHealth.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace BigHealth.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions:Base
    {
        [When(@"Users Clicks on the Login Button")]
        public void WhenUsersClicksOnTheLoginButton()
        {
            GetDriverByClass(LoginPage.Login).Click();  
        }

        [Then(@"Enter exisitng user email address")]
        public void ThenEnterExisitngUserEmailAddress()
        {
            GetDriverByID(LoginPage.Email).SendKeys(UserSignInDetails.Email);
        }

        [Then(@"Enter exisiting password")]
        public void ThenEnterExisitingPassword()
        {
            GetDriverByID(LoginPage.Password).SendKeys(UserSignInDetails.Password);
        }

        [Then(@"Click on Login button")]
        public void ThenClickOnLoginButton()
        {
            GetDriverByXpath(LoginPage.ContinueButton).Click();
        }

        [Then(@"Enter wrong  password")]
        public void ThenEnterWrongPassword()
        {
            GetDriverByID(LoginPage.Password).SendKeys("ajdgsajkgfcksja");
        }

        [Then(@"validate error message in login screen")]
        public void ThenValidateErrorMessageInLoginScreen()
        {
            Assert.AreEqual(UserSignInDetails.ErrorMessage, GetDriverByXpath(LoginPage.LoginError).Text);
        }

        [Then(@"Enter exisitng user non exisiting email address")]
        public void ThenEnterExisitngUserNonExisitingEmailAddress()
        {
            GetDriverByID(LoginPage.Email).SendKeys(UserSignInDetails.NonExisitingEmail);
        }




    }
}
