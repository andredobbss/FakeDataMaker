using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAerospaceFaker
{
    IEnumerable<AerospaceModel> GenerateAerospace(int quantity, string language);
}
