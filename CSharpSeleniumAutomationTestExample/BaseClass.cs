using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace CSharpSeleniumAutomationTestExample
{
    public class BaseClass
    {
        protected IWebDriver _driver;
        private ChromeOptions _options;
        protected CommonMethods _commonMethods;

        [SetUp]
        public void SetUp()
        {
            _options = new ChromeOptions();
            SetBrowserOptions();
            _driver = new ChromeDriver(_options);
            _commonMethods = new CommonMethods(_driver);
            LoginToGoogleDrive();
        }

        public void SetBrowserOptions()
        {
            _options.AddArguments("disable-infobars");
            _options.AddArguments("--disable-extensions");
            _options.AddArguments("--disable-gpu");
            _options.AddArguments("--disable-dev-shm-usage");
            _options.AddArguments("--no-sandbox");
            _options.AddArguments("start-maximized");
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Quit();
        }

        public void LoginToGoogleDrive()
        {
            _commonMethods.OpenPageByUrl("https://drive.google.com");
            _commonMethods.Click("//div[contains(@class,'hero-cta')]//a[@data-action='go to drive']");
            _commonMethods.SwitchToAnotherWindow(1);
            _commonMethods.TypeText("//input[@id='identifierId']", "test95379241@gmail.com");
        }
    }
}
