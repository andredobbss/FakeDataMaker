using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class FinanceFaker : IFinanceFaker
{
    public async Task<IEnumerable<FinanceModel>> GenerateFinanceAsync(int quantity, string language)
    {
        var faker = new Faker<FinanceModel>(language).StrictMode(true)
           .RuleFor(x => x.AccountHolderName, f => f.Name.FullName())
           .RuleFor(x => x.AccountNumber, f => f.Finance.Account())
           .RuleFor(x => x.BankName, f => f.Company.CompanyName())
           .RuleFor(x => x.AccountType, f => f.PickRandom("Checking", "Savings", "Business"))
           .RuleFor(x => x.Currency, f => f.Finance.Currency().Code)
           .RuleFor(x => x.Balance, f => f.Finance.Amount(500, 100000))
           .RuleFor(x => x.MonthlyIncome, f => f.Finance.Amount(2000, 15000))
           .RuleFor(x => x.MonthlyExpense, f => f.Finance.Amount(1000, 12000))
           .RuleFor(x => x.InvestmentType, f => f.PickRandom("Stocks", "Bonds", "Mutual Funds", "Real Estate"))
           .RuleFor(x => x.InvestmentAmount, f => f.Finance.Amount(1000, 50000))
           .RuleFor(x => x.CreditScoreCategory, f => f.PickRandom("Excellent", "Good", "Fair", "Poor"))
           .RuleFor(x => x.CreditScore, f => f.Random.Int(300, 850))
           .RuleFor(x => x.AccountOpenedDate, f => f.Date.Past(10))
           .RuleFor(x => x.LastTransactionDate, f => f.Date.Recent(30))
           .RuleFor(x => x.FinancialAdvisor, f => f.Name.FullName());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
