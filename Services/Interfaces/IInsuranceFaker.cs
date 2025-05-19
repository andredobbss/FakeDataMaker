using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IInsuranceFaker
{
    Task<IEnumerable<InsuranceModel>> GenerateInsuranceAsync(int quantity, string language);
}
