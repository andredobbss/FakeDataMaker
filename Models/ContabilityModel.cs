namespace FakeDataMaker.Models;

public class ContabilityModel
{
    public string AccountName { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public DateTime LastTransactionDate { get; set; }
    public string Currency { get; set; } = string.Empty;
    public string TransactionType { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string ResponsiblePerson { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string CostCenter { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public decimal AnnualBudget { get; set; }
    public int FiscalYear { get; set; }
    public bool IsActive { get; set; }
}
