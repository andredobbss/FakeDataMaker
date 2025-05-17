using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class AgricultureFaker : IAgricultureFaker
{
    IEnumerable<AgricultureModel> IAgricultureFaker.GenerateAgriculture(int quantity, string language)
    {
        var faker = new Faker<AgricultureModel>(locale: language)
        .RuleFor(a => a.FarmName, f => f.Company.CompanyName())
        .RuleFor(a => a.CropType, f => f.PickRandom("Wheat", "Corn", "Soy", "Rice", "Barley", "Sugarcane"))
        .RuleFor(a => a.FarmerName, f => f.Name.FullName())
        .RuleFor(a => a.LandAreaHectares, f => Math.Round(f.Random.Double(10, 1000), 2))
        .RuleFor(a => a.NumberOfEmployees, f => f.Random.Int(5, 100))
        .RuleFor(a => a.AnnualRevenue, f => f.Finance.Amount(10000, 1000000))
        .RuleFor(a => a.MonthlyCost, f => f.Finance.Amount(1000, 80000))
        .RuleFor(a => a.Region, f => f.Address.City())
        .RuleFor(a => a.Country, f => f.Address.Country())
        .RuleFor(a => a.SoilType, f => f.PickRandom("Sandy", "Clay", "Silt", "Loam"))
        .RuleFor(a => a.PlantingDate, f => f.Date.Past(1))
        .RuleFor(a => a.HarvestDate, (f, a) => a.PlantingDate.AddMonths(f.Random.Int(3, 8)))
        .RuleFor(a => a.IsOrganic, f => f.Random.Bool())
        .RuleFor(a => a.IrrigationType, f => f.PickRandom("Drip", "Sprinkler", "Surface", "Manual"))
        .RuleFor(a => a.Notes, f => f.Lorem.Sentence());

        return faker.Generate(quantity);
    }
}
