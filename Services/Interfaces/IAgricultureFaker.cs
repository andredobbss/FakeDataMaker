using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAgricultureFaker
{
    IEnumerable<AgricultureModel> GenerateAgriculture(int quantity, string language);
}
