using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IRetailFaker
{
    Task<IEnumerable<RetailModel>> GenerateRetailAsync(int quantity, string language);
}
