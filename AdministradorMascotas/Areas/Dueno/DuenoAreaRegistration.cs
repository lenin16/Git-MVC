using System.Web.Mvc;

namespace AdministradorMascotas.Areas.Dueno
{
    public class DuenoAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Dueno";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Dueno_default",
                "Dueno/{controller}/{action}/{id}",
                new { action = "Inicio", id = UrlParameter.Optional }
            );
        }
    }
}