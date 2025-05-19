namespace FakeDataMaker.Models;

public class CybersecurityModel
{
    public string IncidentId { get; set; } = string.Empty;
    public string ThreatType { get; set; } = string.Empty;
    public string AffectedSystem { get; set; } = string.Empty;
    public string SeverityLevel { get; set; } = string.Empty;
    public string DetectedBy { get; set; } = string.Empty;
    public DateTime DetectionDate { get; set; }
    public DateTime ResolutionDate { get; set; }
    public string Status { get; set; } = string.Empty;
    public int ImpactScore { get; set; }
    public string Region { get; set; } = string.Empty;
    public string ResponseTeam { get; set; } = string.Empty;
    public string AttackVector { get; set; } = string.Empty;
    public bool DataCompromised { get; set; }
    public string MitigationAction { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
}
