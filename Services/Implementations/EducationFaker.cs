using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class EducationFaker : IEducationFaker
{
    public async Task<IEnumerable<EducationModel>> GenerateEducationAsync(int quantity, string language)
    {
        var faker = new Faker<EducationModel>(language).StrictMode(true)
            .RuleFor(x => x.StudentName, f => f.Name.FullName())
            .RuleFor(x => x.Institution, f => f.Company.CompanyName() + " University")
            .RuleFor(x => x.ProgramName, f => f.PickRandom(new[] {
                "Computer Science", "Economics", "Business Administration",
                "Mechanical Engineering", "Architecture", "Philosophy",
                "Physics", "Law", "Medicine", "Mathematics",
                "Education", "Sociology", "Psychology", "Chemistry", "History"
            }))
            .RuleFor(x => x.Level, f => f.PickRandom("Bachelor", "Master", "PhD"))
            .RuleFor(x => x.EnrollmentDate, f => f.Date.Past(5))
            .RuleFor(x => x.GraduationDate, (f, x) => x.EnrollmentDate.AddYears(f.Random.Int(2, 5)))
            .RuleFor(x => x.GPA, f => Math.Round(f.Random.Double(2.0, 4.0), 2))
            .RuleFor(x => x.Email, f => f.Internet.Email())
            .RuleFor(x => x.PhoneNumber, f => f.Phone.PhoneNumberFormat())
            .RuleFor(x => x.Country, f => f.Address.Country())
            .RuleFor(x => x.City, f => f.Address.City())
            .RuleFor(x => x.StudentID, f => f.Random.Replace("S-####-####"))
            .RuleFor(x => x.IsFullTime, f => f.Random.Bool())
            .RuleFor(x => x.AdvisorName, f => f.Name.FullName())
            .RuleFor(x => x.Department, f => f.Commerce.Department());

        return await Task.FromResult(faker.Generate(quantity));
    }
}
