using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_Ul.Dtos.ContactDtos;

namespace RealEstate_Dapper_Ul.ViewComponents.Dashboard
{
    public class _DashoardLast4ContactComponentPartail:ViewComponent
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public _DashoardLast4ContactComponentPartail(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/Contact/GetLast4Contact");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<Last4ContactResultDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
