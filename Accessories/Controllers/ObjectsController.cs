using Accessories.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class ObjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            Categories categories = new Categories();
            //wagons.Lee();
            List<Two> listCategories = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            categories.Cat(ref listCategories);
            //listp.Capacity = 1;
            ViewBag.listCategories = listCategories;

            return View();
        }
        public IActionResult AddObject(int type)
        {
            Categories categories = new Categories();
            //wagons.Lee();
            List<Two> listAttributes = new List<Two>();

            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            categories.Attributes(ref listAttributes, type);
            //listp.Capacity = 1;
            ViewBag.listAttributes = listAttributes;

            return View();
        }
    }
}
