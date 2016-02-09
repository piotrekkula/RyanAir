namespace RyanAirProject.StepDefinitions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using TechTalk.SpecFlow;
    using NUnit.Framework;
    using RyanAirProject.Pages;

    [Binding]
    public class RyanAirBookFlightsStepDefinitions : BaseStepDefinitions
    {

        [Given(@"I am on RyanAir home page")]
        public void GivenIAmOnRyanAirHomePage()
        {
            RyanAirHomePage = new RyanAirHomePageModel(Driver);
            Assert.True(Driver.Url.Contains("www.ryanair.com/ie/en")); 
        }

        [When(@"I Select one way flight")]
        public void WhenISelectOneWayFlight()
        {
            RyanAirHomePage.SetFlightType();
        }

        [When(@"I make a booking from (.*) to (.*) on (.*) for (.*) adults and (.*) children")]
        public void WhenIMakeABookingFromToOnForAdultsAndChildren(string p0, string p1, string p2, byte p3,byte p4)
        {
            RyanAirHomePage.SearchFlight(p0,p1,p2,p3,p4);
        }

        [Then(@"Choose flight page is displayed")]
        public void ThenChooseFlightPageIsDisplayed()
        {
            RyanAirChooseFlightPage = new RyanAirChooseFlightPageModel(Driver);
            //Assert.True(Driver.Url.Contains("booking/home/"));
        }

        [When(@"I select flight number")]
        public void WhenISelectFlightNumber()
        {
            RyanAirChooseFlightPage.SelectFare();
            RyanAirChooseFlightPage.ChooseFlight();
        }

        [Then(@"Extras page is displayed")]
        public void ThenExtrasPageIsDisplayed()
        {
            RyanAirPassengersPage = new RyanAirPassengersPageModel(Driver);
            //Assert.True(Driver.Url.Contains("booking/extras"));
        }

        [When(@"I select extras")]
        public void WhenISelectExtras()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Passengers page is displayed")]
        public void ThenPassengersPageIsDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I fill in passenger details with (.*) and (.*)")]
        public void WhenIFillInPassengerDetailsWithAnd(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I pay for booking with details")]
        public void WhenIPayForBookingWithDetails()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should get payment declined message")]
        public void ThenIShouldGetPaymentDeclinedMessage()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
