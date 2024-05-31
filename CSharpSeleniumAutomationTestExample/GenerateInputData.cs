namespace CSharpSeleniumAutomationTestExample;
public static class GenerateInputData
{
    private const string _digitlettersChars = "123456789qwertyuiopasdfghjklzxcvbnm";

    public static string Title() => GenerateName("FormTitle");

    private static string GenerateName(string nameOfItem, int length = 5)
    {
        return $"{nameOfItem}{RandomStringFromDigitsAndLetters(length)}";
    }

    public static string RandomStringFromDigitsAndLetters(int length)
    {
        return new string(Enumerable.Repeat(_digitlettersChars, length).Select(s => s[new Random().Next(s.Length)]).ToArray());
    }
}
