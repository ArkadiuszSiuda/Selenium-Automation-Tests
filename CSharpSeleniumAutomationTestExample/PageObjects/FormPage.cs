namespace CSharpSeleniumAutomationTestExample.PageObjects;
public class FormPage : CommonMethods
{
    private string _activeQuestionXpath = "//div[@data-item-id and @data-observe-selection and descendant::*[contains(@style,'background-color: #4285f4')]]";
    private string _notActiveQuestionXpath = "//div[@data-item-id and @data-observe-selection and not(descendant::*[(contains(@style,'background-color'))])]";
    private string _deleteButtonXpath = "//*[@data-tooltip='Delete']";
    private string _formTitleXpath = "//div[@aria-label='Form title']";

    public void DeleteQuestion()
    {
        Click(_activeQuestionXpath);
        Click(_activeQuestionXpath + _deleteButtonXpath);
    } 
    public void EnterFormTitle(string title) => TypeText(_formTitleXpath, title);
    public void ClickOnNotActiveQuestion() => Click(_notActiveQuestionXpath);
}
