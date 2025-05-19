using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class RetailFaker : IRetailFaker
{
    public async Task<IEnumerable<RetailModel>> GenerateRetailAsync(int quantity, string language)
    {
        var faker = new Faker<RetailModel>(language).StrictMode(true)
        .RuleFor(x => x.ProductId, f => f.Random.Guid().ToString())
        .RuleFor(x => x.ProductName, f => f.Commerce.ProductName())
        .RuleFor(x => x.Brand, f => f.Company.CompanyName())
        .RuleFor(x => x.Category, f => f.Commerce.Categories(1).First())
        .RuleFor(x => x.SKU, f => f.Commerce.Ean13())
        .RuleFor(x => x.Price, f => f.Finance.Amount(5, 2000))
        .RuleFor(x => x.StockQuantity, f => f.Random.Number(0, 500))
        .RuleFor(x => x.SoldQuantity, f => f.Random.Number(0, 1000))
        .RuleFor(x => x.DateAdded, f => f.Date.Past(2))
        .RuleFor(x => x.LastSoldDate, (f, x) => x.DateAdded.AddDays(f.Random.Number(1, 365)))
        .RuleFor(x => x.Supplier, f => f.Company.CompanyName())
        .RuleFor(x => x.WarehouseLocation, f => f.Address.City())
        .RuleFor(x => x.Description, f => f.Commerce.ProductDescription())
        .RuleFor(x => x.IsDiscounted, f => f.Random.Bool())
        .RuleFor(x => x.Status, f => f.PickRandom("Active", "Discontinued", "Out of Stock"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
