using Dapper;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.Last5ProductsRepositories
{
    public class Last5ProductsRepository : ILast5ProductsRepository
    {
        private readonly Context _context;
        public Last5ProductsRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id)
        {
            //string query = "select Top(5) * from Product Where Type='Kiralik' order by ProductID Desc";
            //string query = "select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,AdvertismentDate from Product Inner Join Category 
            //on Product.ProductCategory = Category.categoryID Where Type = 'Kiralik' order by ProductID Desc";
            string query = "select Top(5) ProductID,Title,Price,City,District,ProductCategory,CategoryName,AdvertismentDate from Product Inner Join Category \r\non Product.ProductCategory=Category.categoryID Where EmployeeId =@employeeId order by ProductID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query,parameters);
                return values.ToList();
            }
        }
        
        
    
    }
}
