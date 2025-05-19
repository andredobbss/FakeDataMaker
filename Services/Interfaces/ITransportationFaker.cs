using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface ITransportationFaker
{
    Task<IEnumerable<TransportationModel>> GenerateTransportationAsync(int quantity, string language);
}
