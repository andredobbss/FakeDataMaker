using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class MiningFaker : IMiningFaker
{
    public async Task<IEnumerable<MiningModel>> GenerateMiningAsync(int quantity, string language)
    {
        var faker = new Faker<MiningModel>(language).StrictMode(true)
            .RuleFor(x => x.OperationId, f => f.Random.Guid().ToString())
            .RuleFor(x => x.SiteName, f => $"Site {f.Address.City()}")
            .RuleFor(x => x.Location, f => $"{f.Address.City()}, {f.Address.Country()}")
            .RuleFor(x => x.ResourceType, f => f.PickRandom("Gold", "Silver", "Iron", "Copper", "Coal", "Lithium"))
            .RuleFor(x => x.ExtractionStartDate, f => f.Date.Past(10))
            .RuleFor(x => x.ExtractionEndDate, (f, u) => f.Random.Bool(0.7f) ? u.ExtractionStartDate.AddMonths(f.Random.Int(1, 24)) : null)
            .RuleFor(x => x.TotalTonnageExtracted, f => f.Random.Int(1000, 500000))
            .RuleFor(x => x.ExtractionCostUSD, f => f.Finance.Amount(500000, 20000000))
            .RuleFor(x => x.Supervisor, f => f.Name.FullName())
            .RuleFor(x => x.EquipmentUsed, f => f.PickRandom("Excavator", "Drill", "Loader", "Truck", "Crusher"))
            .RuleFor(x => x.NumberOfWorkers, f => f.Random.Int(5, 500))
            .RuleFor(x => x.IsAutomated, f => f.Random.Bool())
            .RuleFor(x => x.Status, f => f.PickRandom("Active", "Inactive", "Suspended", "Closed"))
            .RuleFor(x => x.LicenseNumber, f => $"LIC-{f.Random.AlphaNumeric(8).ToUpper()}")
            .RuleFor(x => x.EnvironmentalRating, f => f.PickRandom("A", "B", "C", "D", "E"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
