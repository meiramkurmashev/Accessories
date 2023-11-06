using Accessories.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Accessories.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {

            ////извлечение данных из таблицы Wagons
            //IEnumerable<Wagon> wagons = wagonContext.Wagons;
            //ViewBag.Wagons = wagons;
            Categories categories = new Categories();
            //wagons.Lee();
            List<Two> listCategories = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            categories.Cat(ref listCategories);
            //listp.Capacity = 1;
            ViewBag.listCategories = listCategories;

            //ViewBag.wagons.www;
            return View();

        }
        public ActionResult Objects()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}