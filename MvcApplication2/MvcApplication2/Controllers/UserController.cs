using MvcApplication2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication2.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        ICollection<UserModel> _users = new List<UserModel>()
        {
            new UserModel(){FirstName="Вася", LastName="Волков"},
            new UserModel(){FirstName="Вася", LastName="Волков"}
        };

        public ActionResult List()
        {
            return View(_users);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return PartialView(_users.First());
        }        

        [HttpPost]
        public ActionResult Edit(UserModel model)
        {
            return View(model);
        }

        //public ActionResult 
    }
}
