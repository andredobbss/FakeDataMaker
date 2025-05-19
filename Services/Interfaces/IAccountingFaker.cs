using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAccountingFaker
{
    Task<IEnumerable<AccountingModel>> GenerateAccountingAsync(int quantity, string language);
}
