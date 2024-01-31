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
        public ActionResult Change(int id)
        {
            Attributes attributes = new Attributes();

            List<Three> listAttributes = new List<Three>();


            attributes.Att(ref listAttributes, id);

            ViewBag.listAttributes = listAttributes;
            ViewBag.id = id;

            return View();

        }
        public ActionResult ChangeAtt(int id)
        {
            Attributes attributes = new Attributes();

            List<Two> listAttributes = new List<Two>();


            attributes.AttChange(ref listAttributes, id);

            ViewBag.listAttributes = listAttributes;
            ViewBag.id = id;

            return View();

        }
        public ActionResult Delete(int id)
        {
            Attributes attributes = new Attributes();

            

            attributes.Delete(id);

            return View();

        }
    
    }
}
