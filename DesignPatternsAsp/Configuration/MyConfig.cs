namespace DesignPatternsAsp.Configuration
{
    public class MyConfig
    {
        public string PathLog { get; set; } = string.Empty;
        public decimal LocalPercentage { get; set; }
        public decimal ForeignPercentage { get; set; }
        public decimal Extra { get; set; }
    }
}
