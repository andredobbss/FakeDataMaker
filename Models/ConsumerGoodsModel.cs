namespace FakeDataMaker.Models;

public class ConsumerGoodsModel
{
    public string ProductName { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string SKU { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string OriginCountry { get; set; } = string.Empty;
    public string Supplier { get; set; } = string.Empty;
    public string Barcode { get; set; } = string.Empty;
    public string PackagingType { get; set; } = string.Empty;
    public string Weight { get; set; } = string.Empty;
    public bool IsRecyclable { get; set; }
    public string ProductStatus { get; set; } = string.Empty;
}
