using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class SportsRecreationFaker : ISportsRecreationFaker
{
    public async Task<IEnumerable<SportsRecreationModel>> GenerateSportsDataAsync(int quantity, string language)
    {
        var faker = new Faker<SportsRecreationModel>(language)
            .RuleFor(x => x.OrganizationId, f => f.Random.Guid().ToString())
            .RuleFor(x => x.OrganizationName, f => f.Company.CompanyName() + " Sports Club")
            .RuleFor(x => x.SportType, f => f.PickRandom("Football", "Basketball", "Tennis", "Swimming", "Cycling", "Athletics", "Gymnastics"))
            .RuleFor(x => x.Country, f => f.Address.Country())
            .RuleFor(x => x.City, f => f.Address.City())
            .RuleFor(x => x.FacilityName, f => f.Company.CompanyName() + " Arena")
            .RuleFor(x => x.Capacity, f => f.Random.Int(100, 50000))
            .RuleFor(x => x.EstablishedDate, f => f.Date.Past(70))
            .RuleFor(x => x.Director, f => f.Name.FullName())
            .RuleFor(x => x.ContactEmail, f => f.Internet.Email())
            .RuleFor(x => x.Phone, f => f.Phone.PhoneNumberFormat())
            .RuleFor(x => x.Website, f => f.Internet.Url())
            .RuleFor(x => x.AnnualRevenueUSD, f => f.Finance.Amount(100000, 10000000))
            .RuleFor(x => x.IsPublic, f => f.Random.Bool())
            .RuleFor(x => x.Status, f => f.PickRandom("Active", "Inactive", "Under Renovation"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}

