using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IFoodFaker
{
    Task<IEnumerable<FoodModel>> GenerateFoodAsync(int quantity, string language);
}
