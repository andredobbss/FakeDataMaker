using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IManufacturingFaker
{
    Task<IEnumerable<ManufacturingModel>> GenerateManufacturingAsync(int quantity, string language);
}
