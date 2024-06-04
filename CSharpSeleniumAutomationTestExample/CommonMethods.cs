using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace CSharpSeleniumAutomationTestExample
{
    public class CommonMethods
    {
        private IWebDriver _driver;
        private Actions _action;
        private WebDriverWait _wait;

        public CommonMethods()
        {
            _driver = Browser.Driver;
            _action = Browser.Actions;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(15));
        }

        public void Click(string xpath)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            var element = _driver.FindElement(By.XPath(xpath));
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView({ behavior: 'instant', block: 'center' });", element);
            element.Click();
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
            _action.DoubleClick(_driver.FindElement(By.XPath(xpath))).Perform();
            _action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).SendKeys(Keys.Backspace).Build().Perform();
            _driver.FindElement(By.XPath(xpath)).SendKeys(text);
        }

        public void TypeTextWihtoutBackspace(string xpath, string text)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            _action.DoubleClick(_driver.FindElement(By.XPath(xpath))).Perform();
            _action.KeyDown(Keys.Control).SendKeys("a").KeyUp(Keys.Control).Build().Perform();
            _driver.FindElement(By.XPath(xpath)).SendKeys(text);
        }

        public void OpenPageByUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void AssertThatElementIsVisible(string xpath)
        {
            _wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            _driver.IsElementVisible(By.XPath(xpath)).AssertThatValueIsTrue();
        }

        public void AssertThatElementIsNotVisible(string xpath)
        {
            _wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.XPath(xpath)));
            _driver.IsElementVisible(By.XPath(xpath)).AssertThatValueIsFalse();
        }
    }
}
