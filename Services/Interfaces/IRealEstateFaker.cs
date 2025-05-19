using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IRealEstateFaker
{
    Task<IEnumerable<RealEstateModel>> GenerateRealEstateAsync(int quantity, string language);
}
