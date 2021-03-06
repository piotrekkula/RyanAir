﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace RyanAir.Features.RyanAir
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("BookFlights")]
    public partial class BookFlightsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "BookFlights.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "BookFlights", "\tIn order to book a flight\r\n\tAs a regular user\r\n\tI want to pay with credit card", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Book a one way flight for adults and children")]
        [NUnit.Framework.TestCaseAttribute("Dublin", "Berlin", "11/03/2016", "2", "1", "VISA", "5555555555555557", "265", "10/18", "Piotr", "Kula", "Mr", "Address", "Dublin", "12345", "Ireland", "example_email@gmail.com", "Poland", "888888888", new string[0])]
        public virtual void BookAOneWayFlightForAdultsAndChildren(
                    string airportfrom, 
                    string airportto, 
                    string flightdate, 
                    string nradults, 
                    string nrchildren, 
                    string cardtype, 
                    string cardnumber, 
                    string cvvcode, 
                    string cardvalid, 
                    string pas_Name, 
                    string pas_Surname, 
                    string pas_Title, 
                    string pas_Address, 
                    string pas_City, 
                    string pas_Postalcode, 
                    string pas_Country, 
                    string email, 
                    string phonecountry, 
                    string phonenumber, 
                    string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Book a one way flight for adults and children", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
testRunner.Given("I am on RyanAir home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I Select one way flight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.When(string.Format("I make a booking from {0} to {1} on {2} for {3} adults and {4} children", airportfrom, airportto, flightdate, nradults, nrchildren), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("Choose flight page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.When("I select flight number", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("Extras page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.When("I select extras", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 15
 testRunner.Then("Passengers page is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("I fill in passenger details with <passengername> and <passengersurname>", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        string.Format("{0}", cardtype),
                        string.Format("{0}", cardnumber),
                        string.Format("{0}", cardvalid),
                        string.Format("{0}", cvvcode),
                        string.Format("{0}", pas_Name),
                        string.Format("{0}", pas_Surname),
                        string.Format("{0}", pas_Address),
                        string.Format("{0}", pas_City),
                        string.Format("{0}", pas_Postalcode),
                        string.Format("{0}", pas_Country)});
#line 17
 testRunner.And("I pay for booking with details", ((string)(null)), table1, "And ");
#line 19
 testRunner.Then("I should get payment declined message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
