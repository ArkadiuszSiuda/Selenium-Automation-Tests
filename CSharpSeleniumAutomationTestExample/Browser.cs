using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace CSharpSeleniumAutomationTestExample;
public class Browser
{
    public static Browser Instance { get; } = new Browser();
    public IWebDriver Driver { get; set; }
    public Actions Actions { get; set; }

    public void Start()
    {
        var options = new ChromeOptions();

        options.AddArguments("disable-infobars");
        options.AddArguments("--disable-extensions");
        options.AddArguments("--disable-gpu");
        options.AddArguments("--disable-dev-shm-usage");
        options.AddArguments("--no-sandbox");
        options.AddArguments("start-maximized");

        Driver = new ChromeDriver(options);
        Actions = new Actions(Driver);
    }

    public void Stop()
    {
        Instance.Driver.Quit();
    }
}
