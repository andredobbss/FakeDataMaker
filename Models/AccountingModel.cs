namespace FakeDataMaker.Models;

public class AccountingModel
{
    public string ClientName { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public string AccountType { get; set; } = string.Empty;
    public decimal AccountBalance { get; set; }
    public DateTime OpeningDate { get; set; }
    public DateTime LastTransactionDate { get; set; }
    public string Currency { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string AccountantName { get; set; } = string.Empty;
    public decimal AnnualRevenue { get; set; }
    public decimal MonthlyExpenses { get; set; }
    public string LedgerType { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
}
