using System;
using System.Reflection;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow;

namespace SSEAutomationHomeAppliances.Utilities
{
    public abstract class BasePage
    {
        protected BrowserBase LaunchBrowser { get; private set; }
        protected BasePage(BrowserBase launchBrowser)
        {
            if (launchBrowser?.Driver != null)
            { 
                PageFactory.InitElements(launchBrowser.Driver, this);
            }
            LaunchBrowser = launchBrowser;
        }
        
        /* Abstract method for Page Load Assertion */ 
        public abstract bool CheckForPageLoad();
        
        /* Abstract method for Business Logic Execution */ 
        public abstract void KeyPageData(Table table);
        
        /* Abstract method for Click Operation */ 
        public abstract void ClickOperation(string elementName);
    }
    
    public static class CitizensAdvice
    {
        /// <summary>
        /// Hold the current Page instance until new page instance is created
        /// </summary>
        public static BasePage GetCurrentInstance { get; set; }
        
        /// <summary>
        /// Method to Create a Page Instance using Reflection
        /// </summary>
        /// <param name="pageName"></param>
        /// <param name="launchBrowser"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public static BasePage CreatePageInstance(string pageName, BrowserBase launchBrowser)
        {
            string trimmedPageName = pageName.Replace(" ", string.Empty).Trim();

            string assemblyName = Assembly.GetExecutingAssembly().FullName.Split(',')[0];
            string fullPageName = $"{assemblyName}.Pages.{trimmedPageName},{assemblyName}";

            GetCurrentInstance = Activator.CreateInstance(Type.GetType(fullPageName), launchBrowser) as BasePage;
            if (!GetCurrentInstance.GetType().IsSubclassOf(typeof(BasePage)))
            {
                throw new InvalidOperationException(
                    $"Exception Occured while create page instance for : {trimmedPageName}. Which is not a BasePage derived class");
            }
            return GetCurrentInstance;
        }
            
    }
}