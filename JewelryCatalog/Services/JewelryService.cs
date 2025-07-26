using JewelryCatalog.Models;

namespace JewelryCatalog.Services
{
    public class JewelryService
    {
        public static List<JewelryProduct> GetAll() => new()
    {
        new JewelryProduct
        {
            SerialNumber = "J001",
            ProductTitle = "Gold Necklace",
            GoldType = "22K",
            GWT = 25.5M,
            NWT = 24.2M,
            SoliterDiamond = 3,
            SmallDiamond = 15,
            Labour = 1800,
            RequireData = "Yes",
            TotalAmount = 51200
        },

        // Add more items as needed
    };

        public static JewelryProduct? GetBySerial(string serial)
        {
            return GetAll().FirstOrDefault(p => p.SerialNumber.Equals(serial, StringComparison.OrdinalIgnoreCase));
        }
    }
}
