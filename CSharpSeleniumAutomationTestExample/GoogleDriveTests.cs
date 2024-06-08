using CSharpSeleniumAutomationTestExample.PageObjects.FormRelatedObjects;
using NUnit.Framework;

namespace CSharpSeleniumAutomationTestExample
{
    public class GoogleDriveTests : BaseClass
    {
        private CreateFormPage _formPage;
        private AnswerFormPage _answerFormPage;
        private string _formURL;

        [SetUp]
        public void GoogleDriveTestSetup()
        {
            _formPage = new CreateFormPage();
            _answerFormPage = new AnswerFormPage();
        }

        [Test]
        [Order(1)]
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
            _formPage.MakeQuestionRequired();
            _formPage.ClickOnAddQuestionButton();
            _formPage.ClickOnQuestionTypeDropdown();
            _formPage.ChooseDropdownQuestionType();
            _formPage.EnterQuestionTitle("Dropdown Question");
            _formPage.AddNewOptionToQuestion();
            _formPage.AddNewOptionToQuestion();
            _formPage.EditQuestionAnswerOption(1, "First dropdown option");
            _formPage.EditQuestionAnswerOption(2, "Second dropdown option");
            _formPage.EditQuestionAnswerOption(3, "Third dropdown option");
            _formPage.MakeQuestionRequired();
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
            _formPage.MakeQuestionRequired();
            _formPage.ClickOnSendFormButton();

            _formPage.SendFormWindow.ClickOnSendFormViaLinkOption();
            _formPage.SendFormWindow.ClickOnShortenURLCheckbox();
            _formURL = _formPage.SendFormWindow.GetFormShareURL();
        }

        [Test]
        [Order(2)]
        public void AnswerOnGoogleForm()
        {
            _formPage.OpenGoogleForm(_formURL);
            _answerFormPage.SelectCheckboxAnswerInQuestion(1, 1);
            _answerFormPage.SelectCheckboxAnswerInQuestion(1, 3);
            _answerFormPage.SelectRadiobuttonAnswerInQuestion(4, 2);
            _answerFormPage.ClickOnSubmitFormButton();
            _answerFormPage.AssertThatQuestionRequiredInfoIsVisible(2);
            _answerFormPage.SelectDropdownOptionInQuestion(2, 3);
        }
    }
}