using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Helpers
{
    public class BrowserHelper
    {
        IWebDriver driver;
        public void Init_Browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        public string GetTitle
        {
            get { return driver.Title; }
        }
        public void NavigateTo(string url)
        {
            driver.Url = url;
        }
        public void CloseBrowser()
        {
            driver.Quit();
        }
        public IWebDriver GetDriver
        {
            get { return driver; }
        }

        public void RefreshBrowser()
        {
            driver.Navigate().Refresh();
        }
        public string GetCurrentURL()
        {
            return driver.Url;
        }
        public void BackToPreviousPage()
        {
            driver.Navigate().Back();
        }
        public string GetDriverTitle()
        {
            return driver.Title;
        }
    }
}
