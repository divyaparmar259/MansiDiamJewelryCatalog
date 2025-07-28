using JewelryCatalog.Models;

namespace JewelryCatalog.Services
{
    public class JewelryService
    {
        public static List<JewelryProduct> GetAll() => new()
    {
        new JewelryProduct
        {
            SerialNumber = 1,
            ProductCode="J001",
            Category = "Gold Necklace",
            GoldType = "14 KT ROSE GOLD",
            GWT = "3.167",
            NWT = "3.167",
            SmallDiamondPCS=16,
            SmallDiamondUsed="0.42",
            SmallDiamondPrice="9000",
            SoliterDiamondPCS = 2,
            SoliterDiamondUsed="0.14",
            SoliterDiamondPrice="10500",
            TotalDiamondInCTS ="0.62",
            TotalDiamondPrice = "3780",
            Labour = "600",
            TotalAmount = "52000"
        },
       
        // Add more items as needed
    };

        public static JewelryProduct? GetBySerial(string serial)
        {
            return GetAll().FirstOrDefault(p => p.ProductCode.Equals(serial, StringComparison.OrdinalIgnoreCase));
        }
    }
}
