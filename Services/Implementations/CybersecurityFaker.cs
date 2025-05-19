using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class CybersecurityFaker : ICybersecurityFaker
{
    public async Task<IEnumerable<CybersecurityModel>> GenerateCybersecurityAsync(int quantity, string language)
    {
        var faker = new Faker<CybersecurityModel>(language).StrictMode(true)
        .RuleFor(x => x.IncidentId, f => $"INC-{f.Random.Number(1000, 9999)}")
        .RuleFor(x => x.ThreatType, f => f.PickRandom("Malware", "Phishing", "Ransomware", "DDoS", "Zero-day"))
        .RuleFor(x => x.AffectedSystem, f => f.Commerce.ProductName())
        .RuleFor(x => x.SeverityLevel, f => f.PickRandom("Low", "Medium", "High", "Critical"))
        .RuleFor(x => x.DetectedBy, f => f.Company.CompanyName())
        .RuleFor(x => x.DetectionDate, f => f.Date.Past(1))
        .RuleFor(x => x.ResolutionDate, (f, x) => x.DetectionDate.AddDays(f.Random.Int(1, 30)))
        .RuleFor(x => x.Status, f => f.PickRandom("Open", "In Progress", "Resolved", "Closed"))
        .RuleFor(x => x.ImpactScore, f => f.Random.Int(1, 100))
        .RuleFor(x => x.Region, f => f.Address.Country())
        .RuleFor(x => x.ResponseTeam, f => $"Team {f.Random.AlphaNumeric(3).ToUpper()}")
        .RuleFor(x => x.AttackVector, f => f.PickRandom("Email", "Web", "USB", "Remote Access", "Social Engineering"))
        .RuleFor(x => x.DataCompromised, f => f.Random.Bool())
        .RuleFor(x => x.MitigationAction, f => f.Lorem.Sentence(6))
        .RuleFor(x => x.Notes, f => f.Lorem.Sentences(2));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
