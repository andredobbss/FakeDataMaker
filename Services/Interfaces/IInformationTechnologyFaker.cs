using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IInformationTechnologyFaker
{
    Task<IEnumerable<InformationTechnologyModel>> GenerateInformationTechnologyAsync(int quantity, string language);
}
