using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IFinanceFaker
{
    Task<IEnumerable<FinanceModel>> GenerateFinanceAsync(int quantity, string language);
}
