using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login  model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            //ViewBag.Debug = $"Username: {model.Username}, Password: {model.Password}";
            // Kiểm tra đăng nhập đơn giản (có thể thay bằng DB)
            if (model.Username == "admin" && model.Password == "123")
            {
                Session["Admin"] = model.Username;
                return RedirectToAction("Index", "Admin");
            }
            else if (model.Username.ToLower() == "user" && model.Password == "123")
            {
                Session["User"] = model.Username;
                return RedirectToAction("Index", "User");
            }
            else
            {
                ViewBag.Message = "Sai tên đăng nhập hoặc mật khẩu";
                return View(model);
            }
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}