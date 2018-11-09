using QLPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLPhongTro.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public JsonResult Login(login model)
        {
            string check = new login().VerifyLogin(model.userName, model.passWord);
            if (check != "false")
            {
                Session["username"] = model.userName;
                Session["Quyen"] = check;
            }
            return Json(check, JsonRequestBehavior.AllowGet);
        }
    }
}