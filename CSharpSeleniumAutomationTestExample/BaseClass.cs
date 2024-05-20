using NUnit.Framework;
using Microsoft.Extensions.Configuration;
using CSharpSeleniumAutomationTestExample.PageObjects;
using OpenQA.Selenium;

namespace CSharpSeleniumAutomationTestExample
{
    public class BaseClass
    {
        private LoginPage _loginPage;
        private IConfiguration _settings;

        [SetUp]
        public void SetUp()
        {
            _loginPage = new LoginPage();
            _settings = GetConfig();
            _loginPage.LogInToGoogleDrive(_settings["UserCredentails:Email"], _settings["UserCredentails:Password"]);
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Driver.Quit();
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
