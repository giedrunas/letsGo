using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace VCSAutomationProject
{
    class ND2_2
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]

        public void SetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
            _driver.Url = "https://www.active.com/fitness/calculators/pace";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _driver.Close();
        }

        
        [TestCase("1", "5", "13", "5", TestName = "Pace = 5min/km")]
        public static void TestPaceCheck(string firstInputValue, string secondInputValue, string thirdInputValue, 
                                         string expectedResult)
        {
            IWebElement firstInput = _driver.FindElement(By.Name("Hrs"));
            IWebElement secondInput = _driver.FindElement(By.Name("time_minutes"));
            IWebElement thirdInput = _driver.FindElement(By.Name("distance"));

            firstInput.Clear();
            firstInput.SendKeys(firstInputValue);
            secondInput.Clear();
            secondInput.SendKeys(secondInputValue);
            thirdInput.Clear();
            thirdInput.SendKeys(thirdInputValue);


            IWebElement distance = _driver.FindElement(By.ClassName("selectboxit-option-icon-container"));
            SelectElement oSelectDistance = new SelectElement(distance);
            oSelectDistance.SelectByText("km");

            IWebElement pace = _driver.FindElement(By.ClassName("pace_type"));
            SelectElement oSelectPace = new SelectElement(pace);
            oSelectPace.SelectByText("km");

            IWebElement calculateButton = _driver.FindElement(By.ClassName("btn btn-medium-yellow calculate-btn"));
            calculateButton.Click();

            IWebElement actualResult = _driver.FindElement(By.ClassName("pace_minutes"));
            Assert.AreEqual(expectedResult, actualResult.Text, "Pace incorrect");

        }
    }
}
