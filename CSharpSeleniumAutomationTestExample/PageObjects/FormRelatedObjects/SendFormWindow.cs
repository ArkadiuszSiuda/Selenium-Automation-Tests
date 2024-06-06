namespace CSharpSeleniumAutomationTestExample.PageObjects.FormRelatedObjects;
public class SendFormWindow : CommonMethods
{
    private string _sendFormWindowXpath = "//div[@aria-label='Send form dialog']";
    private string _sendViaLinkOptionXpath = "//div[@aria-label='Send form via link']";
    private string _shortenURLCheckboxXpath = "//div[@aria-label='Shorten URL']";
    private string _formShareLinkTextfieldXpath = "//input[@type='text' and contains(@aria-label,'Link for sharing')]";
    public void ClickOnSendFormViaLinkOption() => Click(_sendFormWindowXpath + _sendViaLinkOptionXpath);
    public void ClickOnShortenURLCheckbox() => Click(_sendFormWindowXpath + _shortenURLCheckboxXpath);
    public string GetFormShareURL() => GetElementAttributeValue(_sendFormWindowXpath + _formShareLinkTextfieldXpath);
}
