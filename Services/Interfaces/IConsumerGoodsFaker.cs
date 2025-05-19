using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface IConsumerGoodsFaker
{
    Task<IEnumerable<ConsumerGoodsModel>> GenerateConsumerGoodsAsync(int quantity, string language);
}
