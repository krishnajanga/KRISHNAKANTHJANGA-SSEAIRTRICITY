using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using ExpectedCondition = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SSE-AutomationHomeAppliances.Framework.Utilities
{
    public class LaunchBrowser
    {
    /// <summary>
    /// WebDriver instance Variable
    /// </summary>
    public IWebDriver Driver { get; set; }

     /// Method to launch Browser based on the input passed from feature file
    /// <param name="browserName"></param>
    public void LaunchBrowser(string browserName)
    {
        switch (browserName.ToUpper())
        {
            case "EDGE":
                LaunchEdge();
                break;
            case "CHROME":
                LaunchChrome();
                break;
        }
    }

    
    /// Method to launch Chrome Browser
   
    private void LaunchChrome()
    {
        var options = new ChromeOptions();
        options.AddAdditionalCapability("useAutomationExtension", false);
        options.AddArgument("--dns-prefetch-disable");
        options.AddExcludedArgument("enable-automation");
        options.AddUserProfilePreference("credentials_enable_service", false);
        options.AddUserProfilePreference("profile.password_manager_enabled", false);
        Driver = new ChromeDriver(options);
        Driver.Manage().Window.Maximize();
    }
    //Method to launch Edge Browser
    private void LaunchEdge()
    {
        Driver = new EdgeDriver();
        {
            System.setProperty("webdriver.edge.driver", "C:/Program Files (x86)/Microsoft/Edge/Application/msedgedriver.exe");
            Driver.Manage().Window.Maximize();            
        }
     }

    /// Abstract method for Launching URL/URI    
    /// <param name="url"></param>
    /// <exception cref="InvalidOperationException"></exception>
    public void LaunchUrl(string url)
    {
        if (null == Driver)
        {
            throw new InvalidOperationException("WebDriver has not been initialized");
        }
        else
        {
            /* Launch URL */
            Driver.Navigate().GoToUrl(url);
        }
    }


    /// <summary>
    /// Wrapper Method to wait for specified time for the element to be visible
    /// </summary>
    /// <param name="byElement"></param>
    /// <param name="waitTimeInSec"></param>
    /// <returns> bool </returns>
    public bool WaitForElementToBeVisible(By byElement, int waitTimeInSec = 30)
    {
        bool isVisible = false;
        try
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTimeInSec));
            wait.Until(ExpectedCondition.ElementIsVisible(byElement));
            if (Driver.FindElement(byElement).Displayed)
            {
                isVisible = true;
            }
        }
        catch (NoSuchElementException ex)
        {
            Console.WriteLine($"Exception Occured on Page Load : {ex.Message}");
            throw;
        }
        return isVisible;
    }

    /// <summary>
    ///  Wrapper Method to wait for specified time for the element to be clickable
    /// </summary>
    /// <param name="elementName"></param>
    /// <param name="waitTimeInSec"></param>
    /// <returns></returns>
    public bool WaitForElementToBeClickable(IWebElement elementName, int waitTimeInSec = 30)
    {
        bool isClickable = false;
        try
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(waitTimeInSec));
            wait.Until(ExpectedCondition.ElementToBeClickable(elementName));
            if (elementName.IsDisplayed() && elementName.IsEnabled())
            {
                isClickable = true;
            }
        }
        catch (NoSuchElementException ex)
        {
            Console.WriteLine($"Exception Occured on Page Load : {ex.Message}");
            throw;
        }
        return isClickable;
    }

    /// <summary>
    /// Method to get the List of IWebElements using "FindElements"
    /// </summary>
    /// <param name="elementBy"></param>
    /// <returns></returns>
    public IList<IWebElement> GetListOfWebElements(By elementBy)
    {
        IList<IWebElement> listOfElements = null;
        if (null != elementBy)
        {
            listOfElements = Driver.FindElements(elementBy);
        }
        return listOfElements;
    }

    /// <summary>
    /// Method to Capture (On Failure) Screenshot when its called from Hook.cs
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public MediaEntityModelProvider CaptureScreenshot(string name)
    {
        var screenshot = ((ITakesScreenshot)Driver).GetScreenshot().AsBase64EncodedString;
        return MediaEntityBuilder.CreateScreenCaptureFromBase64String(screenshot, name).Build();
    }
}
}