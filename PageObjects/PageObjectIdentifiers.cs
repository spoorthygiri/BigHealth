using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHealth.PageObjects
{
    public static class HomePageObjectIdentifiers
    {
        public static string loginButton = "sl-header__login";
        public static string getStartedButton = "//*[@class='landing-page']/button";
        public static string homepageContent = "//*[@class='landing-page']/h1";
       
    }

    public static class CommonIdentifiers
    {
        public static string ContinueButton = "//*[@class='sl-button-wrapper']/button";
        public static string MainQuestion = "//*[@class='sl-page']/div[1]/div/div[1]/label";
    }

    public static class ListPageObjectIdentifiers
    {
       
        public static string FirstOption = "//*[@class='sl-page']/div[1]/div/div[2]/div/div/div[1]/label/span";
        public static string SecondOption = "//*[@class='sl-page']/div[1]/div/div[2]/div/div/div[2]/label/span";
        public static string ThirdOption = "//*[@class='sl-page']/div[1]/div/div[2]/div/div/div[3]/label/span";
        public static string FourthOption = "//*[@class='sl-page']/div[1]/div/div[2]/div/div/div[4]/label/span";
        public static string FifthOption = "//*[@class='sl-page']/div[1]/div/div[2]/div/div/div[5]/label/span";
        public static string SelectionOption = "//input[@id='options-id-{0}']";
    }

    public static class DropDownPageObjectIdentifiers
    {
        public static string DropDown = "//*[@id='id-136']";
        public static string SelectOption = "//*[@class='sl-page__item']/div/div[2]/div/div";
        public static string SelectingOption = "//select[contains(@class,'sl-select')]";
    }

    public static class DateofBirthIdentifiers
    {
        public static string Selectors = "//select[contains(@id,'select-{0}')]";
    }

    public static class HoursTextBoxIdentifier
    {
        public static string Selectors = "sl-input-number";
    }

    public static class SignUpPageIdentifier
    {
        public static string Selectors = "//input[contains(@name,'{0}')]";
        public static string TermsandConditions = "//*[@id='sl-flow']/div[3]/div/div/div/div/form/div[5]/input";
        public static string Acknoledgment = "//*[@id='sl-flow']/div[3]/div/div/div/div/form/div[6]/input";
    }

    public static class SleepioScorePage
    {
        public static string SleepIoHeadline = "//*[@id='sl-flow']/header/div/h1";
        
        public static string Logout = "sl-header__login";

    }


    public static class SignupErrormessages
    {
        public static string WorkingHours = "sl-error";
        public static string InvalidDetails = "sl-input-text__error";
        public static string ExisitingEmailAddress = "sl-interactive-v2--error";
    }

    public static class LoginPage
    {
       public static string Login = "sl-header__login";
       public static string Email = "sl-login-email"; 
       public static string Password = "sl-login-password";
       public static string ContinueButton = "//*[@class='sl-new-login-button-wrapper']/button";
       public static string LoginError = "//*[@class='sl-login--error']/p";
    }
}
