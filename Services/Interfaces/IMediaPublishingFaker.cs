using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IMediaPublishingFaker
{
    Task<IEnumerable<MediaPublishingModel>> GenerateMediaPublishingAsync(int quantity, string language);
}
