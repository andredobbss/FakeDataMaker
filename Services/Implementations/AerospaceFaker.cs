using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class AerospaceFaker : IAerospaceFaker
{
    public async Task<IEnumerable<AerospaceModel>> GenerateAerospaceAsync(int quantity, string language)
    {
        var faker = new Faker<AerospaceModel>(language).StrictMode(true)
            .RuleFor(x => x.AircraftModel, f => f.Random.AlphaNumeric(8).ToUpper())
            .RuleFor(x => x.Manufacturer, f => f.Company.CompanyName())
            .RuleFor(x => x.EngineType, f => f.PickRandom("Turbojet", "Turbofan", "Turboprop", "Ramjet"))
            .RuleFor(x => x.WingspanMeters, f => f.Random.Double(10.0, 80.0))
            .RuleFor(x => x.LengthMeters, f => f.Random.Double(10.0, 80.0))
            .RuleFor(x => x.MaxSpeedKmH, f => f.Random.Int(600, 2500))
            .RuleFor(x => x.RangeKm, f => f.Random.Int(2000, 15000))
            .RuleFor(x => x.CrewSize, f => f.Random.Int(1, 15))
            .RuleFor(x => x.PassengerCapacity, f => f.Random.Int(0, 800))
            .RuleFor(x => x.FirstFlightDate, f => f.Date.Past(60))
            .RuleFor(x => x.CertificationDate, f => f.Date.Past(50))
            .RuleFor(x => x.LastMaintenanceDate, f => f.Date.Past(1))
            .RuleFor(x => x.CountryOfOrigin, f => f.Address.Country())
            .RuleFor(x => x.InProduction, f => f.Random.Bool())
            .RuleFor(x => x.Description, f => f.Lorem.Sentence());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
