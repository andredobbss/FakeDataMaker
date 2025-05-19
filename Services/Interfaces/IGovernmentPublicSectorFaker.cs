using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IGovernmentPublicSectorFaker
{
    Task<IEnumerable<GovernmentPublicSectorModel>> GeneratePublicSectorAsync(int quantity, string language);
}
