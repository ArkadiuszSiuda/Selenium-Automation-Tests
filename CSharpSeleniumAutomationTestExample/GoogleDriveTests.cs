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
            _formPage.ClickOnNotActiveQuestion(1);
            _formPage.DeleteQuestion();
            _formPage.ClickOnAddQuestionButton();
            _formPage.ClickOnQuestionTypeDropdown();
            _formPage.ChooseCheckboxQuestionType();
            _formPage.EnterQuestionTitle("Checkbox Question");
            _formPage.AddNewOptionToQuestion();
            _formPage.AddNewOptionToQuestion();
             _formPage.EditQuestionAnswerOption(1, "First checkbox");
            _formPage.EditQuestionAnswerOption(2, "Second checkbox");
            _formPage.EditQuestionAnswerOption(3, "Third checkbox");
            _formPage.ClickOnAddQuestionButton();
            _formPage.ClickOnQuestionTypeDropdown();
            _formPage.ChooseDropdownQuestionType();
            _formPage.EnterQuestionTitle("Dropdown Question");
            _formPage.AddNewOptionToQuestion();
            _formPage.AddNewOptionToQuestion();
            _formPage.EditQuestionAnswerOption(1, "First dropdown option");
            _formPage.EditQuestionAnswerOption(2, "Second dropdown option");
            _formPage.EditQuestionAnswerOption(3, "Third dropdown option");
            _formPage.ClickOnAddQuestionButton();
            _formPage.ClickOnQuestionTypeDropdown();
            _formPage.ChooseFileUploadQuestionType();
            _formPage.EnterQuestionTitle("FileUpload Question");
            _formPage.ClickOnAddQuestionButton();
            _formPage.EnterQuestionTitle("Radiobutton Question");
            _formPage.AddNewOptionToQuestion();
            _formPage.AddNewOptionToQuestion();
            _formPage.EditQuestionAnswerOption(1, "First radiobutton");
            _formPage.EditQuestionAnswerOption(2, "Second radiobutton");
            _formPage.EditQuestionAnswerOption(3, "Third radiobutton");
        }
    }
}