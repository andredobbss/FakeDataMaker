using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IEnvironmentalServiceFaker
{
    Task<IEnumerable<EnvironmentalServiceModel>> GenerateEnvironmentalServicesAsync(int quantity, string language);
}
