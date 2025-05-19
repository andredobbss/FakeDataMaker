using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class ConsumerGoodsFaker : IConsumerGoodsFaker
{
    public async Task<IEnumerable<ConsumerGoodsModel>> GenerateConsumerGoodsAsync(int quantity, string language)
    {
        var faker = new Faker<ConsumerGoodsModel>(language).StrictMode(true)
            .RuleFor(x => x.ProductName, f => f.Commerce.ProductName())
            .RuleFor(x => x.Brand, f => f.Company.CompanyName())
            .RuleFor(x => x.Category, f => f.Commerce.Categories(1)[0])
            .RuleFor(x => x.SKU, f => f.Commerce.Ean8())
            .RuleFor(x => x.Price, f => f.Finance.Amount(1.5m, 500))
            .RuleFor(x => x.StockQuantity, f => f.Random.Int(0, 1000))
            .RuleFor(x => x.ManufactureDate, f => f.Date.Past(2))
            .RuleFor(x => x.ExpirationDate, (f, x) => x.ManufactureDate.AddMonths(f.Random.Int(6, 24)))
            .RuleFor(x => x.OriginCountry, f => f.Address.Country())
            .RuleFor(x => x.Supplier, f => f.Company.CompanyName())
            .RuleFor(x => x.Barcode, f => f.Commerce.Ean13())
            .RuleFor(x => x.PackagingType, f => f.PickRandom("Box", "Bottle", "Can", "Bag", "Carton"))
            .RuleFor(x => x.Weight, f => $"{f.Random.Decimal(0.1m, 5.0m):0.##} kg")
            .RuleFor(x => x.IsRecyclable, f => f.Random.Bool())
            .RuleFor(x => x.ProductStatus, f => f.PickRandom("Available", "Out of Stock", "Discontinued"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
