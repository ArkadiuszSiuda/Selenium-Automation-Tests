namespace CSharpSeleniumAutomationTestExample.PageObjects.FormRelatedObjects;
public class FormPage : CommonMethods
{
    private string _activeQuestionXpath = "//div[@data-item-id and @data-observe-selection and descendant::*[contains(@style,'background-color: #4285f4')]]";
    private string _notActiveQuestionXpath = "//div[@data-item-id and @data-observe-selection and not(descendant::*[(contains(@style,'background-color'))])]";
    private string _deleteButtonXpath = "//*[@data-tooltip='Delete']";
    private string _formTitleXpath = "//div[@aria-label='Form title']";
    private string _addQuestionButtonXpath = "//div[@aria-label='Add question']";
    private string _questionTypeDropdown = "//div[@aria-label='Question types']";
    private string _dropdownQuestionOption = "//div[@role='option' and contains(normalize-space(.),'Dropdown')]";
    private string _checkboxQuestionOption = "//div[@role='option' and contains(normalize-space(.),'Checkbox')]";
    private string _fileUploadQuestionOption = "//div[@role='option' and contains(normalize-space(.),'File upload')]";
    private string _formSavingInProgressStatus = "//div[contains(@aria-label,'Saving')]";
    private string _fileUploadQuestionContinueButton = "//div[@role='button' and descendant::*[normalize-space(text())='Continue']]";
    private string _questionTitleTextbox = "//div[@role='textbox' and @aria-label='Question']";
    private string _addOptionTextbox = "//input[@aria-label='Add option']";
    private string _questionRequiredSliderXpath = "//div[@aria-label='Required']";
    private string _sendFormButtonXpath = "//div[@role='button' and descendant::*[normalize-space(text())='Send']]";

    public SendFormWindow SendFormWindow { get; set; }

    public FormPage()
    {
        SendFormWindow = new SendFormWindow();
    }


    public void DeleteQuestion()
    {
        Click(_activeQuestionXpath);
        Click(_activeQuestionXpath + _deleteButtonXpath);
    }
    public void EnterFormTitle(string title) => TypeTextWihtoutBackspace(_formTitleXpath, title);
    public void ClickOnNotActiveQuestion(int questionNumber) => Click(_notActiveQuestionXpath + $"[{questionNumber}]");
    public void ClickOnAddQuestionButton() => Click(_addQuestionButtonXpath);
    public void ClickOnQuestionTypeDropdown() => Click(_activeQuestionXpath + _questionTypeDropdown);
    public void ChooseDropdownQuestionType()
    {
        Click(_activeQuestionXpath + _questionTypeDropdown + _dropdownQuestionOption);
        AssertThatElementIsNotVisible(_formSavingInProgressStatus);
    }
    public void ChooseCheckboxQuestionType()
    {
        Click(_activeQuestionXpath + _questionTypeDropdown + _checkboxQuestionOption);
        AssertThatElementIsNotVisible(_formSavingInProgressStatus);
    }
    public void ChooseFileUploadQuestionType()
    {
        Click(_activeQuestionXpath + _questionTypeDropdown + _fileUploadQuestionOption);
        Click(_fileUploadQuestionContinueButton);
        AssertThatElementIsNotVisible(_formSavingInProgressStatus);
    }
    public void EnterQuestionTitle(string text) => TypeText(_activeQuestionXpath + _questionTitleTextbox, text);
    public void AddNewOptionToQuestion()
    {
        Click(_activeQuestionXpath + _addOptionTextbox);
        AssertThatElementIsNotVisible(_formSavingInProgressStatus);
    }
    public void EditQuestionAnswerOption(int optionNumber, string optionText) => TypeText(_activeQuestionXpath + $"//input[@value='Option {optionNumber}']", optionText);
    public void MakeQuestionRequired() => Click(_activeQuestionXpath + _questionRequiredSliderXpath);
    public void ClickOnSendFormButton() => Click(_sendFormButtonXpath);
    public void OpenGoogleForm(string url) => OpenPageByUrl(url);
}
