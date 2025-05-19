namespace FakeDataMaker.Models;

public class TransportationModel
{
    public string VehicleId { get; set; } = string.Empty;
    public string VehicleType { get; set; } = string.Empty;
    public string LicensePlate { get; set; } = string.Empty;
    public string DriverName { get; set; } = string.Empty;
    public string Route { get; set; } = string.Empty;
    public string Origin { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public double DistanceKm { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public string Status { get; set; } = string.Empty;
    public string CarrierCompany { get; set; } = string.Empty;
    public int CargoWeightKg { get; set; }
    public bool IsDelayed { get; set; }
    public string Comments { get; set; } = string.Empty;
}
