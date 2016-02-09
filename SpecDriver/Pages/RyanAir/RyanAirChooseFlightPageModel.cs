namespace RyanAirProject.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using OpenQA.Selenium;

    public class RyanAirChooseFlightPageModel : BasePageModel
    {
        // fare buttons
        private static readonly By StandardFareButtonSelector = By.XPath("//span[contains(@class,'standard-fare')]");

        // basket message selectors
        private static readonly By AddedToBasketMessageSelector = By.XPath("//div/span[contains(text(),'Added to basket')]");
        private static readonly By FromFieldSelector = By.XPath("//input[contains(@aria-labelledby,'label-airport-selector-from')]");
        // Navigation
        private static readonly By ContinueButtonSelector = By.Id("continue");
        
        public RyanAirChooseFlightPageModel(IWebDriver driver)
            : base(driver, ContinueButtonSelector)
        {
        }

        private IWebElement StandardFareButton
        {
            get { return Driver.GetElement(StandardFareButtonSelector); }
        }

        private IWebElement AddedToBasketMessage
        {
            get { return Driver.GetElement(AddedToBasketMessageSelector); }
        }

        private IWebElement ContinueButton
        {
            get { return Driver.GetElement(ContinueButtonSelector); }
        }

        public RyanAirChooseFlightPageModel SelectFare()
        {
            //possible enhancements to select different fares
            this.StandardFareButton.Click();
            this.WaitForObject(AddedToBasketMessageSelector);
            return new RyanAirChooseFlightPageModel(Driver);
        }

        public RyanAirExtrasPageModel ChooseFlight()
        {
            this.ContinueButton.Click();
            return new RyanAirExtrasPageModel(Driver);
        }
    }
}
