namespace FakeDataMaker.Models;

public class FinanceModel
{
    public string AccountHolderName { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public string BankName { get; set; } = string.Empty;
    public string AccountType { get; set; } = string.Empty;
    public string Currency { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public decimal MonthlyIncome { get; set; }
    public decimal MonthlyExpense { get; set; }
    public string InvestmentType { get; set; } = string.Empty;
    public decimal InvestmentAmount { get; set; }
    public string CreditScoreCategory { get; set; } = string.Empty;
    public int CreditScore { get; set; }
    public DateTime AccountOpenedDate { get; set; }
    public DateTime LastTransactionDate { get; set; }
    public string FinancialAdvisor { get; set; } = string.Empty;
}
