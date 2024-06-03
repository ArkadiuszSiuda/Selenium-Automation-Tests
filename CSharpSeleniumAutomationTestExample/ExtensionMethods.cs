using OpenQA.Selenium;

namespace CSharpSeleniumAutomationTestExample;
public static class ExtensionMethods
{
    public static void AssertThatValueIsTrue(this bool value)
    {
        if (!value)
        {
            throw new Exception("Element was visible");
        }
    }

    public static void AssertThatValueIsFalse(this bool value)
    {
        if (value)
        {
            throw new Exception("Element was visible");
        }
    }

    public static bool IsElementVisible(this IWebDriver driver, By by)
    {
        try
        {
            IWebElement element = driver.FindElement(by);
            return element.Displayed;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }
}
