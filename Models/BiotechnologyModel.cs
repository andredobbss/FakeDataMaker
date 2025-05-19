namespace FakeDataMaker.Models;

public class BiotechnologyModel
{
    public string ResearchProject { get; set; } = string.Empty;
    public string LeadScientist { get; set; } = string.Empty;
    public string Institution { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime LastUpdate { get; set; }
    public decimal FundingAmount { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ExperimentPhase { get; set; } = string.Empty;
    public string Laboratory { get; set; } = string.Empty;
    public string GeneTarget { get; set; } = string.Empty;
    public bool IsClinicalTrial { get; set; }
    public int TestSubjects { get; set; }
    public string Region { get; set; } = string.Empty;
    public string RegulatoryBody { get; set; } = string.Empty;
    public string ResultSummary { get; set; } = string.Empty;
}
