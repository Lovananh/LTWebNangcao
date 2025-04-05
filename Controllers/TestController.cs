using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApp1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        // 2️⃣ Tiếp nhận tham số qua Request
        //[HttpPost]
        //public ActionResult LoginRequest()
        //{
        //    string username = Request.Form["Username"];
        //    string password = Request.Form["Password"];

        //    //if (username == "admin" && password == "123456")
        //    //{
        //    //    return Content("Đăng nhập thành công! (Request)");
        //    //}
        //    return Content($"Username: {username}, Password: {password}");
        //}

        //// 2️⃣ Tiếp nhận tham số qua Request
        //[HttpPost]
        //public ActionResult LoginRequest()
        //{
        //    string username = Request.Form["Username"];
        //    string password = Request.Form["Password"];

        //    if (username == "admin" && password == "123456")
        //    {
        //        return Content("Đăng nhập thành công! (Request)");
        //    }
        //    return Content("Sai tài khoản hoặc mật khẩu! (Request)");
        //}

        //// 3️⃣ Tiếp nhận tham số qua FormCollection
        //[HttpPost]
        //public ActionResult LoginFormCollection(IFormCollection form)
        //{
        //    string username = form["Username"];
        //    string password = form["Password"];

        //    if (username == "admin" && password == "123456")
        //    {
        //        return Content("Đăng nhập thành công! (FormCollection)");
        //    }
        //    return Content("Sai tài khoản hoặc mật khẩu! (FormCollection)");
        //}

        //// 4️⃣ Tiếp nhận tham số qua đối số Action
        [HttpGet]
        public ActionResult LoginAction(string Username, string Password)
        {
            //if (Username == "admin" && Password == "123456")
            //{
            //    return Content("Đăng nhập thành công! (Action Parameters)");
            //}
            //return Content("Sai tài khoản hoặc mật khẩu! (Action Parameters)");
            return Content($"Username: {Username}, Password: {Password}");
        }

        //// 5️⃣ Tiếp nhận tham số qua Model
        //[HttpPost]
        //public ActionResult LoginModel(LoginModel model)
        //{
        //    if (model.Username == "admin" && model.Password == "123456")
        //    {
        //        return Content("Đăng nhập thành công! (Model)");
        //    }
        //    return Content("Sai tài khoản hoặc mật khẩu! (Model)");
        //}
    }
}