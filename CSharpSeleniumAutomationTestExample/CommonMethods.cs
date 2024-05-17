using OpenQA.Selenium;

namespace CSharpSeleniumAutomationTestExample
{
    public class CommonMethods
    {
        private IWebDriver _driver;

        public CommonMethods(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Click(string xpath)
        {
            _driver.FindElement(By.XPath(xpath)).Click();
        }

        public void SwitchToAnotherWindow(int windowNumber)
        {
            _driver.SwitchTo().Window(_driver.WindowHandles[windowNumber]);
        }

        public void TypeText(string xpath, string text)
        {
            _driver.FindElement(By.XPath(xpath)).SendKeys(text);
        }

        public void OpenPageByUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
    }
}
