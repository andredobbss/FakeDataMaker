namespace FakeDataMaker.Models;

public class MiningModel
{
    public string OperationId { get; set; } = string.Empty;
    public string SiteName { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string ResourceType { get; set; } = string.Empty;
    public DateTime ExtractionStartDate { get; set; }
    public DateTime? ExtractionEndDate { get; set; }
    public int TotalTonnageExtracted { get; set; }
    public decimal ExtractionCostUSD { get; set; }
    public string Supervisor { get; set; } = string.Empty;
    public string EquipmentUsed { get; set; } = string.Empty;
    public int NumberOfWorkers { get; set; }
    public bool IsAutomated { get; set; }
    public string Status { get; set; } = string.Empty;
    public string LicenseNumber { get; set; } = string.Empty;
    public string EnvironmentalRating { get; set; } = string.Empty;
}
