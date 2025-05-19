using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface ILegalServicesFaker
{
    Task<IEnumerable<LegalServicesModel>> GenerateLegalServicesAsync(int quantity, string language);
}
