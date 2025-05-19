using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class GovernmentPublicSectorFaker : IGovernmentPublicSectorFaker
{
    public async Task<IEnumerable<GovernmentPublicSectorModel>> GeneratePublicSectorAsync(int quantity, string language)
    {
        var faker = new Faker<GovernmentPublicSectorModel>(language).StrictMode(true)
            .RuleFor(x => x.ProjectCode, f => f.Random.AlphaNumeric(8).ToUpper())
            .RuleFor(x => x.Department, f => f.PickRandom("Health", "Education", "Transportation", "Public Safety", "Infrastructure"))
            .RuleFor(x => x.ProgramName, f => $"Program {f.Company.CatchPhrase()}")
            .RuleFor(x => x.OfficerInCharge, f => f.Name.FullName())
            .RuleFor(x => x.Region, f => f.Address.State())
            .RuleFor(x => x.City, f => f.Address.City())
            .RuleFor(x => x.Category, f => f.PickRandom("Local", "State", "Federal"))
            .RuleFor(x => x.StartDate, f => f.Date.Past(3))
            .RuleFor(x => x.EndDate, (f, x) => x.StartDate.AddDays(f.Random.Int(90, 365)))
            .RuleFor(x => x.AllocatedBudget, f => f.Random.Decimal(50000, 5000000))
            .RuleFor(x => x.StaffCount, f => f.Random.Int(5, 300))
            .RuleFor(x => x.Status, f => f.PickRandom("Planned", "Active", "Paused", "Completed"))
            .RuleFor(x => x.DocumentationUrl, f => f.Internet.UrlWithPath("gov"))
            .RuleFor(x => x.IsFederalFunded, f => f.Random.Bool())
            .RuleFor(x => x.Summary, f => f.Lorem.Sentences(2));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
