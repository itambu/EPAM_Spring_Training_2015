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
 
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        //[Authorize(Roles="Admin")]
        public ActionResult List()
        {
            return View(new Repositories.ProductRepository().GetAll());
        }

        [ChildActionOnly]
        public ActionResult ViewProductList(IEnumerable<Product> items)
        {
            return PartialView(items);
        }

        [HttpGet]
        public ActionResult Open(int id)
        {
            var repo = new Repositories.ProductRepository();
            if (Request.IsAjaxRequest())
            {
                return PartialView(repo.FirstOrDefault(x => x.Id == id));
            }
            return View(repo.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost]
        public ActionResult Open(Product product)
        {
            if (product != null)
            {
                var repo = new Repositories.ProductRepository();
                repo.Update(product); 
            }

            return RedirectToAction("List", "Product");
        }
    }
}
