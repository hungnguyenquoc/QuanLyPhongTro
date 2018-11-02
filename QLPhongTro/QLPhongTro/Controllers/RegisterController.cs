using QLPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLPhongTro.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Register (register model)
        {
            register re = new register();
            string s = re.Register(model);
            
            return Json(s,JsonRequestBehavior.AllowGet);
        }
    }
}