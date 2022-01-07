using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VCSAutomationProject.Page;

namespace VCSAutomationProject.Tests
{
    class NotesGeneralTest
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
            NotesGeneralPage NotesGeneralPage = new NotesGeneralPage(_driver);

            string text = "You have selected :\r\nnotes\r\ngeneral";

            NotesGeneralPage.ExpandAll();
            Thread.Sleep(2000);
            NotesGeneralPage.ClickNotesCheckBox();
            Thread.Sleep(2000);
            NotesGeneralPage.ClickGeneralCheckBox();
            Thread.Sleep(2000);
            NotesGeneralPage.VerifySelectedResult(text);
        }
    }
}
