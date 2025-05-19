namespace FakeDataMaker.Models;

public class HospitalityModel
{
    public string GuestName { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public string ReservationCode { get; set; } = string.Empty;
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public decimal RoomRate { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
    public string ServicePackage { get; set; } = string.Empty;
    public string HotelBranch { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public bool IsVIP { get; set; }
    public string CountryOfOrigin { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public DateTime BookingDate { get; set; }
    public int NightsStayed { get; set; }
}
