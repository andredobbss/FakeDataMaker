namespace FakeDataMaker.Helpers;

public static class ReplaceLanguageHelper
{
    public static string ReplaceLanguage(this string text, string language)
    {
        if (language.Contains("_"))
        {
            language = language.Replace("_", "-");
            return language;
        }
        else
        {
            return language;
        }                
    }
}
