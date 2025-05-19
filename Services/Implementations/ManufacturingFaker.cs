using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class ManufacturingFaker : IManufacturingFaker
{
    public async Task<IEnumerable<ManufacturingModel>> GenerateManufacturingAsync(int quantity, string language)
    {
        var faker = new Faker<ManufacturingModel>(language).StrictMode(true)
            .RuleFor(x => x.ProductName, f => f.Commerce.ProductName())
            .RuleFor(x => x.FactoryLocation, f => f.Address.City())
            .RuleFor(x => x.SupervisorName, f => f.Name.FullName())
            .RuleFor(x => x.MachineCode, f => f.Random.AlphaNumeric(8).ToUpper())
            .RuleFor(x => x.Shift, f => f.PickRandom("Morning", "Afternoon", "Night"))
            .RuleFor(x => x.UnitsProduced, f => f.Random.Number(100, 10000))
            .RuleFor(x => x.ProductionDate, f => f.Date.Recent(30))
            .RuleFor(x => x.UnitCost, f => f.Finance.Amount(1, 500))
            .RuleFor(x => x.QualityCheckStatus, f => f.PickRandom("Passed", "Failed", "Pending"))
            .RuleFor(x => x.Department, f => f.Commerce.Department())
            .RuleFor(x => x.IsAutomated, f => f.Random.Bool())
            .RuleFor(x => x.RawMaterial, f => f.Commerce.ProductMaterial())
            .RuleFor(x => x.MaintenanceTechnician, f => f.Name.FullName())
            .RuleFor(x => x.LastMaintenanceDate, f => f.Date.Past(1))
            .RuleFor(x => x.DefectiveUnits, f => f.Random.Number(0, 200));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
