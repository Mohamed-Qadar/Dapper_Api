using Dapper;
using RealEstate_Dapper_Api.Dtos.EmployeeDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly Context _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
        }
        public async void CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            string query = "insert into Employee (Name, Title,Mail,PhoneNumber,ImageUrl,Status ) values (@name ,@title,@mail,@phoneNumber,@imageUrl,@status)";
            var parameters = new DynamicParameters();
            parameters.Add("@name", createEmployeeDto.Name);
            parameters.Add("@title", createEmployeeDto.Title);
            parameters.Add("@mail", createEmployeeDto.Mail);
            parameters.Add("@phoneNumber", createEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", createEmployeeDto.ImageUrl);
            parameters.Add("@status", true);
            using (var connecton = _context.CreateConnection())
            {
                await connecton.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteEmployee(int id)
        {

            string query = "Delete from Employee where EmployeeID = @employeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeID", id);
            using (var connecton = _context.CreateConnection())
            {
                await connecton.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultEmployeeDto>> GetAllEmployeeAsync()
        {
            string query = "Select * from Employee";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultEmployeeDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIDEmployeeDto> GetEmployee(int id)
        {
            string query = "select * from Employee where EmployeeID =@EmployeeID";
            var parameters = new DynamicParameters();
            parameters.Add("@EmployeeID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDEmployeeDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateEmployeey(UpdateEmployeeDto updateEmployeeDto)
        {
            string query = "Update Employee set Name =@name, Title=@title,Mail=@mail,PhoneNumber=@phoneNumber,ImageUrl=@imageUrl,Status= @status where EmployeeID=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@name", updateEmployeeDto.Name);
            parameters.Add("@title", updateEmployeeDto.Title);
            parameters.Add("@mail", updateEmployeeDto.Mail);
            parameters.Add("@phoneNumber", updateEmployeeDto.PhoneNumber);
            parameters.Add("@imageUrl", updateEmployeeDto.ImageUrl);
            parameters.Add("@status", updateEmployeeDto.Status);
            parameters.Add("@employeeId", updateEmployeeDto.EmployeeID);
            using (var connecton = _context.CreateConnection())
            {
                await connecton.ExecuteAsync(query, parameters);
            }
        }
    }
}
