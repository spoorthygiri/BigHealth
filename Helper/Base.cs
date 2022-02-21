using BigHealth.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHealth.Helper
{
    public class Base
    {

        static int timeoutInSeconds = Constant.PagLoadTim;
        public static IWebDriver Driver { get; set; }
        static SelectElement selectE { get; set; }

        #region FindElement ID,Class, Link, Name, xpath
        public static IWebElement GetDriverByID(string Id)
        {
            return FindElementss(By.Id(Id));
        }
        public static IWebElement GetDriverByClass(string Id)
        {
            return FindElementss(By.ClassName(Id));
        }

        public static IWebElement GetDriverByLink(string Link)
        {
            return FindElementss(By.LinkText(Link));
        }
        public static IWebElement GetDriverByParLink(string ParLink)
        {
            return FindElementss(By.PartialLinkText(ParLink));
        }

        public static IWebElement GetDriverByName(string Nam)
        {
            return FindElementss(By.Name(Nam));
        }
        public static IWebElement GetDriverByXpath(string xp)
        {
            return FindElementss(By.XPath(xp));
        }

        public static IWebElement GetDriverByXpathAppInsights(string xp)
        {
            Driver.SwitchTo().Frame(Driver.FindElement(By.ClassName("fxs-part-frame")));
            System.Threading.Thread.Sleep(100);
            return FindElementss(By.XPath(xp));
        }

 
        #endregion

        #region find elements
        public static IWebElement GetDriverByElementsClass(string Class)
        {
            return FindElementss(By.XPath(Class));
        }

        #endregion
        /// <summary>
        /// Creates Web Driver
        /// </summary>
        public static void InitializeBrowser()
        {
            if (Driver == null)
            {
                if (Constant.Browser.Equals("Chrome"))
                {
                    Driver = new ChromeDriver(Directory.GetCurrentDirectory());
                    Driver.Manage().Window.Maximize();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(125);
                    Driver.Navigate().GoToUrl(Constant.SleepIoUrl);
                }
                else if (Constant.Browser.Equals("IE"))
                {
                    Driver = new InternetExplorerDriver();
                    Driver.Manage().Window.Maximize();
                }
                else if (Constant.Browser.Equals("Edge"))
                {
                    Driver = new EdgeDriver();
                    Driver.Manage().Window.Maximize();
                }
            }
            //Close Browser
            AppDomain.CurrentDomain.DomainUnload += End;
        }
        static void End(object sender, EventArgs e)
        {
            if (Driver != null)
            {
                Driver.Quit();
            }
        }

        /// <summary>
        /// Find web elements 
        /// </summary>
        /// <param name="By">Search type</param>
        /// <returns>IWebElement found</returns>
        public static IWebElement FindElementss(By By)
        {
            IWebElement element = null;

            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(timeoutInSeconds));
            System.Threading.Thread.Sleep(100);
            try
            {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By));
                System.Threading.Thread.Sleep(100);
                element = Driver.FindElement(By);
            }
            catch (Exception ep)
            {
                string message = ep.Message;
                if (message.Contains("NoSuchElementException") || message.Contains("The operation has timed out "))
                {
                    element = null;
                }
            }
            return element;
        }
       
        public static void ImplicitPageWait(int seconds)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(seconds);
        }

        public static void PageReload()
        {
            Driver.Navigate().Refresh();
            //Driver.get(driver.getCurrentURL());
            System.Threading.Thread.Sleep(4000);
        }


        #region SelectElement ID, Name, Class and xpath
        public static SelectElement SelectByID(string SID)
        {
            return new SelectElement(FindElementss(By.Id(SID)));
        }
        public static SelectElement SelectByName(string Name)
        {
            return new SelectElement(FindElementss(By.Name(Name)));
        }
        public static SelectElement SelectByclass(string ClNa)
        {
            return new SelectElement(FindElementss(By.ClassName(ClNa)));
        }
        public static SelectElement SelectByxpath(string xpath)
        {
            return new SelectElement(FindElementss(By.XPath(xpath)));
        }
        #endregion

        //public void SelectionoptionFromDropdown(string path)
        //{
        //    GetDriverByXpath(path).Click();
        //    Actions keyDown = new Actions(Driver);
        //    keyDown.SendKeys(Keys.Command(Keys.Down, Keys.Down)).perform();
        //}


    }
}
