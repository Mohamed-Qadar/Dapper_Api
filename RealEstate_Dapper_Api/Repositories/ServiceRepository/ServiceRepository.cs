using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public class ServiceRepository : IServiceRepository
    {

        private readonly Context _context;

        public ServiceRepository(Context context)
        {
            _context = context;
        }

        public async void CreateService(CreateServiceDto createServiceDto)
        {

            string query = "insert into Service (ServiceName,ServiceStatus) values (@serviceName ,@serviceStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceName", createServiceDto.ServiceName);
            parameters.Add("@serviceStatus", true);
            using (var connecton = _context.CreateConnection())
            {
                await connecton.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteService(int id)
        {

            string query = "Delete from Service where ServiceID = @serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connecton = _context.CreateConnection())
            {
                await connecton.ExecuteAsync(query, parameters);
            }
        }
        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            string query = "Select * from Service";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultServiceDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDServiceDto> GetService(int id)
        {

            string query = "select * from Service where ServiceID =@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@serviceID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDServiceDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateService(UpdateServiceDto updateServiceDto)
        {
            string query = "Update Service Set ServiceName =@servicName, ServiceStatus =@serviceStatus where ServiceID =@serviceID";
            var parameters = new DynamicParameters();
            parameters.Add("@servicName", updateServiceDto.ServiceName);
            parameters.Add("@serviceStatus", updateServiceDto.ServiceStatus);
            parameters.Add("@serviceID", updateServiceDto.ServiceID);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
