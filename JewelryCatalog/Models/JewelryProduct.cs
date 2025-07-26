namespace JewelryCatalog.Models
{
    public class JewelryProduct
    {
        public string SerialNumber { get; set; }
        public string? ProductTitle { get; set; }
        public string? GoldType { get; set; }
        public decimal? GWT { get; set; }
        public decimal? NWT { get; set; }
        public int? SoliterDiamond { get; set; }
        public int? SmallDiamond { get; set; }
        public decimal? Labour { get; set; }
        public string? RequireData { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
