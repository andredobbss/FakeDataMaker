namespace FakeDataMaker.Models;

public class EnvironmentalServiceModel
{
    public string ProjectId { get; set; } = string.Empty;
    public string ProjectName { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string ServiceType { get; set; } = string.Empty;
    public string ResponsibleEngineer { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime CompletionDate { get; set; }
    public decimal Budget { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ReportFile { get; set; } = string.Empty;
    public bool RequiresInspection { get; set; }
    public int NumberOfTechnicians { get; set; }
    public string EnvironmentalImpactLevel { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
}
