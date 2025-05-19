namespace FakeDataMaker.Models;

public class RetailModel
{
    public string ProductId { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string SKU { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public int SoldQuantity { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime LastSoldDate { get; set; }
    public string Supplier { get; set; } = string.Empty;
    public string WarehouseLocation { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool IsDiscounted { get; set; }
    public string Status { get; set; } = string.Empty;
}
