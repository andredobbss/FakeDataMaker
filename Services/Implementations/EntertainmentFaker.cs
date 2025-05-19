using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class EntertainmentFaker : IEntertainmentFaker
{
    public async Task<IEnumerable<EntertainmentModel>> GenerateEntertainmentAsync(int quantity, string language)
    {
        var faker = new Faker<EntertainmentModel>(language).StrictMode(true)
           .RuleFor(x => x.Title, f => f.Lorem.Sentence(3))
           .RuleFor(x => x.Genre, f => f.PickRandom("Action", "Comedy", "Drama", "Horror", "Sci-Fi", "Romance", "Documentary"))
           .RuleFor(x => x.Platform, f => f.PickRandom("Netflix", "Amazon Prime", "HBO", "Disney+", "Hulu", "Paramount+"))
           .RuleFor(x => x.Director, f => f.Name.FullName())
           .RuleFor(x => x.Producer, f => f.Name.FullName())
           .RuleFor(x => x.ReleaseDate, f => f.Date.Past(10))
           .RuleFor(x => x.Rating, f => Math.Round(f.Random.Double(1, 10), 1))
           .RuleFor(x => x.DurationMinutes, f => f.Random.Int(60, 180))
           .RuleFor(x => x.Language, f => f.Locale)
           .RuleFor(x => x.CountryOfOrigin, f => f.Address.Country())
           .RuleFor(x => x.AgeRestriction, f => f.PickRandom("G", "PG", "PG-13", "R", "NC-17"))
           .RuleFor(x => x.Synopsis, f => f.Lorem.Paragraph())
           .RuleFor(x => x.IsStreamingAvailable, f => f.Random.Bool())
           .RuleFor(x => x.MainActor, f => f.Name.FullName())
           .RuleFor(x => x.LastViewed, f => f.Date.Recent(90));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
