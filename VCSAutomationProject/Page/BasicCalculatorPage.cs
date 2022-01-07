using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSAutomationProject.Page
{
    class BasicCalculatorPage
    {
        private static IWebDriver _driver;

        private IWebElement _firstInput => _driver.FindElement(By.Id("number1Field"));
        private IWebElement _secondInput => _driver.FindElement(By.Id("number2Field"));
        private IWebElement _intOnlyCheckBox => _driver.FindElement(By.Id("integerSelect"));
        private IWebElement _calculateButton => _driver.FindElement(By.Id("calculateButton"));
        private IWebElement _actualResult => _driver.FindElement(By.Id("numberAnswerField"));

        public BasicCalculatorPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public BasicCalculatorPage EnterFirstInputField(string firstValue)
        {
            _firstInput.Clear();
            _firstInput.SendKeys(firstValue);

            return this;
        }

        public BasicCalculatorPage EnterSecondInputValue(string secondValue)
        {
            _secondInput.Clear();
            _secondInput.SendKeys(secondValue);

            return this;
        }

        public BasicCalculatorPage EnterBothValues(string firstValue, string secondValue)
        {
            EnterFirstInputField(firstValue);
            EnterSecondInputValue(secondValue);

            return this;
        }

        public BasicCalculatorPage CheckIfIntegersOnly(bool shouldBeChecked)
        {
            if (_intOnlyCheckBox.Selected != shouldBeChecked)
            {
                _intOnlyCheckBox.Click();
            }

            return this;
        }

        public BasicCalculatorPage ClickCalculateButton()
        {
            _calculateButton.Click();

            return this;
        }

        public BasicCalculatorPage VerifyResult(string result)
        {
            Assert.AreEqual(result, _actualResult.GetAttribute("value"), "Calculation is Incorrect");

            return this;
        }

    }
}