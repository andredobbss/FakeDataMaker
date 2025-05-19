namespace FakeDataMaker.Models;

public class LegalServicesModel
{
    public string ClientName { get; set; } = string.Empty;
    public string CaseId { get; set; } = string.Empty;
    public string CaseType { get; set; } = string.Empty;
    public string AttorneyName { get; set; } = string.Empty;
    public string LawFirm { get; set; } = string.Empty;
    public DateTime CaseStartDate { get; set; }
    public DateTime LastHearingDate { get; set; }
    public string CourtName { get; set; } = string.Empty;
    public string Jurisdiction { get; set; } = string.Empty;
    public decimal CaseValue { get; set; }
    public string CaseStatus { get; set; } = string.Empty;
    public string LegalStrategy { get; set; } = string.Empty;
    public string OpponentName { get; set; } = string.Empty;
    public string CaseSummary { get; set; } = string.Empty;
    public string DocumentReference { get; set; } = string.Empty;
}
