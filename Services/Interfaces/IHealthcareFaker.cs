using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IHealthcareFaker
{
    Task<IEnumerable<HealthcareModel>> GenerateHealthcareAsync(int quantity, string language);
}
