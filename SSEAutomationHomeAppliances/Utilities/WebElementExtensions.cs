using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SSEAutomationHomeAppliances.Utilities
{
    public static class WebElementExtensions
    {
        
                /// <summary>
                /// Extension Method for Displayed
                /// </summary>
                /// <param name="element"></param>
                /// <returns> bool </returns>
                public static bool IsDisplayed(this IWebElement element)
                {
                    return element.Displayed;
                }
                
                /// <summary>
                /// Extension Method for Enabled
                /// </summary>
                /// <param name="element"></param>
                /// <returns> bool </returns>
                public static bool IsEnabled(this IWebElement element)
                {
                    return element.Enabled;
                }
                
                /// <summary>
                ///  Extension Method for SENDKEYS
                /// </summary>
                /// <param name="element"></param>
                /// <param name="value"></param>
                public static void SetInput(this IWebElement element, string value)
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(value)) 
                        { 
                            element.Clear();
                            element.SendKeys((value));
                        }
                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine($"Exception Occured: {ex.Message}");
                        throw;
                    }
                }
                
                /// <summary>
                ///  Extension Method for CLICK
                /// </summary>
                /// <param name="element"></param>
                public static void ClickOnElement(this IWebElement element)
                {
                    try
                    {
                        element.Click();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Exception Occured: {ex.Message}");
                        throw;
                    }
                    
                }
                

                /// <summary>
                ///  Extenstion method to move the cursor to an element using Actions method
                /// </summary>
                /// <param name="element"></param>
                /// <param name="browserBase"></param>
                public static void MoveToElementByAction(this IWebElement element, BrowserBase launchBrowser)
                {
                    var action = new Actions(launchBrowser.Driver);
                    action.MoveToElement(element).Build().Perform();
                }
                
                
    }
}