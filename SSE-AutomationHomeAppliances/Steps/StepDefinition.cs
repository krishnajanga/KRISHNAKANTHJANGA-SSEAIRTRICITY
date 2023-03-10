using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SSE-AutomationHomeAppliances.Utilities;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium;

namespace SSE-AutomationHomeAppliances.Steps
{
    [Binding]
    public sealed class StepDefinition
    {
        private readonly LaunchBrowser _launchBrowser;

        public StepDefinition(LaunchBrowser launchBrowser) => _launchBrowser = launchBrowser;

       [Given(@"I am on Compare how much electrical appliances cost to use page")]
        public void GivenIamonComparehowmuchelectricalappliancescosttousepage()
        {
            throw new PendingStepException();
        }
        [When(@"I Select the country as ""(.*)""")]
        public void WhenISelectTheCountryAs(string countryname)
        {
        IWebElement countryname = LaunchBrowser.FindElement(By.XPath("//*[@id=\"RootPlaceHolder_RootPlaceHolder_SubHeading\"]/span/a"));

        }

        [When(@"I completed the below details and click on Add appliance to your list button")]
        public void WhenICompletedTheBelowDetailsAndClickOnAddApplianceToYourListButton(Table table)
        {
            throw new PendingStepException();
        }

        [Then(@"I should get the results table with daily, weekly, monthly, and yearly cost\.")]
        public void ThenIShouldGetTheResultsTableWithDailyWeeklyMonthlyAndYearlyCost_()
        {
            throw new PendingStepException();
        }

        
       
        [When(@"I Select the country as ""([^""]*)""")]
        public void WhenISelectTheCountryAs(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I should get the results message as ‘The advice on this website doesn’t cover Northern Ireland’")]
        public void ThenIShouldGetTheResultsMessageAsTheAdviceOnThisWebsiteDoesnTCoverNorthernIreland()
        {
            throw new PendingStepException();
        }


    }
}