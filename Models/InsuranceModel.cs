namespace FakeDataMaker.Models;

public class InsuranceModel
{
    public Guid Id { get; set; }
    public string PolicyNumber { get; set; } = string.Empty;
    public string HolderName { get; set; } = string.Empty;
    public string InsuranceType { get; set; } = string.Empty;
    public decimal PremiumAmount { get; set; }
    public decimal CoverageLimit { get; set; }
    public string ProviderName { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsAutoRenewal { get; set; }
    public string AgentName { get; set; } = string.Empty;
}
