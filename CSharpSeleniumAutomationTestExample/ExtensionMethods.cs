namespace CSharpSeleniumAutomationTestExample;
public static class ExtensionMethods
{
    public static void IsElementVisible(this bool value)
    {
        if (!value)
        {
            throw new Exception("Element was not visible");
        }
    }
}
