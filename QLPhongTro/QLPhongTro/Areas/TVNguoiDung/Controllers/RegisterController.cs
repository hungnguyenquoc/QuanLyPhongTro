using QLPhongTro.Areas.TVNguoiDung.Models;
using QLPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLPhongTro.Areas.TVNguoiDung.Controllers
{
    public class RegisterController : Controller
    {
        // GET: TVNguoiDung/Register
        public ActionResult Index()
        {
            if (Session["username"] == null || (string)Session["Quyen"] == "0")
            {
                return RedirectToAction("Index", "Login", new { @area = "" });
            }
            ViewBag.listInfoPhong = new MRegister().getListPhong();
            return View();
        }
        public JsonResult DatPhong(int RoomID) // Ham xu ly dat phong
        {
            return Json(new MRegister().DatPhong(RoomID, new ModifyTVNguoiDung().GetIDByUsername((string)Session["username"])), JsonRequestBehavior.AllowGet);
        }
    }
}