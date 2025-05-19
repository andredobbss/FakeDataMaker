namespace FakeDataMaker.Models;

public class RealEstateModel
{
    public string PropertyId { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public string ZipCode { get; set; } = string.Empty;
    public string PropertyType { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public double AreaSquareFeet { get; set; }
    public DateTime ListingDate { get; set; }
    public DateTime AvailableFrom { get; set; }
    public string AgentName { get; set; } = string.Empty;
    public bool IsFurnished { get; set; }
    public string Status { get; set; } = string.Empty;
}
