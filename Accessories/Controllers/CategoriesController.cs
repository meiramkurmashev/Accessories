using Accessories.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;
using static Google.Protobuf.Collections.MapField<TKey, TValue>;

namespace Accessories.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: CategoriesController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult AddCategory(string name)
        {
            Categories add = new Categories();
            add.AddCategory(name);
           
            
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
       

    }
}