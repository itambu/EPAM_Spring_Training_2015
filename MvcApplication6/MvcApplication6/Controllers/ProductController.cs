using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication6.Models;

namespace MvcApplication6.Controllers
{
    public class ProductController : Controller
    {
        List<Product> list = new List<Product>()
            {
                new Product(){Id=1, Description="dgsjgsj", Appeared=DateTime.Now}
            };
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //[Authorize(Roles="Admin")]
        public ActionResult List()
        {
            return View(list);
        }

        [ChildActionOnly]
        public ActionResult ViewProductList(IEnumerable<Product> items)
        {
            return PartialView(items);
        }

        [HttpGet]
        public ActionResult Open(int id)
        {
            if (Request.IsAjaxRequest())
            {
                return PartialView(list.FirstOrDefault(x => x.Id == id));
            }
            return View(list.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public ActionResult Open(Product product)
        {
            if (product != null)
            {
                var temp = this.list.FirstOrDefault(x=>x.Id==product.Id);
                if (temp != null)
                {
                    list[list.IndexOf(temp)] = new Product() { Id = product.Id, Description = product.Description, Appeared = product.Appeared }; 
                }
            }

            return RedirectToAction("List", "Product");
        }
    }
}
