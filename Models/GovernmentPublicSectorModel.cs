namespace FakeDataMaker.Models;

public class GovernmentPublicSectorModel
{
    public string ProjectCode { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string ProgramName { get; set; } = string.Empty;
    public string OfficerInCharge { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal AllocatedBudget { get; set; }
    public int StaffCount { get; set; }
    public string Status { get; set; } = string.Empty;
    public string DocumentationUrl { get; set; } = string.Empty;
    public bool IsFederalFunded { get; set; }
    public string Summary { get; set; } = string.Empty;
}
