using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IAutomotiveFaker
{
    IEnumerable<AutomotiveModel> GenerateAutomotive(int quantity, string language);
}
