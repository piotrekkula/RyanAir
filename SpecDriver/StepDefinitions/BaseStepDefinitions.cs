using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using RyanAirProject.Pages;

namespace RyanAirProject.StepDefinitions
{
    [Binding]
    public class BaseStepDefinitions
    {
        private const string CurrentPageKey = "Current.Page";
        public static IWebDriver Driver { get; set; }

        protected RyanAirHomePageModel RyanAirHomePage
        {
            get { return (RyanAirHomePageModel)ScenarioContext.Current[CurrentPageKey]; }
            set { ScenarioContext.Current[CurrentPageKey] = value; }
        }
        protected RyanAirChooseFlightPageModel RyanAirChooseFlightPage
        {
            get { return (RyanAirChooseFlightPageModel)ScenarioContext.Current[CurrentPageKey]; }
            set { ScenarioContext.Current[CurrentPageKey] = value; }
        }
        protected RyanAirExtrasPageModel RyanAirExtrasPage
        {
            get { return (RyanAirExtrasPageModel)ScenarioContext.Current[CurrentPageKey]; }
            set { ScenarioContext.Current[CurrentPageKey] = value; }
        }
        protected RyanAirPassengersPageModel RyanAirPassengersPage
        {
            get { return (RyanAirPassengersPageModel)ScenarioContext.Current[CurrentPageKey]; }
            set { ScenarioContext.Current[CurrentPageKey] = value; }
        }
    }
}
