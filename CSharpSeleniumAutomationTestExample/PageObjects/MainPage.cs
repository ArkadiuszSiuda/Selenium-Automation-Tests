namespace CSharpSeleniumAutomationTestExample.PageObjects;
public class MainPage : CommonMethods
{
    private string _welcomeToDriveTitleXpath = "//div[@class='dsnh2d' and descendant::span[text()='Welcome to Drive']]";
    private string _newButtonXpath = "//button[descendant::*[normalize-space(text())='New'] and @aria-disabled='false']";
    private string _googleFormsDropdownOptionXpath = "//div[descendant::*[normalize-space(text())='Google Forms'] and @role='menuitem']";

    public void AssertThatWelcomeToDriveTitleIsVisible() => AssertThatElementIsVisible(_welcomeToDriveTitleXpath);
    public void ClickOnNewButton() => Click(_newButtonXpath);
    public void ChooseGoogleFormsOptionFromDropdown() => Click(_googleFormsDropdownOptionXpath);
    public void SwitchToFormWindow() => SwitchToLastOpenedWindow();
}
