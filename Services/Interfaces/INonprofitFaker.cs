using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface INonprofitFaker
{
    Task<IEnumerable<NonprofitModel>> GenerateNonprofitAsync(int quantity, string language);
}
