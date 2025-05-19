using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class EnergyFaker : IEnergyFaker
{
    public async Task<IEnumerable<EnergyModel>> GenerateEnergyAsync(int quantity, string language)
    {
        var faker = new Faker<EnergyModel>(language).StrictMode(true)
            .RuleFor(x => x.CompanyName, f => f.Company.CompanyName())
            .RuleFor(x => x.EnergyType, f => f.PickRandom("Solar", "Wind", "Hydro", "Nuclear", "Geothermal", "Biomass", "Natural Gas"))
            .RuleFor(x => x.Country, f => f.Address.Country())
            .RuleFor(x => x.Region, f => f.Address.State())
            .RuleFor(x => x.GridCode, f => f.Random.AlphaNumeric(10).ToUpper())
            .RuleFor(x => x.PlantName, f => f.Company.CatchPhrase())
            .RuleFor(x => x.OutputMW, f => Math.Round(f.Random.Double(10, 1000), 2))
            .RuleFor(x => x.NumberOfTurbines, f => f.Random.Int(1, 500))
            .RuleFor(x => x.CommissionDate, f => f.Date.Past(20))
            .RuleFor(x => x.Operator, f => f.Name.FullName())
            .RuleFor(x => x.IsRenewable, f => f.Random.Bool())
            .RuleFor(x => x.LicenseStatus, f => f.PickRandom("Active", "Pending", "Revoked", "Expired"))
            .RuleFor(x => x.InspectionDate, f => f.Date.Recent(365))
            .RuleFor(x => x.FuelSource, f => f.PickRandom("Coal", "Natural Gas", "Diesel", "Hydrogen", "Wind", "Solar", "Nuclear"))
            .RuleFor(x => x.MaintenanceCycle, f => f.PickRandom("Monthly", "Quarterly", "Annually"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
