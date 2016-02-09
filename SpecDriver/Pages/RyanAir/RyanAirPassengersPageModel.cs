namespace RyanAirProject.Pages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using OpenQA.Selenium;

    public class RyanAirPassengersPageModel : BasePageModel
    {

        // Passenger details selectors
        private static readonly By TitleDropdownSelector = By.XPath("//");
        private static readonly By AdultFirstNameFieldSelector = By.XPath("//");
        private static readonly By AdultLastNameFieldSelector = By.XPath("//");
        private static readonly By ChildFirstNameFieldSelector = By.XPath("//");
        private static readonly By ChildLastNameFieldSelector = By.XPath("//");
        private static readonly By ContinueToContactDetailsButtonSelector = By.XPath("//");

        // Contact details selectors
        private static readonly By EmailFieldSelector = By.XPath("//");
        private static readonly By PhoneCountryDropdownSelector = By.XPath("//");
        private static readonly By PhoneCountryCountrySelector = By.XPath("//");
        private static readonly By PhoneNumberFieldSelector = By.XPath("//");
        private static readonly By ContinueToPaymentButtonSelector = By.XPath("//");

        // Payment details selectors
        private static readonly By PaymentMethodCardButtonSelector = By.XPath("//");
        private static readonly By PaymentMethodPayPalButtonSelector = By.XPath("//");
        private static readonly By CardTypeDropdownSelector = By.XPath("//");
        private static readonly By CardTypeCardSelector = By.XPath("//");
        private static readonly By CardNumberFieldSelector = By.XPath("//");
        private static readonly By ExpiryMonthDropdownSelector = By.XPath("//");
        private static readonly By ExpiryYearDropdownSelector = By.XPath("//");
        private static readonly By SecurityCodeFieldSelector = By.XPath("//");
        private static readonly By CardholderNameFieldSelector = By.XPath("//");
        private static readonly By CardholderAddressFieldSelector = By.XPath("//");
        private static readonly By CardholderCityFieldSelector = By.XPath("//");
        private static readonly By CardholderPostalCodeFieldSelector = By.XPath("//");
        private static readonly By CardholderCountryFieldSelector = By.XPath("//");
        private static readonly By TermsAndConditionsButtonSelector = By.XPath("//");
        private static readonly By PayNowButtonSelector = By.XPath("//");

        // Payment errors selectors
        private static readonly By CardRejectedMessageSelector = By.XPath("//");

        public RyanAirPassengersPageModel(IWebDriver driver)
            : base(driver, ContinueToContactDetailsButtonSelector)
        {
        }

        private IWebElement TitleDropdown
        {
            get { return Driver.GetElement(TitleDropdownSelector); }
        }

        private IWebElement AdultFirstNameField
        {
            get { return Driver.GetElement(AdultFirstNameFieldSelector); }
        }

        private IWebElement AdultLastNameField
        {
            get { return Driver.GetElement(AdultLastNameFieldSelector); }
        }

        private IWebElement ChildFirstNameField
        {
            get { return Driver.GetElement(ChildFirstNameFieldSelector); }
        }

        private IWebElement ChildLastNameField
        {
            get { return Driver.GetElement(ChildLastNameFieldSelector); }
        }

        private IWebElement ContinueToContactDetailsButton
        {
            get { return Driver.GetElement(ContinueToContactDetailsButtonSelector); }
        }

        private IWebElement EmailField
        {
            get { return Driver.GetElement(EmailFieldSelector); }
        }

        private IWebElement PhoneCountryDropdown
        {
            get { return Driver.GetElement(PhoneCountryDropdownSelector); }
        }

        private IWebElement PhoneCountryCountry
        {
            get { return Driver.GetElement(PhoneCountryCountrySelector); }
        }

        private IWebElement PhoneNumberField
        {
            get { return Driver.GetElement(PhoneNumberFieldSelector); }
        }

        private IWebElement ContinueToPaymentButton
        {
            get { return Driver.GetElement(ContinueToPaymentButtonSelector); }
        }

        private IWebElement PaymentMethodCardButton
        {
            get { return Driver.GetElement(PaymentMethodCardButtonSelector); }
        }

        private IWebElement PaymentMethodPayPalButton
        {
            get { return Driver.GetElement(PaymentMethodPayPalButtonSelector); }
        }

        private IWebElement CardTypeDropdown
        {
            get { return Driver.GetElement(CardTypeDropdownSelector); }
        }

        private IWebElement CardTypeCard
        {
            get { return Driver.GetElement(CardTypeCardSelector); }
        }

        private IWebElement CardNumberField
        {
            get { return Driver.GetElement(CardNumberFieldSelector); }
        }

        private IWebElement ExpiryMonthDropdown
        {
            get { return Driver.GetElement(ExpiryMonthDropdownSelector); }
        }

        private IWebElement ExpiryYearDropdown
        {
            get { return Driver.GetElement(ExpiryYearDropdownSelector); }
        }

        private IWebElement SecurityCodeField
        {
            get { return Driver.GetElement(SecurityCodeFieldSelector); }
        }

        private IWebElement CardholderNameField
        {
            get { return Driver.GetElement(CardholderNameFieldSelector); }
        }

        private IWebElement CardholderAddressField
        {
            get { return Driver.GetElement(CardholderAddressFieldSelector); }
        }

        private IWebElement CardholderCityField
        {
            get { return Driver.GetElement(CardholderCityFieldSelector); }
        }

        private IWebElement CardholderPostalCodeField
        {
            get { return Driver.GetElement(CardholderPostalCodeFieldSelector); }
        }

        private IWebElement CardholderCountryField
        {
            get { return Driver.GetElement(CardholderCountryFieldSelector); }
        }

        private IWebElement TermsAndConditionsButton
        {
            get { return Driver.GetElement(TermsAndConditionsButtonSelector); }
        }

        private IWebElement PayNowButton
        {
            get { return Driver.GetElement(PayNowButtonSelector); }
        }

        private IWebElement CardRejectedMessage
        {
            get { return Driver.GetElement(CardRejectedMessageSelector); }
        }

        public RyanAirPassengersPageModel FillInPassengerDetails()
        {
            /*
            Function should fill in passenger details. Either advised to pass arguments from Feature file or generate them randomly(depends on testing context).
            List of IWebElement is useful here for cycling through passenger details.
            */
            return FillInContactDetails();
        }

        public RyanAirPassengersPageModel FillInContactDetails()
        {
            /*
            Function should fill in contact details. Either advised to pass arguments from Feature file or generate them randomly(depends on testing context).
            */
            return FillInPaymentDetails();
        }

        public RyanAirPassengersPageModel FillInPaymentDetails()
        {
            /*
            Pass arguments from feature file regarding payment here.
            Advised to use conditions for selecting payment method.
            */
            return new RyanAirPassengersPageModel(Driver);
        }

        public RyanAirPassengersPageModel FinalizePayment()
        {
            //this.PayNowButton.Click();
            return new RyanAirPassengersPageModel(Driver);
        }
    }
}