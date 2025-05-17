using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class AccountingFaker : IAccountingFaker
{
    public IEnumerable<AccountingModel> GenerateAccounting(int quantity, string language)
    {      
        var faker = new Faker<AccountingModel>(language)      
       .RuleFor(a => a.ClientName, f => f.Company.CompanyName())
       .RuleFor(a => a.AccountNumber, f => f.Finance.Account())
       .RuleFor(a => a.AccountType, f => f.PickRandom("Checking", "Savings", "Business"))
       .RuleFor(a => a.AccountBalance, f => f.Finance.Amount(1000, 100000))
       .RuleFor(a => a.OpeningDate, f => f.Date.Past(10))
       .RuleFor(a => a.LastTransactionDate, f => f.Date.Recent(30))
       .RuleFor(a => a.Currency, f => f.Finance.Currency().Code)
       .RuleFor(a => a.TaxId, f => f.Company.Bs())
       .RuleFor(a => a.Country, f => f.Address.Country())
       .RuleFor(a => a.AccountantName, f => f.Name.FullName())
       .RuleFor(a => a.AnnualRevenue, f => f.Finance.Amount(50000, 1000000))
       .RuleFor(a => a.MonthlyExpenses, f => f.Finance.Amount(1000, 50000))
       .RuleFor(a => a.LedgerType, f => f.PickRandom("General", "Purchase", "Sales", "Cash"))
       .RuleFor(a => a.Status, f => f.PickRandom("Active", "Inactive", "Pending"))
       .RuleFor(a => a.Notes, f => f.Lorem.Sentence());

        return faker.Generate(quantity);
    }
}
