using System;
using System.Runtime.InteropServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SSE_Automation_HomeAppliances.Framework.Features;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;
using SSE;

namespace SSE_Automation_HomeAppliances.Framework.Features

{
    public class HomeAdvice 
    {
        

        #region Constructor
        public HomeAdvice(LaunchBrowser launchBrowser):base(launchBrowser)
        {
        #endregion
     
     #region WebElement Properties
        
        /// Search for text Compare how much electrical appliances cost to use 
        [FindsBy(How = How.XPath,Using = "//*[@id=\"main\"]/div[1]/h1/span")]
        public IWebElement Homepagetext { get; set; };
        
        /// Reset list button

        [FindsBy(How = How.Id, Using = "reset")]
        public IWebElement ResetlistButton{ get; set; }

    #endregion

    #region Methods

    /// <summary>
    /// Method to check for PageLoad / Sync
    /// </summary>
    /// <returns> bool </returns>
    public override bool CheckForPageLoad()
        {
            return LaunchBrowser.WaitForElementToBeVisible(SSE_Automation_HomeAppliances.Framework.Features.ElelctricalAppliancescostFeature.Equals(Homepagetext.FindElement(By.XPath("//*[@id=\\\"main\\\"]/div[1]/h1/span\"));


        }
        
        /// Method to input the data on to the screen
       
        /// Method to perform select advice applies to country name
        
        /// <param name="elementName"></param>
        public override void CountrySelection(string elementName)
        {
            switch (elementName)
            {
                IWebElement CountrySelVar = LaunchBrowser.Equals(elementName(By.XPath("//*[@id=\"RootPlaceHolder_RootPlaceHolder_SubHeading\"]/span/a")));
                case "England":
                    CountrySelVar.FindElement(By.XPath).TagName = "England";
                    CountrySelVar.Click
                    break;
                case "Northern Ireland":
                    CountrySelVar.FindElement(By.XPath).TagName = "Northern Ireland";
                    CountrySelVar.Click
                    break;
                case "Scotland"
                    CountrySelVar.FindElement(By.XPath).TagName = "Scotland";
                    CountrySelVar.Click
                    break;
                case "Wales"
                    CountrySelVar.FindElement(By.XPath).TagName = "Wales";
                    CountrySelVar.Click
                    break;

            }
            
        }
        public void AddingAppliances()
        {
            string itemtype,Countryname;
            int ApplianceCnt;
            SelectElement ApplianceSel = new SelectElement(LaunchBrowser.FindElement(By.Id("appliance")));
            Foreach(IWebElement itemtype ApplianceSel.Options)
            {
            if (itemtype == "Air fryer" && Countryname=="England")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("0");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("30");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("week");
                IWebElement KWHTextbox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"kwhcost\"]"));
                KWHTextbox.SendKeys("34");
                IWebElement AddAppliancesButton = (LaunchBrowser.FindElement(By.Id("submit"));
                AddAppliancesButton.Click();
            }
            elseif (itemtype == "Broadband router")
            {
                    itemtype.Click();
                    IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                    hoursTextBox.SendKeys("24");
                    IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                    minTextBox.SendKeys("0");
                    SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                    FreqSelectionList.SelectByText("day");
                    IWebElement KWHTextbox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"kwhcost\"]"));

             }
             elseif (itemtype == "Dishwasher")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("0");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("30");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("day");
            }
            elseif(itemtype == "Extractor fan")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("0");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("30");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("day");
               
            }
            elseif(itemtype == "Hairdryer")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("1");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("0");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("week");

            }
            elseif(itemtype == "Iron")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("1");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("0");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("week");

            }
            elseif(itemtype == "Kettle")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("0");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("30");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("day");

            }
            elseif(itemtype == "Extractor fan")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("0");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("30");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("day");

            }
            elseif(itemtype == "Microwave")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("1");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("0");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("week");

            }
            elseif(itemtype == "Washing machine")
            {
                itemtype.Click();
                IWebElement HoursTextBox = (LaunchBrowser.FindElement(By.XPath("//*[@id=\"hours\"]"));
                hoursTextBox.SendKeys("0");
                IWebElement MinTextBox = (LaunchBrowser.FindElement(By.Id("mins"));
                minTextBox.SendKeys("30");
                SelectElement FreqSelectionList = new SelectElement(LaunchBrowser.FindElement(By.XPath("//*[@id=\"frequency\"]")));
                FreqSelectionList.SelectByText("day");

            }
        }
            
    }

    #endregion
    }
}