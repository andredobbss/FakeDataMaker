using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class AutomotiveFaker : IAutomotiveFaker
{
    public async Task<IEnumerable<AutomotiveModel>> GenerateAutomotiveAsync(int quantity, string language)
    {
        var faker = new Faker<AutomotiveModel>(language).StrictMode(true)
            .RuleFor(a => a.Manufacturer, f => f.Vehicle.Manufacturer())
            .RuleFor(a => a.Model, f => f.Vehicle.Model())
            .RuleFor(a => a.VehicleType, f => f.PickRandom("Sedan", "SUV", "Hatchback", "Truck", "Coupe", "Van"))
            .RuleFor(a => a.EngineType, f => f.PickRandom("Gasoline", "Diesel", "Hybrid", "Electric"))
            .RuleFor(a => a.Horsepower, f => f.Random.Int(80, 500))
            .RuleFor(a => a.Year, f => f.Date.Past(10).Year)
            .RuleFor(a => a.Price, f => f.Finance.Amount(10000, 120000))
            .RuleFor(a => a.Color, f => f.Commerce.Color())
            .RuleFor(a => a.NumberOfDoors, f => f.PickRandom(2, 3, 4, 5))
            .RuleFor(a => a.IsElectric, f => f.Random.Bool())
            .RuleFor(a => a.LicensePlate, f => f.Random.Replace("???-####"))
            .RuleFor(a => a.VIN, f => f.Vehicle.Vin())
            .RuleFor(a => a.RegistrationDate, f => f.Date.Past(5))
            .RuleFor(a => a.FuelEfficiencyKmPerL, f => Math.Round(f.Random.Decimal(5, 25), 1))
            .RuleFor(a => a.CountryOfOrigin, f => f.Address.Country());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
