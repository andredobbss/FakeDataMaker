namespace FakeDataMaker.Models;

public class MediaPublishingModel
{
    public string ArticleId { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public DateTime PublishDate { get; set; }
    public string Category { get; set; } = string.Empty;
    public string Language { get; set; } = string.Empty;
    public string Publisher { get; set; } = string.Empty;
    public int WordCount { get; set; }
    public int ReadTimeMinutes { get; set; }
    public int Views { get; set; }
    public int Shares { get; set; }
    public bool IsFeatured { get; set; }
    public string ContentType { get; set; } = string.Empty;
    public string Tags { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
