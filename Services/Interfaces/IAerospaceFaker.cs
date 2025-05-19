using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAerospaceFaker
{
    Task<IEnumerable<AerospaceModel>> GenerateAerospaceAsync(int quantity, string language);
}
