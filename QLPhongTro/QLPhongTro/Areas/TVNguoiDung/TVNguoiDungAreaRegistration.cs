using System.Web.Mvc;

namespace QLPhongTro.Areas.TVNguoiDung
{
    public class TVNguoiDungAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TVNguoiDung";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TVNguoiDung_default",
                "TVNguoiDung/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}