using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class FoodFaker : IFoodFaker
{
    public async Task<IEnumerable<FoodModel>> GenerateFoodAsync(int quantity, string language)
    {
        var faker = new Faker<FoodModel>(language).StrictMode(true)
            .RuleFor(x => x.ProductName, f => f.Commerce.ProductName())
            .RuleFor(x => x.Category, f => f.Commerce.Categories(1).First())
            .RuleFor(x => x.Brand, f => f.Company.CompanyName())
            .RuleFor(x => x.OriginCountry, f => f.Address.Country())
            .RuleFor(x => x.SupplierName, f => f.Company.CompanyName())
            .RuleFor(x => x.ProductionDate, f => f.Date.Past(1))
            .RuleFor(x => x.ExpirationDate, (f, u) => u.ProductionDate.AddMonths(f.Random.Int(3, 12)))
            .RuleFor(x => x.Price, f => f.Finance.Amount(1, 50))
            .RuleFor(x => x.WeightInKg, f => Math.Round(f.Random.Double(0.1, 5.0), 2))
            .RuleFor(x => x.Calories, f => f.Random.Int(50, 600))
            .RuleFor(x => x.Ingredients, f => string.Join(", ", f.Lorem.Words(5)))
            .RuleFor(x => x.PackagingType, f => f.PickRandom("Box", "Bag", "Bottle", "Can", "Tray"))
            .RuleFor(x => x.StorageInstructions, f => f.Lorem.Sentence())
            .RuleFor(x => x.Certification, f => f.PickRandom("Organic", "Non-GMO", "Fair Trade", "Halal", "Kosher"))
            .RuleFor(x => x.NutritionalClaim, f => f.PickRandom("High Fiber", "Low Fat", "Sugar-Free", "Gluten-Free"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
