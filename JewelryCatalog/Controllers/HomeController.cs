using JewelryCatalog.Models;
using JewelryCatalog.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JewelryCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index() => View();

        //[HttpPost]
        //public IActionResult Search(string serialNumber)
        //{
        //    var product = JewelryService.GetBySerial(serialNumber);
        //    if (product == null)
        //        return View("NotFound"); // optional page
        //    return View("Details", product);
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string serialNumber)
        {
            var product = JewelryService.GetBySerial(serialNumber);
            if (product == null)
            {
                return PartialView("_NotFoundPartial");
            }

            return PartialView("_DetailsPartial", product);
        }
    }
}
