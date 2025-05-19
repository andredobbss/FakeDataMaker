using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAutomotiveFaker
{
    Task<IEnumerable<AutomotiveModel>> GenerateAutomotiveAsync(int quantity, string language);
}
