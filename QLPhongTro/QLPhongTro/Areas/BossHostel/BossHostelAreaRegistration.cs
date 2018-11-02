using System.Web.Mvc;

namespace QLPhongTro.Areas.BossHostel
{
    public class BossHostelAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BossHostel";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BossHostel_default",
                "BossHostel/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}