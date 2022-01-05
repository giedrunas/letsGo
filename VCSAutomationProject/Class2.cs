using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutomationProject
{
    class Class2
    { 
        private static IWebDriver driver; 
   
    [OneTimeSetUp]
    
    public void SetUp()
    {
        driver = new ChromeDriver();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Manage().Window.Maximize();
        driver.Url = "https://testpages.herokuapp.com/styled/calculator";
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        driver.Close();
    }


    [TestCase("2", "2", "4", TestName = "2 + 2 = 4")]
    [TestCase("-5", "3", "-2", TestName = "-5 + 3 = -2")]
    [TestCase("a", "b", "ERR", TestName = "a + b = ERR")]
        public static void TestSumBlock1(string firstInputValue, string secondInputValue, string expectedResult)
        {
          
            IWebElement firstInput = driver.FindElement(By.Id("number1"));
            IWebElement secondInput = driver.FindElement(By.Id("number2"));

            firstInput.Clear();
            firstInput.SendKeys(firstInputValue);
            secondInput.Clear();
            secondInput.SendKeys(secondInputValue);

            IWebElement calculateButton = driver.FindElement(By.Id("calculate"));
            calculateButton.Click();

            IWebElement actualResult = driver.FindElement(By.Id("answer"));
            Assert.AreEqual(expectedResult, actualResult.Text, "Sum is Incorrect");

        }
        

    }
}
