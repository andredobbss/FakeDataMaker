using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IEducationFaker
{
    Task<IEnumerable<EducationModel>> GenerateEducationAsync(int quantity, string language);
}
