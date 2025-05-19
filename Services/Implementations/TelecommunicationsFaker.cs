using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class TelecommunicationsFaker : ITelecommunicationsFaker
{
    public async Task<IEnumerable<TelecommunicationsModel>> GenerateTelecommunicationsAsync(int quantity, string language)
    {
        var faker = new Faker<TelecommunicationsModel>(language).StrictMode(true)
           .RuleFor(x => x.CompanyId, f => f.Random.Guid().ToString())
           .RuleFor(x => x.CompanyName, f => f.Company.CompanyName() + " Telecom")
           .RuleFor(x => x.Headquarters, f => f.Address.City())
           .RuleFor(x => x.Country, f => f.Address.Country())
           .RuleFor(x => x.ServiceType, f => f.PickRandom("Mobile", "Internet", "TV", "Satellite", "VoIP"))
           .RuleFor(x => x.CEO, f => f.Name.FullName())
           .RuleFor(x => x.ContactEmail, f => f.Internet.Email())
           .RuleFor(x => x.PhoneSupport, f => f.Phone.PhoneNumber())
           .RuleFor(x => x.Website, f => f.Internet.Url())
           .RuleFor(x => x.FoundedDate, f => f.Date.Past(50))
           .RuleFor(x => x.NumberOfSubscribers, f => f.Random.Int(10000, 100000000))
           .RuleFor(x => x.AnnualRevenueUSD, f => f.Finance.Amount(1_000_000, 100_000_000))
           .RuleFor(x => x.Offers5G, f => f.Random.Bool())
           .RuleFor(x => x.Status, f => f.PickRandom("Active", "Inactive", "Merging"))
           .RuleFor(x => x.NetworkCoverage, f => f.PickRandom("Local", "National", "International"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
