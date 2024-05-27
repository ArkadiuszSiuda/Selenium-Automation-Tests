namespace CSharpSeleniumAutomationTestExample.PageObjects;
public class LoginPage : CommonMethods
{
    private string _googleDriveUrl = "https://drive.google.com";
    private string _idNextButtonXpath = "//div[@id='identifierNext']";
    private string _passwordNextButtonXpath = "//div[@id='passwordNext']";
    private string _goToDriveButtonXpath = "//div[contains(@class,'hero-cta')]//a[@data-action='go to drive']";
    private string _emialTextFieldXpath = "//input[@id='identifierId']";
    private string _passwordTextFieldXpath = "//input[@type='password']";

    public void OpenGoogleDrivePage() => OpenPageByUrl(_googleDriveUrl);
    public void ClickOnGoToDriveButton() => Click(_goToDriveButtonXpath);
    public void ClickOnIdNextButton() => Click(_idNextButtonXpath);
    public void ClickOnPasswordNextButton() => Click(_passwordNextButtonXpath);
    public void EnterEmailIntoTextField(string email) => TypeText(_emialTextFieldXpath, email);
    public void EnterPasswordIntoTextField(string password) => TypeText(_passwordTextFieldXpath, password);

    public void LogInToGoogleDrive(string email, string password)
    {
        OpenGoogleDrivePage();
        ClickOnGoToDriveButton();
        SwitchToLastOpenedWindow();
        EnterEmailIntoTextField(email);
        ClickOnIdNextButton();
        EnterPasswordIntoTextField(password);
        ClickOnPasswordNextButton();
    }
}
