namespace JewelryCatalog.Models
{
    public class JewelryProduct
    {
        public int SerialNumber { get; set; }
        public string ProductCode { get; set; }
        public string? Category { get; set; }
        public string? GoldType { get; set; }
        public string? GWT { get; set; }
        public string? NWT { get; set; }

        public int? SmallDiamondPCS { get; set; }
        public string? SmallDiamondUsed { get; set; }
        public string? SmallDiamondPrice { get; set; }
        public int? SoliterDiamondPCS { get; set; }

        public string? SoliterDiamondUsed { get; set; }
        public string? SoliterDiamondPrice { get; set; }
        public string? TotalDiamondInCTS { get; set; }
        public string? TotalDiamondPrice { get; set; }
        public string? Labour { get; set; }     
        public string? TotalAmount { get; set; }
    }
}
