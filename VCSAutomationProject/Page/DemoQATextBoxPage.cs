using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutomationProject.Page
{
    class DemoQATextBoxPage
    {
        private static IWebDriver _driver;
        
        private IWebElement _fullNameInputField => _driver.FindElement(By.Id("userName"));
        private IWebElement _submitButton => _driver.FindElement(By.Id("submit"));
        private IWebElement _fullNameActualResult => _driver.FindElement(By.Id("name"));

        public DemoQATextBoxPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void InsertTextFullNameField(string text)
        {
            _fullNameInputField.Clear();
            _fullNameInputField.SendKeys(text);
        }

        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }

        public void VerifyFullNameResult(string expectedResult)
        {
            Assert.AreEqual($"Name:{expectedResult}", _fullNameActualResult.Text, "Name is wrong");
        }

        //IWebDriver driver = new ChromeDriver();
        //driver.Url = "https://demoqa.com/text-box";

        //    IWebElement fullNameInputField = driver.FindElement(By.Id("userName"));
        //fullNameInputField.SendKeys("Giedrius Pavalkis");

        //    IWebElement submitButton = driver.FindElement(By.Id("submit"));
        //submitButton.Click();

        //    IWebElement newName = driver.FindElement(By.Id("name"));
        //Assert.AreEqual("Name:Giedrius Pavalkis", newName.Text, "Name is wrong");
    }
}
