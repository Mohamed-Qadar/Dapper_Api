using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Ul.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
