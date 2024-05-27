using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CSharpSeleniumAutomationTestExample
{
    public class CommonMethods
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public CommonMethods()
        {
            _driver = Browser.Driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        }

        public void Click(string xpath)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            _driver.FindElement(By.XPath(xpath)).Click();
        }

        public void SwitchToAnotherWindow(int windowNumber)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[windowNumber]);
        }

        public void SwitchToLastOpenedWindow()
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[_driver.WindowHandles.Count - 1]);
        }

        public void TypeText(string xpath, string text)
        {        
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            _driver.FindElement(By.XPath(xpath)).SendKeys(text);
        }

        public void OpenPageByUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void AssertThatElementIsVisible(string xpath)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            _driver.FindElement(By.XPath(xpath)).Displayed.IsElementVisible();
        }
    }
}
