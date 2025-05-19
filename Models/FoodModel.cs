namespace FakeDataMaker.Models;

public class FoodModel
{
    public string ProductName { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public string OriginCountry { get; set; } = string.Empty;
    public string SupplierName { get; set; } = string.Empty;
    public DateTime ProductionDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public decimal Price { get; set; }
    public double WeightInKg { get; set; }
    public int Calories { get; set; }
    public string Ingredients { get; set; } = string.Empty;
    public string PackagingType { get; set; } = string.Empty;
    public string StorageInstructions { get; set; } = string.Empty;
    public string Certification { get; set; } = string.Empty;
    public string NutritionalClaim { get; set; } = string.Empty;
}
