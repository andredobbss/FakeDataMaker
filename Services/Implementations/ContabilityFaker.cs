using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class ContabilityFaker : IContabilityFaker
{
    public async Task<IEnumerable<ContabilityModel>> GenerateContabilityAsync(int quantity, string language)
    {
        var faker = new Faker<ContabilityModel>(language).StrictMode(true)
            .RuleFor(x => x.AccountName, f => f.Company.CompanyName())
            .RuleFor(x => x.AccountNumber, f => f.Finance.Account())
            .RuleFor(x => x.Balance, f => f.Finance.Amount(1000, 100000))
            .RuleFor(x => x.LastTransactionDate, f => f.Date.Recent(60))
            .RuleFor(x => x.Currency, f => f.Finance.Currency().Code)
            .RuleFor(x => x.TransactionType, f => f.PickRandom("Credit", "Debit", "Transfer"))
            .RuleFor(x => x.Department, f => f.Commerce.Department())
            .RuleFor(x => x.ResponsiblePerson, f => f.Name.FullName())
            .RuleFor(x => x.Description, f => f.Lorem.Sentence())
            .RuleFor(x => x.Status, f => f.PickRandom("Open", "Closed", "Pending"))
            .RuleFor(x => x.CostCenter, f => $"CC-{f.Random.Number(1000, 9999)}")
            .RuleFor(x => x.CreatedAt, f => f.Date.Past(3))
            .RuleFor(x => x.AnnualBudget, f => f.Finance.Amount(50000, 500000))
            .RuleFor(x => x.FiscalYear, f => f.Date.Past().Year)
            .RuleFor(x => x.IsActive, f => f.Random.Bool());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
