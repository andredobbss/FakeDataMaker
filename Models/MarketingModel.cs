namespace FakeDataMaker.Models
{
    public class MarketingModel
    {
        public string CampaignName { get; set; } = string.Empty;
        public string Channel { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public string ManagerName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Budget { get; set; }
        public int Impressions { get; set; }
        public int Clicks { get; set; }
        public decimal ConversionRate { get; set; }
        public string Status { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string Objective { get; set; } = string.Empty;
        public bool IsA_BTested { get; set; }
        public string ContentFormat { get; set; } = string.Empty;
    }
}
