namespace FakeDataMaker.Models;

public class NonprofitModel
{
    public string OrganizationId { get; set; } = string.Empty;
    public string OrganizationName { get; set; } = string.Empty;
    public string Mission { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string Sector { get; set; } = string.Empty;
    public DateTime FoundedDate { get; set; }
    public string Director { get; set; } = string.Empty;
    public int NumberOfVolunteers { get; set; }
    public decimal AnnualBudgetUSD { get; set; }
    public bool IsInternational { get; set; }
    public string Website { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string ContactPhone { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
