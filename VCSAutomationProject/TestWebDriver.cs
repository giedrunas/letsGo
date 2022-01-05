using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutomationProject
{
    class TestWebDriver
    {
        [Test]
        public static void TestChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com/";
            driver.Close();
        }
        [Test]
        public static void TestFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://login.yahoo.com/";
            driver.Close();
        }

        [Test]
        public static void TestYahooPage()
        {

            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com/";

            IWebElement emailInputField = driver.FindElement(By.Id("login-username"));
            emailInputField.SendKeys("Labas@labas.lt");

            IWebElement submitButton = driver.FindElement(By.Id("login-signin"));
            submitButton.Click();

            driver.Close();

        }
        [Test]
        public static void TestInputPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
            fullNameInputField.SendKeys("Giedrius Pavalkis");

            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();

            IWebElement newName = driver.FindElement(By.Id("name"));
            Assert.AreEqual("Name:Giedrius Pavalkis", newName.Text, "Name is wrong");
        }
    }
}
