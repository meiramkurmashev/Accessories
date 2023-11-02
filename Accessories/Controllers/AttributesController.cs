using Accessories.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accessories.Controllers
{
    public class AttributesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(int cat_id)
        {
            

            ViewBag.Id_category = cat_id;

            return View();
        }
        public IActionResult AddAttributeComplete(string name , int category_id)
        {

            Attributes addAttribute = new Attributes();


            addAttribute.AddAttribute(name,category_id);
            return View();

        }
    }
}
