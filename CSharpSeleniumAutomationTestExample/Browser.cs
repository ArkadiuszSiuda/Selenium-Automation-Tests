using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace CSharpSeleniumAutomationTestExample;
public static class Browser
{
    public static IWebDriver Driver { get; }
    public static Actions Actions { get; }

    static Browser()
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
}
