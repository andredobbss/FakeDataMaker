using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IEnergyFaker
{
    Task<IEnumerable<EnergyModel>> GenerateEnergyAsync(int quantity, string language);
}
