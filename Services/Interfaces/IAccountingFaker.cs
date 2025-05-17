using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAccountingFaker
{
    IEnumerable<AccountingModel> GenerateAccounting(int quantity, string language);
}
