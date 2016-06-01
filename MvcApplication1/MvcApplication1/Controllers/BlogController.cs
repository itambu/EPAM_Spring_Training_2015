using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class BlogController : Controller
    {
        //
        // GET: /Blog/
        [Authorize]
        public ActionResult Index()
        {
            var items = new DAL.BlogRepository()
                .GetAll()
                .Select(x => new Blog() { Id = x.Id, Description = x.Description, PublishDate = x.PublishDate });
            return View(items);
        }


        public ActionResult Details(int id)
        {
            var item = new DAL.BlogRepository()
                .GetAll().Where(x=>x.Id == id)
                .Select(x => new Blog() { Id = x.Id, Description = x.Description, PublishDate = x.PublishDate })
                .FirstOrDefault();
            return PartialView(item);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var item = new DAL.BlogRepository()
                .GetAll().Where(x=>x.Id == id)
                .Select(x => new Blog() { Id = x.Id, Description = x.Description, PublishDate = x.PublishDate })
                .FirstOrDefault();
            return PartialView("Edit", item);
        }


        [HttpPost]
        public ActionResult Edit(Blog model)
        {
            TryValidateModel(model);
            if (ModelState.IsValid)
            {
                var item = new DAL.BlogRepository()
                    .GetAll().Where(x => x.Id == model.Id).FirstOrDefault();
                item.Description = model.Description;
                item.PublishDate = model.PublishDate;

                if (Request.IsAjaxRequest())
                {
                    return new EmptyResult();
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Error");
            }
        }

        
        public ActionResult BlogList()
        {
            var item = new DAL.BlogRepository()
                .GetAll()
                .Select(x => new Blog() { Id = x.Id, Description = x.Description, PublishDate = x.PublishDate });
            return PartialView("PartialBlogList", item);
        }
    }
}
