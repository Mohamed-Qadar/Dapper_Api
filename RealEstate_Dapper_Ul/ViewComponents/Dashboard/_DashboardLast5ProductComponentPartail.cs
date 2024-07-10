using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_Ul.Dtos.ProductDtos;

namespace RealEstate_Dapper_Ul.ViewComponents.Dashboard
{
    public class _DashboardLast5ProductComponentPartail:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast5ProductComponentPartail(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44379/api/Products/Last5ProductList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast5ProductWithCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    
    }
}
