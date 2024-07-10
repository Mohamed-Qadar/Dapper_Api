using RealEstate_Dapper_Ul.Services;
using System.Security.Claims;

namespace RealEstate_Dapper_Ul.Services
{
    public class LoginService : ILoginService
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public LoginService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        //kana wuu shaqay
         public object GetUserId => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        string ILoginService.GetUserId => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

        //kana wuu shaqay hadii uu error kasoboxo ka kare aan furi
        //object ILoginService.GetUserId => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
    }
}

//private readonly IHttpContextAccessor _contextAccessor;

//public LoginService(IHttpContextAccessor contextAccessor)
//{
//    _contextAccessor = contextAccessor;
//}

//public string GetUserId => _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;