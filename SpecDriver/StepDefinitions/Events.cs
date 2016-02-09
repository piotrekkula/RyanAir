namespace RyanAirProject.StepDefinitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using TechTalk.SpecFlow;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using RyanAirProject.StepDefinitions;

    [Binding]
    public class Events : BaseStepDefinitions
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            ChromeOptions optionChrome = new ChromeOptions();
            optionChrome.AddAdditionalCapability("chrome.noWebsiteTestingDefaults", false);
            optionChrome.AddAdditionalCapability("chrome.applicationCacheEnabled", false);
            Driver = new ChromeDriver();
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 5));
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            FeatureInfo s = FeatureContext.Current.FeatureInfo;
            Console.WriteLine("*** Feature:" + s.Title);
        }

        [BeforeScenario]
        public static void BeforeScenario()
        {
            ScenarioInfo s = ScenarioContext.Current.ScenarioInfo;
            Console.WriteLine("*** Scenario:" + s.Title);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
        }

        [AfterFeature]
        public static void killBrowser()
        {
            Driver.Close();
        }

        [AfterTestRun]
        public static void TerminateWebDriver()
        {
            Driver.Quit();
        }
    }
}
