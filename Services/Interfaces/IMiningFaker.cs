using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IMiningFaker
{
    Task<IEnumerable<MiningModel>> GenerateMiningAsync(int quantity, string language);
}
