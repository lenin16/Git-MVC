using System.Web.Mvc;

namespace AdministradorMascotas.Areas.TipoMascota
{
    public class TipoMascotaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "TipoMascota";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "TipoMascota_default",
                "TipoMascota/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}