using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Login");
            }
            return View();
        }
    }
}