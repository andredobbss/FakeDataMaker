using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class InsuranceFaker : IInsuranceFaker
{
    public async Task<IEnumerable<InsuranceModel>> GenerateInsuranceAsync(int quantity, string language)
    {
       var Faker = new Bogus.Faker<InsuranceModel>(language).StrictMode(true)
            .RuleFor(x => x.Id, f => Guid.NewGuid())
            .RuleFor(x => x.PolicyNumber, f => f.Random.AlphaNumeric(10).ToUpper())
            .RuleFor(x => x.HolderName, f => f.Name.FullName())
            .RuleFor(x => x.InsuranceType, f => f.PickRandom("Health", "Auto", "Home", "Life", "Travel"))
            .RuleFor(x => x.PremiumAmount, f => f.Random.Decimal(100, 10000))
            .RuleFor(x => x.CoverageLimit, f => f.Random.Decimal(1000, 100000))
            .RuleFor(x => x.ProviderName, f => f.Company.CompanyName())
            .RuleFor(x => x.StartDate, f => f.Date.Past(1))
            .RuleFor(x => x.EndDate, (f, x) => x.StartDate.AddYears(f.Random.Int(1, 5)))
            .RuleFor(x => x.Status, f => f.PickRandom("Active", "Expired", "Pending", "Cancelled"))
            .RuleFor(x => x.ContactEmail, f => f.Internet.Email())
            .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumberFormat())
            .RuleFor(x => x.Address, f => f.Address.FullAddress())
            .RuleFor(x => x.IsAutoRenewal, f => f.Random.Bool())
            .RuleFor(x => x.AgentName, f => $"{f.Name.FirstName()} {f.Name.LastName()}");

        return await Task.FromResult(Faker.Generate(quantity));
    }
}
