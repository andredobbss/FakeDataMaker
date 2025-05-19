using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IEntertainmentFaker
{
    Task<IEnumerable<EntertainmentModel>> GenerateEntertainmentAsync(int quantity, string language);
}
