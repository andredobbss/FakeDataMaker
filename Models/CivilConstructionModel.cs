namespace FakeDataMaker.Models;

public class CivilConstructionModel
{
    public string ProjectName { get; set; } = string.Empty;
    public string SiteLocation { get; set; } = string.Empty;
    public string ContractorName { get; set; } = string.Empty;
    public decimal ProjectCost { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EstimatedEndDate { get; set; }
    public string Status { get; set; } = string.Empty;
    public string ProjectManager { get; set; } = string.Empty;
    public int NumberOfWorkers { get; set; }
    public string EquipmentUsed { get; set; } = string.Empty;
    public string BuildingType { get; set; } = string.Empty;
    public string SafetyRating { get; set; } = string.Empty;
    public DateTime LastInspectionDate { get; set; }
    public bool IsGovernmentFunded { get; set; }
    public string PermitCode { get; set; } = string.Empty;
}
