using CSharpSeleniumAutomationTestExample.PageObjects;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace CSharpSeleniumAutomationTestExample
{
    public class BaseClass
    {
        private LoginPage _loginPage;
        protected MainPage _mainPage;
        private IConfiguration _settings;

        [SetUp]
        public void SetUp()
        {
            Browser.Instance.Start();
            _loginPage = new LoginPage();
            _mainPage = new MainPage();
            _settings = GetConfig();
            _loginPage.LogInToGoogleDrive(_settings["UserCredentails:Email"], _settings["UserCredentails:Password"]);
            _mainPage.AssertThatWelcomeToDriveTitleIsVisible();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Instance.Stop();
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
