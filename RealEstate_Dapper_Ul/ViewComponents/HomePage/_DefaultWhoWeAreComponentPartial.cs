using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_Ul.Dtos.WhoWeAreDtos;
using ResultServiceDto = RealEstate_Dapper_Ul.Dtos.ServiceDtos.ResultServiceDto;

namespace RealEstate_Dapper_Ul.ViewComponents.HomePage
{
    public class _DefaultWhoWeAreComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultWhoWeAreComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cleint = _httpClientFactory.CreateClient();
            var cleint2 = _httpClientFactory.CreateClient();
            var responseMessage = await cleint.GetAsync("https://localhost:44379/api/WhoWeAreDetail");
            var responseMessage2 = await cleint2.GetAsync("https://localhost:44379/api/Services");
            if(responseMessage.IsSuccessStatusCode && responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();

               var  value = JsonConvert.DeserializeObject<List<ResultWhoWeAreDetailDto>>(jsonData);
                var value2 = JsonConvert.DeserializeObject<List<ResultServiceDto>>(jsonData2);

                ViewBag.title = value.Select(x => x.Title).FirstOrDefault();
                ViewBag.subtitle = value.Select(x => x.Subtitle).FirstOrDefault();
                ViewBag.description1 = value.Select(x => x.Description1).FirstOrDefault();
                ViewBag.description2 = value.Select(x => x.Description2).FirstOrDefault();
                return View(value2);
            }
            return View();  
        }
    }
}
