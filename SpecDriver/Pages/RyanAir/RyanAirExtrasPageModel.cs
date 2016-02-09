namespace RyanAirProject.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using OpenQA.Selenium;

    public class RyanAirExtrasPageModel : BasePageModel
    {
        // 
        
        // Navigation
        private static readonly By CheckOutButtonSelector = By.XPath("//button[contains(@translate,'trips.summary.buttons.btn_checkout')]");

        public RyanAirExtrasPageModel(IWebDriver driver)
            : base(driver, CheckOutButtonSelector)
        {
        }

        private IWebElement CheckOutButton
        {
            get { return Driver.GetElement(CheckOutButtonSelector); }
        }

        public RyanAirPassengersPageModel CheckOutAndPay()
        {
            this.WaitForObject(CheckOutButtonSelector);
            this.CheckOutButton.Click();
            return new RyanAirPassengersPageModel(Driver);
        }
    }
}