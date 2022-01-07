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
    class CheckBoxClicksPage
    {
        private static IWebDriver _driver;

        private IWebElement _clickToExpandAll => _driver.FindElement(By.XPath(".//*[@class='rct-option rct-option-expand-all']"));
        private IWebElement _commandsCheckBox => _driver.FindElement(By.CssSelector(".rct-node:nth-child(1) > ol > .rct-node:nth-child(1) .rct-node:nth-child(2) .rct-checkbox > .rct-icon"));
        private IWebElement _youHaveSelected => _driver.FindElement(By.ClassName("text-success"));

        public CheckBoxClicksPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void ExpandAll()
        {
            _clickToExpandAll.Click();

        }

        public void ClickCommandCheckBox()
        {
            _commandsCheckBox.Click();
        }

        public void VerifySelectedResult(string expectedResult)
        {
            Assert.AreEqual($"{expectedResult}", _youHaveSelected.Text, "Result is wrong");
        }
    }
}
