using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAgricultureFaker
{
    Task<IEnumerable<AgricultureModel>> GenerateAgricultureAsync(int quantity, string language);
}
