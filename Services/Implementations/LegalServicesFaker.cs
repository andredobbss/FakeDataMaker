using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class LegalServicesFaker : ILegalServicesFaker
{
    public async Task<IEnumerable<LegalServicesModel>> GenerateLegalServicesAsync(int quantity, string language)
    {
        var faker = new Faker<LegalServicesModel>(language).StrictMode(true)
            .RuleFor(x => x.ClientName, f => f.Name.FullName())
            .RuleFor(x => x.CaseId, f => f.Random.Guid().ToString())
            .RuleFor(x => x.CaseType, f => f.PickRandom("Civil", "Criminal", "Family", "Corporate", "Tax"))
            .RuleFor(x => x.AttorneyName, f => f.Name.FullName())
            .RuleFor(x => x.LawFirm, f => f.Company.CompanyName())
            .RuleFor(x => x.CaseStartDate, f => f.Date.Past(5))
            .RuleFor(x => x.LastHearingDate, f => f.Date.Recent(60))
            .RuleFor(x => x.CourtName, f => f.Company.CompanyName() + " Court")
            .RuleFor(x => x.Jurisdiction, f => f.Address.State())
            .RuleFor(x => x.CaseValue, f => f.Finance.Amount(10000, 1000000))
            .RuleFor(x => x.CaseStatus, f => f.PickRandom("Open", "Closed", "Pending", "Appealed"))
            .RuleFor(x => x.LegalStrategy, f => f.Lorem.Sentence())
            .RuleFor(x => x.OpponentName, f => f.Name.FullName())
            .RuleFor(x => x.CaseSummary, f => f.Lorem.Paragraph())
            .RuleFor(x => x.DocumentReference, f => f.Random.AlphaNumeric(12).ToUpper());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
