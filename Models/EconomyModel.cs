namespace FakeDataMaker.Models;

public class EconomyModel
{
    public string Country { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public decimal GDP { get; set; }
    public decimal InflationRate { get; set; }
    public decimal UnemploymentRate { get; set; }
    public DateTime LastUpdate { get; set; }
    public string EconomicSector { get; set; } = string.Empty;
    public string MainExport { get; set; } = string.Empty;
    public string MainImport { get; set; } = string.Empty;
    public decimal DebtToGDP { get; set; }
    public string EconomicOutlook { get; set; } = string.Empty;
    public decimal InterestRate { get; set; }
    public string CreditRating { get; set; } = string.Empty;
    public string CentralBank { get; set; } = string.Empty;
    public string ExchangeRegime { get; set; } = string.Empty;
}
