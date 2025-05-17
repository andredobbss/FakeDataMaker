namespace FakeDataMaker.Models;

public class AerospaceModel
{
    public string AircraftModel { get; set; } = string.Empty;
    public string Manufacturer { get; set; } = string.Empty;
    public string EngineType { get; set; } = string.Empty;
    public double WingspanMeters { get; set; }
    public double LengthMeters { get; set; }
    public int MaxSpeedKmH { get; set; }
    public int RangeKm { get; set; }
    public int CrewSize { get; set; }
    public int PassengerCapacity { get; set; }
    public DateTime FirstFlightDate { get; set; }
    public DateTime CertificationDate { get; set; }
    public DateTime LastMaintenanceDate { get; set; }
    public string CountryOfOrigin { get; set; } = string.Empty;
    public bool InProduction { get; set; }
    public string Description { get; set; } = string.Empty;
}
