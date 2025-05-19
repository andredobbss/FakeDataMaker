using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IEcommerceFaker
{
    Task<IEnumerable<EcommerceModel>> GenerateEcommerceAsync(int quantity, string language);
}
