using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Ul.ViewComponents.HomePage
{
    public class _DefaultSubFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
