using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IEconomyFaker
{
    Task<IEnumerable<EconomyModel>> GenerateaEconomyAsync(int quantity, string language);
}
