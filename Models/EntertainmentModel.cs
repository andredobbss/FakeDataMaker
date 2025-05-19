namespace FakeDataMaker.Models;

public class EntertainmentModel
{
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public string Platform { get; set; } = string.Empty;
    public string Director { get; set; } = string.Empty;
    public string Producer { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; } 
    public double Rating { get; set; } 
    public int DurationMinutes { get; set; } 
    public string Language { get; set; } = string.Empty;
    public string CountryOfOrigin { get; set; } = string.Empty;
    public string AgeRestriction { get; set; } = string.Empty;
    public string Synopsis { get; set; } = string.Empty;
    public bool IsStreamingAvailable { get; set; }
    public string MainActor { get; set; } = string.Empty;
    public DateTime LastViewed { get; set; }
}
