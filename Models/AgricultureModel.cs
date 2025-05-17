namespace FakeDataMaker.Models;

public class AgricultureModel
{
    public string FarmName { get; set; } = string.Empty;
    public string CropType { get; set; } = string.Empty;
    public string FarmerName { get; set; } = string.Empty;
    public double LandAreaHectares { get; set; }
    public int NumberOfEmployees { get; set; }
    public decimal AnnualRevenue { get; set; }
    public decimal MonthlyCost { get; set; }
    public string Region { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string SoilType { get; set; } = string.Empty;
    public DateTime PlantingDate { get; set; }
    public DateTime HarvestDate { get; set; }
    public bool IsOrganic { get; set; }
    public string IrrigationType { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;
}

