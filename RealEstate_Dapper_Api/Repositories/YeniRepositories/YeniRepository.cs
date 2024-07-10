//using Dapper;
//using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
//using RealEstate_Dapper_Api.Models.DapperContext;

//namespace RealEstate_Dapper_Api.Repositories.YeniRepositories
//{
//    public class YeniRepository : IYeniRepository
//    {
//        private readonly Context _context;

//        public YeniRepository(Context context)
//        {
//            _context = context;
//        }

//        public async void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
//        {
//            string query = "insert into PopularLocation (CityName,ImageUrl) values (@cityNamne ,@imgageUrl)";
//            var parameters = new DynamicParameters();
//            parameters.Add("@cityNamne", createPopularLocationDto.CityName);
//            parameters.Add("@imgageUrl", createPopularLocationDto.ImageUrl);
//            using (var connecton = _context.CreateConnection())
//            {
//                await connecton.ExecuteAsync(query, parameters);
//            }
//        }

//        public async void DeletePopularLocation(int id)
//        {

//            string query = "Delete from PopularLocation where LocationID = @locationID";
//            var parameters = new DynamicParameters();
//            parameters.Add("@locationID", id);
//            using (var connecton = _context.CreateConnection())
//            {
//                await connecton.ExecuteAsync(query, parameters);
//            }
//        }

//        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
//        {
//            string query = "Select * from PopularLocation";
//            using (var connection = _context.CreateConnection())
//            {
//                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
//                return values.ToList();
//            }
//        }

//        public async Task<GetByIDPopularLocationDto> GetPopularLocation(int id)
//        {
//            string query = "select * from PopularLocation where LocationID =@locationID";
//            var parameters = new DynamicParameters();
//            parameters.Add("@locationID", id);
//            using (var connection = _context.CreateConnection())
//            {
//                var values = await connection.QueryFirstOrDefaultAsync<GetByIDPopularLocationDto>(query, parameters);
//                return values;
//            }
//        }

//        public async void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
//        {
//            string query = "Update PopularLocation Set CityName =@cityName, ImageUrl =@imageUrl where LocationID =@locationID";
//            var parameters = new DynamicParameters();
//            parameters.Add("@cityName", updatePopularLocationDto.CityName);
//            parameters.Add("@imageUrl", updatePopularLocationDto.ImageUrl);
//            parameters.Add("@locationID", updatePopularLocationDto.LocationID);
//            using (var connection = _context.CreateConnection())
//            {
//                await connection.ExecuteAsync(query, parameters);
//            }
//        }
//    }
//}
