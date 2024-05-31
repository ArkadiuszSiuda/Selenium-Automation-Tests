using CSharpSeleniumAutomationTestExample.PageObjects;
using NUnit.Framework;

namespace CSharpSeleniumAutomationTestExample
{
    public class GoogleDriveTests : BaseClass
    {
        private MainPage _mainPage;
        private FormPage _formPage;

        [SetUp]
        public void GoogleDriveTestSetup()
        {
            _mainPage = new MainPage();
            _formPage = new FormPage();
        }

        [Test]
        public void CreateGoogleForm()
        {
            _mainPage.ClickOnNewButton();
            _mainPage.ChooseGoogleFormsOptionFromDropdown();
            _formPage.SwitchToLastOpenedWindow();
            _formPage.EnterFormTitle(GenerateInputData.Title());
            _formPage.ClickOnNotActiveQuestion();
            _formPage.DeleteQuestion();
        }
    }
}