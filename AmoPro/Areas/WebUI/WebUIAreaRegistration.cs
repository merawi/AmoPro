using System.Web.Mvc;

namespace AmoPro.Areas.WebUI
{
    public class WebUIAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "WebUI";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "WebUI_default",
                "WebUI/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
