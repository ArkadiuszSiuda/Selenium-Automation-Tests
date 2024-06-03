namespace CSharpSeleniumAutomationTestExample.PageObjects;
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

    public void DeleteQuestion()
    {
        Click(_activeQuestionXpath);
        Click(_activeQuestionXpath + _deleteButtonXpath);
    } 
    public void EnterFormTitle(string title) => TypeText(_formTitleXpath, title);
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
}
