using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class BiotechnologyFaker : IBiotechnologyFaker
{
    public async Task<IEnumerable<BiotechnologyModel>> GenerateBiotechnologyAsync(int quantity, string language)
    {
        var faker = new Faker<BiotechnologyModel>(language).StrictMode(true)
        .RuleFor(x => x.ResearchProject, f => f.Lorem.Sentence(3))
        .RuleFor(x => x.LeadScientist, f => f.Name.FullName())
        .RuleFor(x => x.Institution, f => f.Company.CompanyName())
        .RuleFor(x => x.StartDate, f => f.Date.Past(5))
        .RuleFor(x => x.LastUpdate, f => f.Date.Recent(30))
        .RuleFor(x => x.FundingAmount, f => f.Finance.Amount(50000, 1000000))
        .RuleFor(x => x.Status, f => f.PickRandom("Ongoing", "Completed", "Paused", "Canceled"))
        .RuleFor(x => x.ExperimentPhase, f => f.PickRandom("Phase I", "Phase II", "Phase III", "Preclinical"))
        .RuleFor(x => x.Laboratory, f => f.Company.CompanyName() + " Lab")
        .RuleFor(x => x.GeneTarget, f => $"Gene-{f.Random.AlphaNumeric(5).ToUpper()}")
        .RuleFor(x => x.IsClinicalTrial, f => f.Random.Bool())
        .RuleFor(x => x.TestSubjects, f => f.Random.Number(10, 1000))
        .RuleFor(x => x.Region, f => f.Address.Country())
        .RuleFor(x => x.RegulatoryBody, f => f.PickRandom("FDA", "EMA", "ANVISA", "PMDA"))
        .RuleFor(x => x.ResultSummary, f => f.Lorem.Sentence(10));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
