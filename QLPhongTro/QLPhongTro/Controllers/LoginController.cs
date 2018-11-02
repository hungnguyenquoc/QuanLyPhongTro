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
            //login l = new login();
            //string s = l.VerifyLogin(model.userName, model.passWord);
            //return Json(s, JsonRequestBehavior.AllowGet);

            return Json( new login().VerifyLogin(model.userName,model.passWord), JsonRequestBehavior.AllowGet);
        }
    }
}