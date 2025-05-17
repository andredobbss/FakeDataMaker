namespace FakeDataMaker.Models;

public class AutomotiveModel
{
    public string Manufacturer { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string VehicleType { get; set; } = string.Empty;
    public string EngineType { get; set; } = string.Empty;
    public int Horsepower { get; set; }
    public int Year { get; set; }
    public decimal Price { get; set; }
    public string Color { get; set; } = string.Empty;
    public int NumberOfDoors { get; set; }
    public bool IsElectric { get; set; }
    public string LicensePlate { get; set; } = string.Empty;
    public string VIN { get; set; } = string.Empty;
    public DateTime RegistrationDate { get; set; }
    public decimal FuelEfficiencyKmPerL { get; set; }
    public string CountryOfOrigin { get; set; } = string.Empty;
}
