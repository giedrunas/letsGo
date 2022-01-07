using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSAutomationProject.Page;

namespace VCSAutomationProject.Tests
{
    class CheckBoxClicksTest
    {

        private static IWebDriver _driver;

        [OneTimeSetUp]

        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://demoqa.com/checkbox";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        [Test]
        public static void CheckBoxClicks()
        {
            CheckBoxClicksPage CheckBoxClicksPage = new CheckBoxClicksPage(_driver);

            string text = "commands";

            CheckBoxClicksPage.ExpandAll();
            CheckBoxClicksPage.ClickCommandCheckBox();
            CheckBoxClicksPage.VerifySelectedResult(text);
        }
    }
}