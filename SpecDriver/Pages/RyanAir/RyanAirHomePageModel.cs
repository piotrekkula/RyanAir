namespace RyanAirProject.Pages
{
    using OpenQA.Selenium;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    public class RyanAirHomePageModel : BasePageModel
    {
        private static readonly String Url = "http://www.ryanair.com/ie/en/";

        // Flight type button selectors
        private static readonly By OneWayFlightRadButtonSelector = By.Id("lbl-flight-search-type-one-way");
        private static readonly By ReturnFlightRadButtonSelector = By.XPath("//span[contains(@class,'standard-fare')]");

        // Destination field selectors
        private static readonly By FromFieldSelector = By.XPath("//input[contains(@aria-labelledby,'label-airport-selector-from')]");
        private static readonly By ToFieldSelector = By.XPath("//input[contains(@aria-labelledby,'label-airport-selector-to')]");

        // Flight Date button selectors
        private static readonly By FlyOutDayFieldSelector = By.XPath("//input[@aria-label='Fly out: - DD']");
        private static readonly By FlyOutMonthFieldSelector = By.XPath("//input[@aria-label='Fly out: - MM']");
        private static readonly By FlyOutYearFieldSelector = By.XPath("//input[@aria-label='Fly out: - YYYY']");

        // Passengers button selectors
        private static readonly By PassengerDropdownButtonSelector = By.ClassName("dropdown-handle");
        private static readonly By AdultsNumberButtonSelector = By.XPath("//input[@aria-label='Adults 16+ years']");
        private static readonly By TeensNumberButtonSelector = By.Id("");
        private static readonly By ChildrenNumberButtonSelector = By.XPath("//input[@aria-label='Children 2-11 years']"); 
        private static readonly By InfantsNumberButtonSelector = By.Id("");

        // Confirm
        private static readonly By ContinueButtonSelector = By.XPath("//button/span[contains(text(),'Continue')]");
        private static readonly By LetsGoButtonSelector = By.XPath("//button/span[contains(@translate,'common.buttons.lets_go')]");

        public RyanAirHomePageModel(IWebDriver driver)
            : base(driver, LetsGoButtonSelector, Url)
        {
        }

        private IWebElement OneWayFlightRadButton 
        {
            get { return Driver.GetElement(OneWayFlightRadButtonSelector); }
        }

        private IWebElement FromField
        {
            get { return Driver.GetElement(FromFieldSelector); }
        }

        private IWebElement ToField
        {
            get { return Driver.GetElement(ToFieldSelector); }
        }

        private IWebElement FlyOutDayField
        {
            get { return Driver.GetElement(FlyOutDayFieldSelector); }
        }

        private IWebElement FlyOutMonthField
        {
            get { return Driver.GetElement(FlyOutMonthFieldSelector); }
        }

        private IWebElement FlyOutYearField
        {
            get { return Driver.GetElement(FlyOutYearFieldSelector); }
        }

        private IWebElement PassengerDropdownButton
        {
            get { return Driver.GetElement(PassengerDropdownButtonSelector); }
        }

        private IWebElement AdultsNumberButton
        {
            get { return Driver.GetElement(AdultsNumberButtonSelector); }
        }

        private IWebElement ChildrenNumberButton
        {
            get { return Driver.GetElement(ChildrenNumberButtonSelector); }
        }

        private IWebElement ContinueButton
        {
            get { return Driver.GetElement(ContinueButtonSelector); }
        }

        private IWebElement LetsGoButton
        {
            get { return Driver.GetElement(LetsGoButtonSelector); }
        }

        public void SetFlightType()
        {
            this.OneWayFlightRadButton.Click();
        }

        public RyanAirChooseFlightPageModel SearchFlight(string fromAirport,string toAirport, string flyOutDate, byte adultsNumber, byte childrenNumber)
        {
            
            this.FromField.Click();
            this.FromField.SendKeys(fromAirport);
            this.ToField.Click();
            this.ToField.SendKeys(toAirport);
            this.ContinueButton.Click();
            this.WaitForObject(FlyOutYearFieldSelector);
            try
            {
                DateTime date = DateTime.ParseExact(flyOutDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string day = date.Day.ToString();
                string month = date.Month.ToString();
                string year = date.Year.ToString();

                FlyOutDayField.Clear();
                FlyOutDayField.SendKeys(day);
                FlyOutMonthField.Clear();
                FlyOutMonthField.SendKeys(month);
                FlyOutYearField.Clear();
                FlyOutYearField.SendKeys(year);
            }
            catch
            {
                
            }
            this.PassengerDropdownButton.Click();
            this.AdultsNumberButton.Click();
            this.AdultsNumberButton.Clear();
            this.AdultsNumberButton.SendKeys(adultsNumber.ToString());
            this.ChildrenNumberButton.Click();
            this.ChildrenNumberButton.Clear();
            this.ChildrenNumberButton.SendKeys(adultsNumber.ToString());
            this.LetsGoButton.Click();
            return new RyanAirChooseFlightPageModel(Driver);
        }
    }
}
