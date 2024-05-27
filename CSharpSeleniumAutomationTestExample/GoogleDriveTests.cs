using CSharpSeleniumAutomationTestExample.PageObjects;
using NUnit.Framework;

namespace CSharpSeleniumAutomationTestExample
{
    public class GoogleDriveTests : BaseClass
    {
        private MainPage _mainPage;

        [SetUp]
        public void GoogleDriveTestSetup()
        {
            _mainPage = new MainPage();
        }

        [Test]
        public void Test()
        {
            _mainPage.ClickOnNewButton();
            _mainPage.ChooseGoogleFormsOptionFromDropdown();
        }
    }
}