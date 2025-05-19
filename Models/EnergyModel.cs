namespace FakeDataMaker.Models;

public class EnergyModel
{
    public string CompanyName { get; set; } = string.Empty;
    public string EnergyType { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public string GridCode { get; set; } = string.Empty;
    public string PlantName { get; set; } = string.Empty;
    public double OutputMW { get; set; } // Numérica
    public int NumberOfTurbines { get; set; } // Numérica
    public DateTime CommissionDate { get; set; } // Temporal
    public string Operator { get; set; } = string.Empty;
    public bool IsRenewable { get; set; }
    public string LicenseStatus { get; set; } = string.Empty;
    public DateTime InspectionDate { get; set; } // Temporal
    public string FuelSource { get; set; } = string.Empty;
    public string MaintenanceCycle { get; set; } = string.Empty;
}
