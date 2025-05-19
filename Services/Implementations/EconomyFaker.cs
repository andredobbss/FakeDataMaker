using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class EconomyFaker : IEconomyFaker
{
    public async Task<IEnumerable<EconomyModel>> GenerateaEconomyAsync(int quantity, string language)
    {
        var faker = new Faker<EconomyModel>(language).StrictMode(true)
             .RuleFor(x => x.Country, f => f.Address.Country())
             .RuleFor(x => x.Currency, f => f.Finance.Currency().Description)
             .RuleFor(x => x.GDP, f => f.Random.Decimal(100_000_000_000, 10_000_000_000_000))
             .RuleFor(x => x.InflationRate, f => f.Random.Decimal(-2, 15))
             .RuleFor(x => x.UnemploymentRate, f => f.Random.Decimal(0, 25))
             .RuleFor(x => x.LastUpdate, f => f.Date.Recent(90))
             .RuleFor(x => x.EconomicSector, f => f.PickRandom("Industry", "Services", "Agriculture"))
             .RuleFor(x => x.MainExport, f => f.Commerce.ProductName())
             .RuleFor(x => x.MainImport, f => f.Commerce.ProductName())
             .RuleFor(x => x.DebtToGDP, f => f.Random.Decimal(10, 200))
             .RuleFor(x => x.EconomicOutlook, f => f.PickRandom("Stable", "Positive", "Negative", "Uncertain"))
             .RuleFor(x => x.InterestRate, f => f.Random.Decimal(0, 20))
             .RuleFor(x => x.CreditRating, f => f.PickRandom("AAA", "AA", "A", "BBB", "BB", "B", "CCC", "D"))
             .RuleFor(x => x.CentralBank, f => $"Central Bank of {f.Address.Country()}")
             .RuleFor(x => x.ExchangeRegime, f => f.PickRandom("Floating", "Fixed", "Pegged", "Managed Float"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
