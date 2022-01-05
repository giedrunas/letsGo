using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutomationProject
{
    class PiguLt
    {
        private static IWebDriver _driver;

        [NUnit.Framework.OneTimeSetUp]

        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://pigu.lt/lt/";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public static void CloseCookies()
        {
            IWebElement popUp = _driver.FindElement(By.CssSelector("#cookie_block > div > div > div.cookies_action > button"));

            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
            wait.Until(x => popUp.Displayed);

            popUp.Click();
        }

    }
}          
