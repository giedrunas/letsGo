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
    class DesktopDownloadPage
    {
        private static IWebDriver _driver;

        private IWebElement _clickToExpandAll => _driver.FindElement(By.XPath(".//*[@class='rct-option rct-option-expand-all']"));
        private IWebElement _desktopCheckBox => _driver.FindElement(By.CssSelector("#tree-node > ol > .rct-node > ol > .rct-node:nth-child(1) > .rct-text .rct-checkbox > .rct-icon"));
        private IWebElement _downloadCheckBox => _driver.FindElement(By.CssSelector(".rct-node-parent:nth-child(3) > .rct-text .rct-checkbox > .rct-icon"));
        private IWebElement _youHaveSelected => _driver.FindElement(By.Id("result"));

        public DesktopDownloadPage(IWebDriver webdriver)
        {
            _driver = webdriver;
        }

        public void ExpandAll()
        {
            _clickToExpandAll.Click();

        }

        public void ClickDesktopCheckBox()
        {
            _desktopCheckBox.Click();
        }
        public void ClickDownloadCheckBox()
        {
            _downloadCheckBox.Click();
        }

        public void VerifySelectedResult(string expectedResult)
        {
            Assert.AreEqual($"{expectedResult}", _youHaveSelected.Text, "Result is wrong");
        }
    }
}