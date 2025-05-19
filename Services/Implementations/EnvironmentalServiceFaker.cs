using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class EnvironmentalServiceFaker : IEnvironmentalServiceFaker
{
    public async Task<IEnumerable<EnvironmentalServiceModel>> GenerateEnvironmentalServicesAsync(int quantity, string language)
    {
        var faker = new Faker<EnvironmentalServiceModel>(language).StrictMode(true)
            .RuleFor(x => x.ProjectId, f => f.Random.Guid().ToString())
            .RuleFor(x => x.ProjectName, f => $"Enviro Project {f.Commerce.ProductName()}")
            .RuleFor(x => x.ClientName, f => f.Company.CompanyName())
            .RuleFor(x => x.Region, f => f.Address.State())
            .RuleFor(x => x.ServiceType, f => f.PickRandom("Air Quality", "Water Treatment", "Waste Management", "Soil Remediation"))
            .RuleFor(x => x.ResponsibleEngineer, f => f.Name.FullName())
            .RuleFor(x => x.StartDate, f => f.Date.Past(2))
            .RuleFor(x => x.CompletionDate, (f, x) => x.StartDate.AddDays(f.Random.Int(30, 180)))
            .RuleFor(x => x.Budget, f => f.Random.Decimal(10000, 250000))
            .RuleFor(x => x.Status, f => f.PickRandom("Planned", "Ongoing", "Completed", "Delayed"))
            .RuleFor(x => x.ReportFile, f => f.System.FileName("pdf"))
            .RuleFor(x => x.RequiresInspection, f => f.Random.Bool())
            .RuleFor(x => x.NumberOfTechnicians, f => f.Random.Int(2, 15))
            .RuleFor(x => x.EnvironmentalImpactLevel, f => f.PickRandom("Low", "Moderate", "High", "Critical"))
            .RuleFor(x => x.Notes, f => f.Lorem.Sentence());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
