using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class InformationTechnologyFaker : IInformationTechnologyFaker
{
    public async Task<IEnumerable<InformationTechnologyModel>> GenerateInformationTechnologyAsync(int quantity, string language)
    {
        var faker = new Faker<InformationTechnologyModel>(language).StrictMode(true)
       .RuleFor(x => x.EmployeeName, f => f.Name.FullName())
       .RuleFor(x => x.JobTitle, f => f.Name.JobTitle())
       .RuleFor(x => x.Department, f => f.Commerce.Department())
       .RuleFor(x => x.Email, f => f.Internet.Email())
       .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumberFormat())
       .RuleFor(x => x.HireDate, f => f.Date.Past(10))
       .RuleFor(x => x.Salary, f => f.Finance.Amount(4000, 15000))
       .RuleFor(x => x.ProgrammingLanguage, f => f.PickRandom("C#", "Java", "Python", "JavaScript", "Go", "Ruby"))
       .RuleFor(x => x.ProjectName, f => f.Commerce.ProductName())
       .RuleFor(x => x.Status, f => f.PickRandom("Active", "On Leave", "Contractor", "Terminated"))
       .RuleFor(x => x.Remote, f => f.Random.Bool())
       .RuleFor(x => x.ManagerName, f => f.Name.FullName())
       .RuleFor(x => x.LastPromotionDate, f => f.Date.Recent(1000))
       .RuleFor(x => x.OfficeLocation, f => f.Address.City())
       .RuleFor(x => x.CompletedProjects, f => f.Random.Number(0, 50));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
