using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class TransportationFaker : ITransportationFaker
{
    public async Task<IEnumerable<TransportationModel>> GenerateTransportationAsync(int quantity, string language)
    {
        var faker = new Faker<TransportationModel>(language).StrictMode(true)
        .RuleFor(x => x.VehicleId, f => f.Random.Guid().ToString())
        .RuleFor(x => x.VehicleType, f => f.PickRandom("Truck", "Van", "Train", "Ship", "Plane"))
        .RuleFor(x => x.LicensePlate, f => f.Vehicle.Vin().Substring(0, 7).ToUpper())
        .RuleFor(x => x.DriverName, f => f.Name.FullName())
        .RuleFor(x => x.Route, f => $"{f.Address.City()} - {f.Address.City()}")
        .RuleFor(x => x.Origin, f => f.Address.City())
        .RuleFor(x => x.Destination, f => f.Address.City())
        .RuleFor(x => x.DistanceKm, f => f.Random.Double(10, 3000))
        .RuleFor(x => x.DepartureTime, f => f.Date.Past(1))
        .RuleFor(x => x.ArrivalTime, (f, x) => x.DepartureTime.AddHours(f.Random.Double(1, 72)))
        .RuleFor(x => x.Status, f => f.PickRandom("On Time", "Delayed", "In Transit", "Delivered"))
        .RuleFor(x => x.CarrierCompany, f => f.Company.CompanyName())
        .RuleFor(x => x.CargoWeightKg, f => f.Random.Int(100, 30000))
        .RuleFor(x => x.IsDelayed, (f, x) => x.Status == "Delayed")
        .RuleFor(x => x.Comments, f => f.Lorem.Sentence());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
