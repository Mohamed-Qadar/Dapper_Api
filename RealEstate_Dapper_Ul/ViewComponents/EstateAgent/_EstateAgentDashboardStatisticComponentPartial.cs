//using Microsoft.AspNetCore.Mvc;

//namespace RealEstate_Dapper_Ul.ViewComponents.EstateAgent
//{
//    public class _EstateAgentDashboardStatisticComponentPartial:ViewComponent
//    {
//        public IViewComponentResult Invoke()
//        {
//            return View();
//        }
//    }
//}
using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Ul.ViewComponents.EstateAgent
{
    public class _EstateAgentDashboardStatisticComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _EstateAgentDashboardStatisticComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;

        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region Istatistik1-Toplan Ilan sayisi
            var client1 = _httpClientFactory.CreateClient();
            var responsMessage1 = await client1.GetAsync("https://localhost:44379/api/EstateAgentDashboardStatistic/AllProductCount");
            var jsonData1 = await responsMessage1.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData1;

            #endregion


            #region Istatistik2Kullancinintoplamilamsayisi

            var client2 = _httpClientFactory.CreateClient();
            var responsMessage2 = await client2.GetAsync("https://localhost:44379/api/EstateAgentDashboardStatistic/ProductCountByEmployeeId?id=1");
            var jsonData2 = await responsMessage2.Content.ReadAsStringAsync();
            ViewBag.EmployeeByProductCount = jsonData2;

            #endregion


            #region Istatistik3Aktif ilan sayisi
            var client3 = _httpClientFactory.CreateClient();
            var responsMessage3 = await client3.GetAsync("https://localhost:44379/api/EstateAgentDashboardStatistic/ProductCountByStatusTrue?id=1");
            var jsonData3 = await responsMessage3.Content.ReadAsStringAsync();
            ViewBag.productCountByEmployeeByStatusTrue = jsonData3;

            #endregion


            #region Istatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responsMessage4 = await client4.GetAsync("https://localhost:44379/api/EstateAgentDashboardStatistic/ProductCountByStatusFalse?id=1");
            var jsonData4 = await responsMessage4.Content.ReadAsStringAsync();
            ViewBag.productCountByEmployeeByStatusFalse = jsonData4;

            #endregion

            return View();
        }
    }
}

