namespace FakeDataMaker.Models;

public class TelecommunicationsModel
{
    public string CompanyId { get; set; } = string.Empty;
    public string CompanyName { get; set; } = string.Empty;
    public string Headquarters { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string ServiceType { get; set; } = string.Empty;
    public string CEO { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public string PhoneSupport { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public DateTime FoundedDate { get; set; }
    public int NumberOfSubscribers { get; set; }
    public decimal AnnualRevenueUSD { get; set; }
    public bool Offers5G { get; set; }
    public string Status { get; set; } = string.Empty;
    public string NetworkCoverage { get; set; } = string.Empty;
}
