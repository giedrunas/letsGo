using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSAutomationProject
{
    
    class ND2
    {
        private static IWebDriver _driver;

        

        [TearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [TestCase("chrome", "Chrome 97 on Windows 10", TestName = "Browser version chrome")]
        [TestCase("firefox", "Firefox 97 on Windows 10", TestName = "Browser version firefox")]
        public static void ChromeVersion(string browserType, string expectedResult)
        {
            if (browserType.Equals("chrome"))
            {
                _driver = new ChromeDriver();
            }
            else if (browserType.Equals("firefox"))
            {
                _driver = new FirefoxDriver();
            }

            SetUpWebPage();
            
            IWebElement actualResult = _driver.FindElement(By.ClassName("simple-major"));

            Assert.AreEqual(expectedResult, actualResult.Text, "Version incorrect");

        }
        public static void SetUpWebPage()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        }
        
    }
}
