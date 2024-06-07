namespace CSharpSeleniumAutomationTestExample.PageObjects.FormRelatedObjects;
public class AnswerFormPage : CommonMethods
{
    private string _questionXpath = "(//div[@class='Qr7Oae'])";
    private string _checkboxXpath = "//div[@role='listitem']";
    private string _radiobuttonXpath = "//div[contains(@class,'nWQGrd')]";
    private string _dropdownXpath = "//div[@role='listbox']";
    private string _dropdownOptionXpath = "//div[@role='option']";
    private string _sumbitFormButtonXpath = "//div[@role='button' and descendant::*[normalize-space(text())='Submit']]";

    public void SelectCheckboxAnswerInQuestion(int questionNumber, int checkboxNumber) => Click(_questionXpath + $"[{questionNumber}]" + _checkboxXpath + $"[{checkboxNumber}]");
    public void SelectRadiobuttonAnswerInQuestion(int questionNumber, int radiobuttonNumber) => Click(_questionXpath + $"[{questionNumber}]" + _radiobuttonXpath + $"[{radiobuttonNumber}]");
    public void SelectDropdownOptionInQuestion(int questionNumber, int dropdownOptionNumber)
    {
        Click(_questionXpath + $"[{questionNumber}]" + _dropdownXpath);
        Click(_dropdownXpath + _dropdownOptionXpath + $"[{dropdownOptionNumber}]");
    }
    public void ClickOnSubmitFormButton() => Click(_sumbitFormButtonXpath);
}
