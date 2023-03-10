using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using SSEAutomationHomeAppliances.Pages;
using TechTalk.SpecFlow;
using SSEAutomationHomeAppliances.Utilities;
using TechTalk.SpecFlow.Assist;

namespace SSEAutomationHomeAppliances.Steps
{
    [Binding]
    public sealed class StepDefinition
    {
        private readonly LaunchBrowser _launchBrowser;

        public StepDefinition(LaunchBrowser launchBrowser) => _launchBrowser = launchBrowser;        
        [Given(@"I am resident from England")]
        public void GivenIAmResidentFromEngland(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _launchBrowser.LaunchBrowser((string)data.BrowserName);
            _launchBrowser.LaunchUrl((string)data.Url);
        }   
        [Then(@"I should be displayed with message ""(.*)""")]
        public void ThenIShouldBeDisplayedWithMessage(string message)
        {
            if (_launchBrowser.Driver.PageSource.Contains(message))
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsFalse(true);
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        [Given(@"I am on Compare how much electrical appliances cost to use screen")]
        public void GivenIAmOnCompareHowMuchElectricalAppliancesCostToUseScreen()
        {
            BasePage page = CitizensAdvice.CreatePageInstance("HomeAppliances", _launchBrowser);
            Assert.That(page.CheckForPageLoad(), Is.True);
        }

        [When(@"I select country as ""(.*)""")]
        public void WhenISelectCountryAs(string value)
        {
            var page = CitizensAdvice.GetCurrentInstance;
            page.ClickOperation(value);
        }

        [When(@"I enter the below list of appliances and click on Add appliance to your list")]
        public void WhenIEnterTheBelowListOfAppliancesAndClickOnAddApplianceToYourList(Table table)
        {
            var page = CitizensAdvice.GetCurrentInstance;
            page.KeyPageData(table);
        }
        
        [Then(@"all the ""(.*)"" appliances list should be displayed in the table below\.")]
        public void ThenAllTheAppliancesListShouldBeDisplayedInTheTableBelow(string value)
        {
            var page = new HomeAppliances(_launchBrowser);
            Assert.IsTrue(page.CountNumberOfRowsIntable(value));
        }
    }
}