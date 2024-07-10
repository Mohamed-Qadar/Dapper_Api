using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RealEstate_Dapper_Ul.Dtos.ToDoListDtos;

namespace RealEstate_Dapper_Ul.Controllers
 {
    public class ToDoListController1 : Controller
    {
        public class ToDoListController : Controller
        {
            private readonly IHttpClientFactory _httpClientFactory;
            public ToDoListController(IHttpClientFactory httpClientFactory)
            {
                _httpClientFactory = httpClientFactory;
            }
            public async Task<IActionResult> Index()
            {
                var client = _httpClientFactory.CreateClient();
                var responseMessage = await client.GetAsync("https://localhost:44379/api/Categories");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<ResultToDoListDto>>(jsonData);
                    return View(values);
                }
                return View();
            }
        }
    }
}
