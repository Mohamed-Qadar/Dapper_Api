using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Ul.ViewComponents.Layout
{
    public class _HeaderViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }


    }
}
