using FakeDataMaker.Models;

namespace FakeDataMaker.Services.Interfaces;

public interface ILogisticsFaker
{
    Task<IEnumerable<LogisticsModel>> GenerateLogisticsAsync(int quantity, string language);
}
