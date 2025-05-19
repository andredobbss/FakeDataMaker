using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IBiotechnologyFaker
{
    Task<IEnumerable<BiotechnologyModel>> GenerateBiotechnologyAsync(int quantity, string language);
}
