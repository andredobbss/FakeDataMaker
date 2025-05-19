using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class CivilConstructionFaker : ICivilConstructionFaker
{
    public async Task<IEnumerable<CivilConstructionModel>> GenerateCivilConstructionAsync(int quantity, string language)
    {
        var faker = new Faker<CivilConstructionModel>(language).StrictMode(true)
            .RuleFor(x => x.ProjectName, f => f.Company.CatchPhrase())
            .RuleFor(x => x.SiteLocation, f => f.Address.StreetAddress())
            .RuleFor(x => x.ContractorName, f => f.Company.CompanyName())
            .RuleFor(x => x.ProjectCost, f => f.Finance.Amount(500000, 10000000))
            .RuleFor(x => x.StartDate, f => f.Date.Past(2))
            .RuleFor(x => x.EstimatedEndDate, (f, x) => x.StartDate.AddDays(f.Random.Int(180, 720)))
            .RuleFor(x => x.Status, f => f.PickRandom("Planning", "In Progress", "Completed", "Delayed"))
            .RuleFor(x => x.ProjectManager, f => f.Name.FullName())
            .RuleFor(x => x.NumberOfWorkers, f => f.Random.Int(20, 500))
            .RuleFor(x => x.EquipmentUsed, f => f.Commerce.ProductName())
            .RuleFor(x => x.BuildingType, f => f.PickRandom("Residential", "Commercial", "Industrial", "Public"))
            .RuleFor(x => x.SafetyRating, f => f.PickRandom("A", "B", "C", "D"))
            .RuleFor(x => x.LastInspectionDate, f => f.Date.Recent(90))
            .RuleFor(x => x.IsGovernmentFunded, f => f.Random.Bool())
            .RuleFor(x => x.PermitCode, f => $"PERM-{f.Random.Number(100000, 999999)}");

        return await Task.FromResult(faker.Generate(quantity));
    }
}
