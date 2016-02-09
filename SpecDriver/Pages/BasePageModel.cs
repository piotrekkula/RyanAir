using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace RyanAirProject.Pages
{
    public class BasePageModel
    {
        private IWebDriver driver;

        protected BasePageModel(IWebDriver webDriver, By knownElementOnPage, String loadUrl = "")
        {
            this.driver = webDriver;
            if (loadUrl != String.Empty)
            {
                Debug.WriteLine("URL ========== >>>>  " + loadUrl);
                driver.Navigate().GoToUrl(loadUrl);
            }
            this.FindKnownElementOnPage(knownElementOnPage);
        }

        public string Title
        {
            get { return driver.Title; }
        }

        public IWebDriver Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }

        private void FindKnownElementOnPage(By knownElementOnPage)
        {
            this.Driver.GetElement(knownElementOnPage);
        }

        public void WaitForObject(By objectExpected)
        {
            WebDriverWait wait = new WebDriverWait(new SystemClock(), Driver, TimeSpan.FromSeconds(10), TimeSpan.FromMilliseconds(1000));
            IWebElement elementToWait = wait.Until<IWebElement>((d) => { return d.FindElement(objectExpected); });
        }
    }
}