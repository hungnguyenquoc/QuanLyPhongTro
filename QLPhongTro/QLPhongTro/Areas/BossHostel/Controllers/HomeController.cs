using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLPhongTro.Areas.BossHostel.Controllers
{
    public class HomeController : Controller
    {
        // GET: BossHostel/Home
        public ActionResult Index()
        {
            if (Session["username"] == null || (string)Session["Quyen"] == "1")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            return View();
        }
    }
}