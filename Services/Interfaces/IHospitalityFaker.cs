using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IHospitalityFaker
{
    Task<IEnumerable<HospitalityModel>> GenerateHospitalityAsync(int quantity, string language);
}
