using Bogus;
using FakeDataMaker.Models;
using FakeDataMaker.Services.Interfaces;

namespace FakeDataMaker.Services.Implementations;

public class MediaPublishingFaker : IMediaPublishingFaker
{
    public async Task<IEnumerable<MediaPublishingModel>> GenerateMediaPublishingAsync(int quantity, string language)
    {
        var faker = new Faker<MediaPublishingModel>(language).StrictMode(true)
            .RuleFor(x => x.ArticleId, f => f.Random.Guid().ToString())
            .RuleFor(x => x.Title, f => f.Lorem.Sentence(6, 4))
            .RuleFor(x => x.Author, f => f.Name.FullName())
            .RuleFor(x => x.PublishDate, f => f.Date.Past(2))
            .RuleFor(x => x.Category, f => f.PickRandom("Technology", "Business", "Entertainment", "Health", "Sports"))
            .RuleFor(x => x.Language, f => f.Random.RandomLocale())
            .RuleFor(x => x.Publisher, f => f.Company.CompanyName())
            .RuleFor(x => x.WordCount, f => f.Random.Int(300, 5000))
            .RuleFor(x => x.ReadTimeMinutes, (f, u) => u.WordCount / 200)
            .RuleFor(x => x.Views, f => f.Random.Int(1000, 100000))
            .RuleFor(x => x.Shares, f => f.Random.Int(0, 10000))
            .RuleFor(x => x.IsFeatured, f => f.Random.Bool(0.2f)) // 20% chance
            .RuleFor(x => x.ContentType, f => f.PickRandom("Article", "Video", "Podcast", "Infographic"))
            .RuleFor(x => x.Tags, f => string.Join(", ", f.Lorem.Words(3)))
            .RuleFor(x => x.Status, f => f.PickRandom("Draft", "Published", "Archived"));

        return await Task.FromResult(faker.Generate(quantity));
    }
}
