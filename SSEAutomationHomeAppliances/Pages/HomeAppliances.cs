using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SSEAutomationHomeAppliances.Utilities;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using NUnit.Framework;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using Gherkin.Events.Args.Pickle;
using OpenQA.Selenium.Chrome;

namespace SSEAutomationHomeAppliances.Pages
{
    public class HomeAppliances : BasePage
    {
        private readonly BrowserBase _launchBrowser;
        public HomeAppliances(BrowserBase browser) : base(browser)
        {
            _launchBrowser = browser;
        }
        
        #region WebElement Properties
        
        [FindsBy(How = How.XPath, Using = "//span[text() = 'Compare how much electrical appliances cost to use']")]
        private IWebElement PageName { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id = 'RootPlaceHolder_RootPlaceHolder_SubHeading']/span/a")]
        private IWebElement CountryLink { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id = 'dialog-1-main']/ul/li")]
        private IWebElement CountryList { get; set; }
        
        [FindsBy(How = How.Id, Using = "appliance")]
        private  IWebElement AddAnAppliances { get; set; }
        
        [FindsBy(How = How.Id, Using = "hours")]
        private  IWebElement Hours { get; set; }

        [FindsBy(How = How.Id, Using = "mins")]
        private  IWebElement Mins { get; set; }
        
        [FindsBy(How = How.Id, Using = "submit")]
        private  IWebElement AddAppliancesToListBtn { get; set; }
        
        [FindsBy(How = How.Id, Using = "kwhcost")]
        private  IWebElement kwh { get; set; } 
        #endregion
        
        public override bool CheckForPageLoad()
        {
            return LaunchBrowser.WaitForElementToBeVisible(
                By.XPath("//span[text() = 'Compare how much electrical appliances cost to use']"));
        }
        
        public override void KeyPageData(Table table)
        {
            var appliancesList = table.CreateSet<ApplianceData>();
            int count = 1;
            foreach (var appliances in appliancesList)
            {
               // AddAnAppliances.SelectDropdownList(appliances.Appliance.ToString());
                SelectElement element = new SelectElement(AddAnAppliances);
                element.SelectByIndex(count);
                Hours.SetInput(appliances.Hours);
                Mins.SetInput(appliances.mins);
                if(kwh.Displayed)
                    kwh.SetInput(appliances.kwh);
                ClickOperation("AddAnAppliance");
                count++;
            }
        }

        public override void ClickOperation(string elementName)
        {
            switch (elementName)
            {
                case "AddAnAppliance":
                    IJavaScriptExecutor executor = (IJavaScriptExecutor)_launchBrowser.Driver;
                    executor.ExecuteScript("arguments[0].click();", AddAppliancesToListBtn);
                    break;
                default:
                    SelectCountry(elementName);
                    break;
            }
        }

        public void SelectCountry(string value)
        {
            CountryLink.Click();
            IList<IWebElement> countryList = LaunchBrowser.GetListOfWebElements(By.XPath("//*[@id = 'dialog-1-main']/ul/li"));
            foreach (var country in countryList)
            {
                if (country.Text.Equals(value))
                {
                    country.Click();
                    break;
                }
            }
        }
        public bool CountNumberOfRowsIntable(string value)
        {
            bool rowCountMatch = false;
            IList<IWebElement> tableRows =
                LaunchBrowser.GetListOfWebElements(By.XPath("//*[@id='appliance_running']/table/tbody/tr"));
            if (tableRows.Count.Equals(int.Parse(value)))
            {
                rowCountMatch = true;
            }

            //Identify table to get values
            IWebElement tempElement;
            tempElement = LaunchBrowser.Driver.FindElement(By.CssSelector("#appliance_running > table"));

            //TagName to get all <tr> elements
            IList<IWebElement> ListOfElements = tempElement.FindElements(By.TagName("tr"));
            foreach (var tableitem in ListOfElements)
            {
                Console.WriteLine(tableitem.Text);
            }
            return rowCountMatch;
        }        
    }

    public class ApplianceData
    {
        public string Appliance { get; set; }
        public string Hours { get; set; }
        public string mins { get; set; }
        public string kwh { get; set; }
    }
}


