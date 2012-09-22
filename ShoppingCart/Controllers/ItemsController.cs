using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingCart.Models;

namespace ShoppingCart.Controllers
{
    [HandleError]
    public class ItemsController : Controller
    {
        public ActionResult List()
        {
            Heroes heroes = new Heroes();
            ViewData["heroes"] = heroes.getHeroes();

            return View();
        }

        public ActionResult Detail(string id)
        {
            ViewData["hero"] = id;
            return View();
        }

        public ActionResult Cart()
        {
            return View();
        }
    }
}