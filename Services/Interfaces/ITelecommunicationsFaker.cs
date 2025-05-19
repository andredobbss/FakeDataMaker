using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface ITelecommunicationsFaker
{
    Task<IEnumerable<TelecommunicationsModel>> GenerateTelecommunicationsAsync(int quantity, string language);
}
