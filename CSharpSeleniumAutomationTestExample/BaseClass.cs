using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Microsoft.Extensions.Configuration;

namespace CSharpSeleniumAutomationTestExample
{
    public class BaseClass
    {
        protected IWebDriver _driver;
        private ChromeOptions _options;
        protected CommonMethods _commonMethods;
        private IConfiguration _settings;

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
            _settings = GetConfig();
            _commonMethods.OpenPageByUrl("https://drive.google.com");
            _commonMethods.Click("//div[contains(@class,'hero-cta')]//a[@data-action='go to drive']");
            _commonMethods.SwitchToAnotherWindow(1);
            _commonMethods.TypeText("//input[@id='identifierId']", _settings["UserCredentails:Email"]);
            _commonMethods.Click("//div[@id='identifierNext']");
            _commonMethods.TypeText("//input[@type='password']", _settings["UserCredentails:Password"]);
            _commonMethods.Click("//div[@id='passwordNext']");
            _commonMethods.AssertThatElementIsVisible("//div[@class='dsnh2d' and descendant::span[text()='Welcome to Drive']]");
        }

        public static IConfiguration GetConfig()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(
                    "appsettings.json",
                    optional: true,
                    reloadOnChange: true);
            return builder.Build();
        }
    }
}
