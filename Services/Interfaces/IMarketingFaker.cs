using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IMarketingFaker
{
    Task<IEnumerable<MarketingModel>> GenerateMarketingAsync(int quantity, string language);
}
