using Accessories.Models;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Utilities;
using Objects = Accessories.Models.Objects;

namespace Accessories.Controllers
{
    public class ObjectsController : Controller
    {
        public IActionResult Index()
        {

            Objects objects = new Objects();

            List<Six> listObjects = new List<Six>();



            objects.Obj(ref listObjects);
            ViewBag.listObjects = listObjects;
            return View();
        }
        public IActionResult Add()
        {
            Categories categories = new Categories();
            
            List<Two> listCategories = new List<Two>();

            categories.Cat(ref listCategories);
            
            ViewBag.listCategories = listCategories;
            
            return View();
        }
        public IActionResult AddObject(int type)
        {
            Categories categories = new Categories();
            Categories categories1 = new Categories();
            //wagons.Lee();
            List<Two> listAttributes = new List<Two>();
            
            //Console.WriteLine(www);
            //Convert.ToUInt32(www);
            categories.Attributes(ref listAttributes, type);
            //listp.Capacity = 1;
            ViewBag.listAttributes = listAttributes;
            ViewBag.type = type;
            
            int col = categories1.Col(type);

            ViewBag.col = col;
            return View();
        }
        public IActionResult Complete(string name, int price, string about, int col)
            {
            ViewBag.Col = col;
            return View();
        }
    }
}
