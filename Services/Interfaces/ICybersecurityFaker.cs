using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface ICybersecurityFaker
{
    Task<IEnumerable<CybersecurityModel>> GenerateCybersecurityAsync(int quantity, string language);
}
