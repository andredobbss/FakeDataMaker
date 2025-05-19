using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class HealthcareFaker : IHealthcareFaker
{
    public async Task<IEnumerable<HealthcareModel>> GenerateHealthcareAsync(int quantity, string language)
    {
        var faker = new Faker<HealthcareModel>(language).StrictMode(true)
            .RuleFor(x => x.PatientName, f => f.Name.FullName())
            .RuleFor(x => x.PatientId, f => f.Random.Replace("H-#####"))
            .RuleFor(x => x.Age, f => f.Random.Int(0, 100))
            .RuleFor(x => x.Gender, f => f.PickRandom("Male", "Female", "Other"))
            .RuleFor(x => x.AdmissionDate, f => f.Date.Past(1))
            .RuleFor(x => x.Diagnosis, f => f.Random.Word())
            .RuleFor(x => x.Doctor, f => $"Dr. {f.Name.LastName()}")
            .RuleFor(x => x.Department, f => f.PickRandom("Cardiology", "Neurology", "Oncology", "Pediatrics", "Orthopedics"))
            .RuleFor(x => x.RoomNumber, f => f.Random.Replace("R-###"))
            .RuleFor(x => x.TreatmentPlan, f => f.Lorem.Sentence())
            .RuleFor(x => x.TreatmentCost, f => f.Finance.Amount(500, 20000))
            .RuleFor(x => x.InsuranceProvider, f => f.Company.CompanyName())
            .RuleFor(x => x.IsDischarged, f => f.Random.Bool())
            .RuleFor(x => x.LastCheckupDate, f => f.Date.Recent(30))
            .RuleFor(x => x.Notes, f => f.Lorem.Paragraph());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
