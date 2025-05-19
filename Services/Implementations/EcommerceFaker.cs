using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class EcommerceFaker : IEcommerceFaker
{
    public async Task<IEnumerable<EcommerceModel>> GenerateEcommerceAsync(int quantity, string language)
    {
        var faker = new Faker<EcommerceModel>(language).StrictMode(true)
        .RuleFor(x => x.OrderId, f => f.Random.Guid().ToString())
        .RuleFor(x => x.CustomerName, f => f.Name.FullName())
        .RuleFor(x => x.Email, f => f.Internet.Email())
        .RuleFor(x => x.Product, f => f.Commerce.ProductName())
        .RuleFor(x => x.Quantity, f => f.Random.Int(1, 5))
        .RuleFor(x => x.Price, f => f.Random.Decimal(10, 500))
        .RuleFor(x => x.Total, (f, x) => Math.Round(x.Quantity * x.Price, 2))
        .RuleFor(x => x.PaymentMethod, f => f.PickRandom("Credit Card", "PayPal", "Bank Transfer", "PIX"))
        .RuleFor(x => x.OrderDate, f => f.Date.Past(1))
        .RuleFor(x => x.DeliveryDate, (f, x) => x.OrderDate.AddDays(f.Random.Int(1, 10)))
        .RuleFor(x => x.OrderStatus, f => f.PickRandom("Pending", "Shipped", "Delivered", "Cancelled"))
        .RuleFor(x => x.ShippingAddress, f => f.Address.FullAddress())
        .RuleFor(x => x.IsGift, f => f.Random.Bool())
        .RuleFor(x => x.TrackingNumber, f => $"TRK-{f.Random.Number(100000, 999999)}")
        .RuleFor(x => x.Notes, f => f.Lorem.Sentence());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
