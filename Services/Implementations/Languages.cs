using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class Languages : ILanguages
{
    public IDictionary<string, string> GetLanguages() => new Dictionary<string, string>
        {
            { "Chinese", "zh_CN" },
            { "English", "en" },
            { "English (Great Britain)" , "en_GB" },
            { "English (United States)", "en_US" },
            { "French", "fr" },
            { "French (Canada)", "fr_CA" },
            { "German", "de" },
            { "Italian", "it" },
            { "Portuguese (Brazil)", "pt_BR" },
            { "Portuguese (Portugal)", "pt_PT" },
            { "Russian", "ru" },
            { "Spanish", "es" },
            { "Spanish (Mexico)", "es_MX" }
        };

}
