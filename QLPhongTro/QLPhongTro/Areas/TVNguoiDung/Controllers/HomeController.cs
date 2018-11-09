using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLPhongTro.Areas.TVNguoiDung.Controllers
{
    public class HomeController : Controller
    {
        // GET: TVNguoiDung/Home
        public ActionResult Index()
        {
            if (Session["username"] == null || (string)Session["Quyen"] != "2")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            return View();
        }
    }
}