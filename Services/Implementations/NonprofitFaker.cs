using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class NonprofitFaker : INonprofitFaker
{
    public async Task<IEnumerable<NonprofitModel>> GenerateNonprofitAsync(int quantity, string language)
    {
        var faker = new Faker<NonprofitModel>(language).StrictMode(true)
            .RuleFor(x => x.OrganizationId, f => f.Random.Guid().ToString())
            .RuleFor(x => x.OrganizationName, f => f.Company.CompanyName() + " Foundation")
            .RuleFor(x => x.Mission, f => f.Company.CatchPhrase())
            .RuleFor(x => x.Country, f => f.Address.Country())
            .RuleFor(x => x.Region, f => f.Address.State())
            .RuleFor(x => x.Sector, f => f.PickRandom("Health", "Education", "Environment", "Human Rights", "Poverty Reduction", "Animal Welfare"))
            .RuleFor(x => x.FoundedDate, f => f.Date.Past(50))
            .RuleFor(x => x.Director, f => f.Name.FullName())
            .RuleFor(x => x.NumberOfVolunteers, f => f.Random.Int(5, 1000))
            .RuleFor(x => x.AnnualBudgetUSD, f => f.Finance.Amount(10000, 5000000))
            .RuleFor(x => x.IsInternational, f => f.Random.Bool())
            .RuleFor(x => x.Website, f => f.Internet.Url())
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.ContactPhone, f => f.Phone.PhoneNumberFormat())
            .RuleFor(x => x.Status, f => f.PickRandom("Active", "Inactive", "Merged", "Closed"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
