using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace RealEstate_Dapper_Ul.ViewComponents.Dashboard
{
    public class _DashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region Istatistik1-Toplan Ilan sayisi
            var client1 = _httpClientFactory.CreateClient();
            var responsMessage1 = await client1.GetAsync("https://localhost:44379/api/Statistics/ProductCount");
            var jsonData1 = await responsMessage1.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData1;

            #endregion


            #region Istatistik2 -En basarlli personel

            var client2 = _httpClientFactory.CreateClient();
            var responsMessage2 = await client2.GetAsync("https://localhost:44379/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData2 = await responsMessage2.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData2;

            #endregion


            #region Istatistik3 -Ilandaki sehir sayilari
            var client3 = _httpClientFactory.CreateClient();
            var responsMessage3 = await client3.GetAsync("https://localhost:44379/api/Statistics/DifferentCityCount");
            var jsonData3 = await responsMessage3.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData3;

            #endregion


            #region Istatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responsMessage4 = await client4.GetAsync("https://localhost:44379/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responsMessage4.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceByRent = jsonData4;

            #endregion

            return View();
        }
    }
}
