using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_Ul.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public StatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task <IActionResult> Index()
        {
            #region Istatistik1
            var client = _httpClientFactory.CreateClient();
            var responsMessage = await client.GetAsync("https://localhost:44379/api/Statistics/ActiveCategorYCount");
            var jsonData = await responsMessage.Content.ReadAsStringAsync();
            ViewBag.ActiveCategorYCount = jsonData;

            #endregion

            #region Istatistik2
            var client2 = _httpClientFactory.CreateClient();
            var responsMessage2 = await client2.GetAsync("https://localhost:44379/api/Statistics/ActiveEmployeeCount");
            var jsonData2 = await responsMessage2.Content.ReadAsStringAsync();
            ViewBag.ActiveEmployeeCount = jsonData2;

            #endregion

            #region Istatistik3
            var client3 = _httpClientFactory.CreateClient();
            var responsMessage3 = await client3.GetAsync("https://localhost:44379/api/Statistics/ApartmentCount");
            var jsonData3 = await responsMessage3.Content.ReadAsStringAsync();
            ViewBag.ApartmentCount = jsonData3;

            #endregion


            #region Istatistik4
            var client4 = _httpClientFactory.CreateClient();
            var responsMessage4 = await client4.GetAsync("https://localhost:44379/api/Statistics/AverageProductPriceByRent");
            var jsonData4 = await responsMessage4.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceByRent = jsonData4;

            #endregion


            #region Istatistik5
            var client5 = _httpClientFactory.CreateClient();
            var responsMessage5 = await client5.GetAsync("https://localhost:44379/api/Statistics/AverageProductPriceBySales");
            var jsonData5 = await responsMessage5.Content.ReadAsStringAsync();
            ViewBag.AverageProductPriceBySales = jsonData5;

            #endregion


            #region Istatistik6
            var client6 = _httpClientFactory.CreateClient();
            var responsMessage6 = await client6.GetAsync("https://localhost:44379/api/Statistics/AverageRoomCount");
            var jsonData6 = await responsMessage6.Content.ReadAsStringAsync();
            ViewBag.AverageRoomCount = jsonData6;

            #endregion


            #region Istatistik7
            var client7 = _httpClientFactory.CreateClient();
            var responsMessage7 = await client7.GetAsync("https://localhost:44379/api/Statistics/CategoryCount");
            var jsonData7 = await responsMessage7.Content.ReadAsStringAsync();
            ViewBag.CategoryCount = jsonData7;

            #endregion

            #region Istatistik8
            var client8 = _httpClientFactory.CreateClient();
            var responsMessage8 = await client8.GetAsync("https://localhost:44379/api/Statistics/CategoryNameByMaxProductCount");
            var jsonData8= await responsMessage8.Content.ReadAsStringAsync();
            ViewBag.categoryNameByMaxProductCount = jsonData8;

            #endregion


            #region Istatistik9
            var client9 = _httpClientFactory.CreateClient();
            var responsMessage9 = await client9.GetAsync("https://localhost:44379/api/Statistics/CityNameByMaxProductCount");
            var jsonData9 = await responsMessage9.Content.ReadAsStringAsync();
            ViewBag.CityNameByMaxProductCount = jsonData9;

            #endregion


            #region Istatistik10
            var client10 = _httpClientFactory.CreateClient();
            var responsMessage10 = await client10.GetAsync("https://localhost:44379/api/Statistics/DifferentCityCount");
            var jsonData10 = await responsMessage10.Content.ReadAsStringAsync();
            ViewBag.DifferentCityCount = jsonData10;

            #endregion


            #region Istatistik11
            var client11= _httpClientFactory.CreateClient();
            var responsMessage11 = await client11.GetAsync("https://localhost:44379/api/Statistics/EmployeeNameByMaxProductCount");
            var jsonData11 = await responsMessage11.Content.ReadAsStringAsync();
            ViewBag.EmployeeNameByMaxProductCount = jsonData11;

            #endregion

            #region Istatistik12
            var client12 = _httpClientFactory.CreateClient();
            var responsMessage12 = await client12.GetAsync("https://localhost:44379/api/Statistics/LastProductPrice");
            var jsonData12 = await responsMessage12.Content.ReadAsStringAsync();
            ViewBag.LastProductPrice = jsonData12;

            #endregion

            #region Istatistik13
            var client13 = _httpClientFactory.CreateClient();
            var responsMessage13 = await client13.GetAsync("https://localhost:44379/api/Statistics/NewestBuildingYear");
            var jsonData13 = await responsMessage13.Content.ReadAsStringAsync();
            ViewBag.NewestBuildingYear = jsonData13;

            #endregion


            #region Istatistik14
            var client14 = _httpClientFactory.CreateClient();
            var responsMessage14 = await client14.GetAsync("https://localhost:44379/api/Statistics/oldestBuildingYear");
            var jsonData14 = await responsMessage14.Content.ReadAsStringAsync();
            ViewBag.oldestBuildingYear = jsonData14;

            #endregion


            #region Istatistik15
            var client15 = _httpClientFactory.CreateClient();
            var responsMessage15 = await client15.GetAsync("https://localhost:44379/api/Statistics/PassiveCategorYCount");
            var jsonData15 = await responsMessage15.Content.ReadAsStringAsync();
            ViewBag.PassiveCategorYCount = jsonData15;

            #endregion


            #region Istatistik16
            var client16 = _httpClientFactory.CreateClient();
            var responsMessage16 = await client16.GetAsync("https://localhost:44379/api/Statistics/ProductCount");
            var jsonData16 = await responsMessage16.Content.ReadAsStringAsync();
            ViewBag.ProductCount = jsonData16;

            #endregion








            return View();
        }

        
    }
}
