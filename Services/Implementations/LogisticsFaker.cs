using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class LogisticsFaker : ILogisticsFaker
{
    public async Task<IEnumerable<LogisticsModel>> GenerateLogisticsAsync(int quantity, string language)
    {
        var faker = new Faker<LogisticsModel>(language).StrictMode(true)
           .RuleFor(x => x.ShipmentId, f => f.Random.Guid().ToString())
           .RuleFor(x => x.CarrierName, f => f.Company.CompanyName())
           .RuleFor(x => x.Origin, f => f.Address.City())
           .RuleFor(x => x.Destination, f => f.Address.City())
           .RuleFor(x => x.DepartureDate, f => f.Date.Past(1))
           .RuleFor(x => x.EstimatedArrival, (f, u) => f.Date.Soon(10, u.DepartureDate))
           .RuleFor(x => x.TransportMode, f => f.PickRandom("Truck", "Ship", "Airplane", "Train"))
           .RuleFor(x => x.DriverName, f => f.Name.FullName())
           .RuleFor(x => x.VehiclePlate, f => f.Random.Replace("???-####"))
           .RuleFor(x => x.DistanceKm, f => f.Random.Decimal(50, 5000))
           .RuleFor(x => x.FreightCost, f => f.Finance.Amount(100, 5000))
           .RuleFor(x => x.CargoDescription, f => f.Commerce.ProductName())
           .RuleFor(x => x.CargoWeightKg, f => f.Random.Int(100, 20000))
           .RuleFor(x => x.Status, f => f.PickRandom("Pending", "In Transit", "Delivered", "Delayed"))
           .RuleFor(x => x.TrackingCode, f => f.Random.AlphaNumeric(10).ToUpper());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
