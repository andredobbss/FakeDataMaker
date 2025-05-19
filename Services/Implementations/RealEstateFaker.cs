using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class RealEstateFaker : IRealEstateFaker
{
    public async Task<IEnumerable<RealEstateModel>> GenerateRealEstateAsync(int quantity, string language)
    {
        var faker = new Faker<RealEstateModel>(language).StrictMode(true)
        .RuleFor(x => x.PropertyId, f => f.Random.Guid().ToString())
        .RuleFor(x => x.Address, f => f.Address.StreetAddress())
        .RuleFor(x => x.City, f => f.Address.City())
        .RuleFor(x => x.State, f => f.Address.State())
        .RuleFor(x => x.ZipCode, f => f.Address.ZipCode())
        .RuleFor(x => x.PropertyType, f => f.PickRandom("Apartment", "House", "Condo", "Townhouse", "Studio"))
        .RuleFor(x => x.Price, f => f.Finance.Amount(50000, 2000000))
        .RuleFor(x => x.Bedrooms, f => f.Random.Number(1, 6))
        .RuleFor(x => x.Bathrooms, f => f.Random.Number(1, 4))
        .RuleFor(x => x.AreaSquareFeet, f => Math.Round(f.Random.Double(500, 5000), 2))
        .RuleFor(x => x.ListingDate, f => f.Date.Past(1))
        .RuleFor(x => x.AvailableFrom, (f, x) => x.ListingDate.AddDays(f.Random.Number(5, 60)))
        .RuleFor(x => x.AgentName, f => f.Name.FullName())
        .RuleFor(x => x.IsFurnished, f => f.Random.Bool())
        .RuleFor(x => x.Status, f => f.PickRandom("Available", "Pending", "Sold"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
