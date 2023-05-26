using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumDemo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo.Tests
{
    public class BaseTest
    {
        BrowserHelper browser = new BrowserHelper();
        String test_url = "https://www.google.com";
        IWebDriver driver;

        [SetUp]
        public void start_Browser()
        {
            browser.Init_Browser();
        }

        [Test]
        public void test_Browserops()
        {
            browser.NavigateTo(test_url);

            driver = browser.GetDriver;
            IWebElement element = driver.FindElement(By.XPath("//*[@id='search_form_input_homepage']"));
            element.SendKeys("Test Input");
            element.Submit();

        }


        [TearDown]
        public void close_Browser()
        {
            bool testResult = TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Passed;
            try
            {
                // Logs the result to test
                ((IJavaScriptExecutor)driver).ExecuteScript("Test-status=" + (testResult ? "passed" : "failed"));
            }
            finally
            {
                browser.CloseBrowser();
            }

        }
    }
}
