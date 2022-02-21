using BigHealth.Config;
using BigHealth.Helper;
using BigHealth.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Sleepio.BigHealth.StepDefinitions
{
    [Binding]
    public class SleepScoreSignupStepDefinitions : Base
    {
        [Given(@"Users were able to enter the url in the browser")]
        public void GivenUsersWereAbleToEnterTheUrlInTheBrowser()
        {

        }

        [When(@"System loads the home page")]
        public void WhenSystemLoadsTheHomePage()
        {
            Assert.IsTrue(GetDriverByClass(HomePageObjectIdentifiers.loginButton).Enabled);
        }

        [Then(@"validate users were able to see login and getstarted buttons")]
        public void ThenValidateUsersWereAbleToSeeLoginAndGetstartedButtons()
        {
            Assert.IsTrue(GetDriverByXpath(HomePageObjectIdentifiers.getStartedButton).Enabled);
        }

        [Then(@"Validate Content on the Home Page")]
        public void ThenValidateContentOnTheHomePage()
        {
            Assert.AreEqual(Constant.HomePageContent, GetDriverByXpath(HomePageObjectIdentifiers.homepageContent).Text);
        }

        [Then(@"validate users were able to Click on Get started Button")]
        public void ThenValidateUsersWereAbleToClickOnGetStartedButton()
        {
            GetDriverByXpath(HomePageObjectIdentifiers.getStartedButton).Click();
        }

        [Then(@"validate Content in the Second screen")]
        public void ThenValidateContentInTheSecondScreen()
        {

            Assert.AreEqual(Titles.titles[1], GetDriverByXpath(CommonIdentifiers.MainQuestion).Text);
            // for now checking value from constants, but we can make api call and DB and validate
            Assert.AreEqual(SecondPageDetails.Option1, GetDriverByXpath(ListPageObjectIdentifiers.FirstOption).Text);
            Assert.AreEqual(SecondPageDetails.Option2, GetDriverByXpath(ListPageObjectIdentifiers.SecondOption).Text);
            Assert.AreEqual(SecondPageDetails.Option3, GetDriverByXpath(ListPageObjectIdentifiers.ThirdOption).Text);
            Assert.AreEqual(SecondPageDetails.Option4, GetDriverByXpath(ListPageObjectIdentifiers.FourthOption).Text);
            Assert.AreEqual(SecondPageDetails.Option5, GetDriverByXpath(ListPageObjectIdentifiers.FifthOption).Text);

        }

        [Then(@"Select '(.*)' rd/th option in  Screen")]
        public void ThenSelectOneOptionInScreen(int optionNumber)
        {
            GetDriverByXpath(ListPageObjectIdentifiers.SelectionOption.Replace("{0}", optionNumber.ToString())).Click();
        }

        [Then(@"Select on Continue Button")]
        public void ThenSelectOnContinueButton()
        {
            GetDriverByXpath(CommonIdentifiers.ContinueButton).Click();
        }

        [Then(@"validate Content in the '(.*)' screen")]
        public void ThenValidateContentInTheScreen(int screenNumber)
        {
            Assert.AreEqual(Titles.titles[screenNumber - 1], GetDriverByXpath(CommonIdentifiers.MainQuestion).Text);

        }

        [Then(@"Select Dropdown in the the screen")]
        public void ThenSelectDropdownInTheScreen()
        {
            GetDriverByXpath(DropDownPageObjectIdentifiers.SelectOption).Click();
        }

        [Then(@"Select '(.*)' rd/th option in  Screen from drop down")]
        public void ThenSelectOneOptionInScreenFromDropDown(int index)
        {
            SelectByxpath(DropDownPageObjectIdentifiers.SelectingOption).SelectByIndex(index); // we can do by name also
        }

        [Then(@"Select '(.*)' Dropdown in the the screen")]
        public void ThenSelectDropdownInTheScreen(string partofBirthDay)
        {
            GetDriverByXpath(DateofBirthIdentifiers.Selectors.Replace("{0}", partofBirthDay)).Click();
        }

        [Then(@"Select '(.*)' rd/th option in  Screen from drop down for DOB")]
        public void ThenSelectOneOptionInThirdScreenFromDropDown(string partofBirthDay)
        {
            SelectByxpath(DateofBirthIdentifiers.Selectors.Replace("{0}", partofBirthDay)).SelectByIndex(8); // we can do by name also
        }

        [Then(@"Select textbox in the screen and enter value '([^']*)'")]
        public void ThenSelectTextboxInTheScreenAndEnterValue(string hours)
        {
            GetDriverByClass(HoursTextBoxIdentifier.Selectors).SendKeys(hours);
        }

        [Then(@"Select Field enter value for first name '([^']*)'")]
        public void ThenSelectFieldEnterValueforFirstName(string value)
        {
            GetDriverByXpath(SignUpPageIdentifier.Selectors.Replace("{0}", SignUpDetails.FirstName)).SendKeys(value);
        }

        [Then(@"Select Field enter value for last name '([^']*)'")]
        public void ThenSelectFieldEnterValueforLastName(string value)
        {
            GetDriverByXpath(SignUpPageIdentifier.Selectors.Replace("{0}", SignUpDetails.lastName)).SendKeys(value);
        }

        [Then(@"Select Field enter value for email")]
        public void ThenSelectFieldEnterValueForEmail()
        {
            Random random = new Random();
            var email = string.Format("qa{0:0000}@test.com", random.Next(100005555));
            GetDriverByXpath(SignUpPageIdentifier.Selectors.Replace("{0}", SignUpDetails.Email)).SendKeys(email);
        }


        [Then(@"Select Field enter value for password '([^']*)'")]
        public void ThenSelectFieldEnterValueforPassword(string value)
        {
            GetDriverByXpath(SignUpPageIdentifier.Selectors.Replace("{0}", SignUpDetails.Password)).SendKeys(value);
        }

        [Then(@"Agree to terms and conditions")]
        public void ThenAgreeToTermsAndConditions()
        {
            GetDriverByXpath(SignUpPageIdentifier.TermsandConditions).Click();
        }

        [Then(@"Acknowledge to certain things")]
        public void ThenAcknowledgeToCertainThings()
        {
            GetDriverByXpath(SignUpPageIdentifier.Acknoledgment).Click();
        }

        [Then(@"validate Content in the sleepio main screen")]
        public void ThenValidateContentInTheSleepioMainScreen()
        {
            Thread.Sleep(6000);
            Assert.AreEqual(SleepIoMainScreen.Score, GetDriverByXpath(SleepioScorePage.SleepIoHeadline).Text);
        }

        [Then(@"validate logout button")]
        public void ThenValidateLogoutButton()
        {
            Assert.AreEqual(SleepIoMainScreen.Logout, GetDriverByClass(SleepioScorePage.Logout).Text);
        }

        [Then(@"user should see Error message to enter value in right range")]
        public void ThenUserShouldSeeErrorMessageToEnterValueInRightRange()
        {
            Assert.AreEqual(SignUpErrorMessages.WorkingHoursError, GetDriverByClass(SignupErrormessages.WorkingHours).Text);
        }

        [Then(@"Select Field enter value for incorrect email address format")]
        public void ThenSelectFieldEnterValueForIncorrectEmailAddressFormat()
        {
            GetDriverByXpath(SignUpPageIdentifier.Selectors.Replace("{0}", SignUpDetails.Email)).SendKeys("testgmail.com");
        }

        [Then(@"User should see Error message related to email")]
        public void ThenUserShouldSeeErrorMessageRelatedtoEmail()
        {
            Assert.AreEqual(SignUpErrorMessages.InvalidEmailAddress, GetDriverByClass(SignupErrormessages.InvalidDetails).Text);
        }

        [Then(@"User should see Error message related to password")]
        public void ThenUserShouldSeeErrorMessageRelatedToPassword()
        {
            Assert.AreEqual(SignUpErrorMessages.InvalidPasswordFormat, GetDriverByClass(SignupErrormessages.InvalidDetails).Text);
        }

        [Then(@"Select Field enter value for email with exisiting email address")]
        public void ThenSelectFieldEnterValueForEmailWithExisitingEmailAddress()
        {
            GetDriverByXpath(SignUpPageIdentifier.Selectors.Replace("{0}", SignUpDetails.Email)).SendKeys(UserSignInDetails.Email);
        }

        [Then(@"User should see Error message related to exiting email")]
        public void ThenUserShouldSeeErrorMessageRelatedToExitingEmail()
        {
            Assert.IsTrue(GetDriverByClass(SignupErrormessages.ExisitingEmailAddress).Text.Contains(SignUpErrorMessages.ExistingEmailAddress));
        }
    }
}
