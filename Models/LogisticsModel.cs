namespace FakeDataMaker.Models;

public class LogisticsModel
{
    public string ShipmentId { get; set; } = string.Empty;
    public string CarrierName { get; set; } = string.Empty;
    public string Origin { get; set; } = string.Empty;
    public string Destination { get; set; } = string.Empty;
    public DateTime DepartureDate { get; set; }
    public DateTime EstimatedArrival { get; set; }
    public string TransportMode { get; set; } = string.Empty;
    public string DriverName { get; set; } = string.Empty;
    public string VehiclePlate { get; set; } = string.Empty;
    public decimal DistanceKm { get; set; }
    public decimal FreightCost { get; set; }
    public string CargoDescription { get; set; } = string.Empty;
    public int CargoWeightKg { get; set; }
    public string Status { get; set; } = string.Empty;
    public string TrackingCode { get; set; } = string.Empty;
}
