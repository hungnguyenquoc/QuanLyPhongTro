using QLPhongTro.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLPhongTro.Areas.Admin.Controllers
{
    public class QLNguoiDungController : Controller
    {
        // GET: Admin/QLNguoiDung
        public ActionResult Index()
        {
            ViewBag.ListTVNguoiDung = new ModifyTVNguoiDung().GetList();
            return View();
        }
        public JsonResult Delete(int UserID)
        {
            new ModifyTVNguoiDung().Delete(UserID);
            return Json("true",JsonRequestBehavior.AllowGet);
        }
    }
}