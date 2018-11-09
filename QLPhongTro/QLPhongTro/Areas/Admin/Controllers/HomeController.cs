using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLPhongTro.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            if (Session["username"] == null || (string)Session["Quyen"] == "0")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            return View();
        }
    }
}