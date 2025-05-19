using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface ISportsRecreationFaker
{
    Task<IEnumerable<SportsRecreationModel>> GenerateSportsDataAsync(int quantity, string language);
}
