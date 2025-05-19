namespace FakeDataMaker.Models;

public class SportsRecreationModel
{
    public string OrganizationId { get; set; } = string.Empty;
    public string OrganizationName { get; set; } = string.Empty;
    public string SportType { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string FacilityName { get; set; } = string.Empty;
    public int Capacity { get; set; }
    public DateTime EstablishedDate { get; set; }
    public string Director { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public decimal AnnualRevenueUSD { get; set; }
    public bool IsPublic { get; set; }
    public string Status { get; set; } = string.Empty;
}
