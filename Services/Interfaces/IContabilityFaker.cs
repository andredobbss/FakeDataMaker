using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IContabilityFaker
{
    Task<IEnumerable<ContabilityModel>> GenerateContabilityAsync(int quantity, string language);
}
