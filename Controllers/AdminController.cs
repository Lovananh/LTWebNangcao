using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}