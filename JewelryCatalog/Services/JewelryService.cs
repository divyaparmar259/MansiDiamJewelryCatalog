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
        new JewelryProduct
    {
        SerialNumber = "J002",
        ProductTitle = "Diamond Ring",
        GoldType = "18K",
        GWT = 5.2M,
        NWT = 4.9M,
        SoliterDiamond = 1,
        SmallDiamond = 8,
        Labour = 1200,
        RequireData = "No",
        TotalAmount = 28000
    },
    new JewelryProduct
    {
        SerialNumber = "J003",
        ProductTitle = "Bracelet",
        GoldType = "22K",
        GWT = 12.8M,
        NWT = 12.1M,
        SoliterDiamond = 0,
        SmallDiamond = 10,
        Labour = 1500,
        RequireData = "Yes",
        TotalAmount = 34500
    },
    new JewelryProduct
    {
        SerialNumber = "J004",
        ProductTitle = "Pendant Set",
        GoldType = "18K",
        GWT = 9.0M,
        NWT = 8.4M,
        SoliterDiamond = 2,
        SmallDiamond = 12,
        Labour = 1700,
        RequireData = "Yes",
        TotalAmount = 39000
    },
    new JewelryProduct
    {
        SerialNumber = "J005",
        ProductTitle = "Earrings",
        GoldType = "22K",
        GWT = 6.5M,
        NWT = 6.2M,
        SoliterDiamond = 0,
        SmallDiamond = 6,
        Labour = 900,
        RequireData = "No",
        TotalAmount = 21500
    }
        // Add more items as needed
    };

        public static JewelryProduct? GetBySerial(string serial)
        {
            return GetAll().FirstOrDefault(p => p.SerialNumber.Equals(serial, StringComparison.OrdinalIgnoreCase));
        }
    }
}
