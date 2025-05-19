using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface ICivilConstructionFaker
{
    Task<IEnumerable<CivilConstructionModel>> GenerateCivilConstructionAsync(int quantity, string language);
}
