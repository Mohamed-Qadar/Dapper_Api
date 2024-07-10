//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
//using RealEstate_Dapper_Api.Repositories.YeniRepositories;

//namespace RealEstate_Dapper_Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class NewOneController : ControllerBase
//    {
//        private readonly IYeniRepository _yeniRepository;

//        public NewOneController(IYeniRepository yeniRepository)
//        {
//            _yeniRepository = yeniRepository;
//        }

//        [HttpGet]
//        public async Task<IActionResult> PopularLocationList()
//        {
//            var value = await _yeniRepository.GetAllPopularLocationAsync();
//            return Ok(value);
//        }


//        [HttpPost]
//        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
//        {
//            _yeniRepository.CreatePopularLocation(createPopularLocationDto);
//            return Ok("lacation basarli bir sekilde eklendi");
//        }
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeletePopularLocation(int id)
//        {
//            _yeniRepository.DeletePopularLocation(id);
//            return Ok("location basarli bir sekilde silindi");
//        }
//        [HttpPut]
//        public async Task<IActionResult> UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
//        {
//            _yeniRepository.UpdatePopularLocation(updatePopularLocationDto);
//            return Ok("laction basarli bir sekilde guncelendi");
//        }
//        [HttpGet("{id}")]
//        public async Task<IActionResult> GetPopularLocation(int id)
//        {
//            var value = await _yeniRepository.GetPopularLocation(id);
//            return Ok(value);
//        }
//    }
//}
