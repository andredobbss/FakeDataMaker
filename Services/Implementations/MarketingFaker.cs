using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class MarketingFaker : IMarketingFaker
{
    public async Task<IEnumerable<MarketingModel>> GenerateMarketingAsync(int quantity, string language)
    {
        var faker = new Faker<MarketingModel>(language).StrictMode(true)
            .RuleFor(x => x.CampaignName, f => f.Company.CatchPhrase())
            .RuleFor(x => x.Channel, f => f.PickRandom("Email", "Social Media", "TV", "Radio", "Web"))
            .RuleFor(x => x.TargetAudience, f => f.Commerce.Department())
            .RuleFor(x => x.ManagerName, f => f.Name.FullName())
            .RuleFor(x => x.StartDate, f => f.Date.Past(1))
            .RuleFor(x => x.EndDate, (f, x) => x.StartDate.AddDays(f.Random.Number(10, 90)))
            .RuleFor(x => x.Budget, f => f.Finance.Amount(1000, 100000))
            .RuleFor(x => x.Impressions, f => f.Random.Number(10000, 1000000))
            .RuleFor(x => x.Clicks, f => f.Random.Number(1000, 50000))
            .RuleFor(x => x.ConversionRate, f => f.Random.Decimal(0.5m, 10.0m))
            .RuleFor(x => x.Status, f => f.PickRandom("Planned", "Running", "Completed", "Cancelled"))
            .RuleFor(x => x.Region, f => f.Address.Country())
            .RuleFor(x => x.Objective, f => f.PickRandom("Brand Awareness", "Lead Generation", "Sales"))
            .RuleFor(x => x.IsA_BTested, f => f.Random.Bool())
            .RuleFor(x => x.ContentFormat, f => f.PickRandom("Video", "Image", "Text", "Interactive"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
