using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Ul.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPatial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
